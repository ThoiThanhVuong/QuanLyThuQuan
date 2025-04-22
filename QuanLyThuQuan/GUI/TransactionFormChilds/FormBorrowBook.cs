using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormBorrowBook : Form
    {
        private string defaultMemberIDField = "Member ID";
        private List<TransactionListItemTableModel> tables { get; set; }

        public FormBorrowBook()
        {
            InitializeComponent();
        }

        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            SetDefaultForFields();
            CreateTypeForComboBox(new List<ProductType> { ProductType.All, ProductType.Books, ProductType.Devices });
        }

        // NOTE: PLACE FOR OTHER LOGICS
        private void SetDefaultForFields()
        {
            dtpGetGBorrowTransDate.Enabled = false;
            dtpGetGBorrowTransDate.Text = DateTime.Now.ToString();
            tables = new List<TransactionListItemTableModel>();
        }

        private void SetDefaultForTable()
        {
            dgvListProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListProducts.AllowUserToAddRows = false;
        }

        // create items for combobox
        private void CreateTypeForComboBox(List<ProductType> types)
        {
            foreach (ProductType type in types)
                cbxTypeProduct.Items.Add(type);
        }

        // Create Transaction
        private void CreateValidTransaction(string memberID, DateTime dueDate)
        {
            if (!CheckValidValueForTransaction(memberID, dueDate))
                return;
            TransactionModel transaction = new TransactionModel(0, int.Parse(memberID), TransactionType.Borrow, DateTime.Now, dueDate, null, TransactionStatus.Active);
            TransactionBUS transactions = new TransactionBUS();
            transactions.Add(transaction);
            transactions.LoadLocal();
            List<TransactionModel> list = transactions.GetAllLocal();
            TransactionItemBUS details = new TransactionItemBUS();
            details.AddList(CreateDetailTransaction((list[list.Count - 1].TransactionID).ToString()));
            UpdateAmountOfProducts();
            // show alert
            NotificationServices.GetInstance().ShowSuccess("Create new transaction Done!", "Done");

        }

        // Create transaction items 
        private List<TransactionItemModel> CreateDetailTransaction(string transactionID)
        {
            List<TransactionItemModel> list = new List<TransactionItemModel>();
            int id = ValidateParseToOtherType.GetInstance().CanParseToInt(transactionID);
            if (id == -1)
            {
                NotificationServices.GetInstance().ShowError("Error transaction id!", "Error id");
                return list;
            }

            foreach (TransactionListItemTableModel item in tables)
            {
                TransactionItemModel detail = CreateValidTransactionItem(item, id);
                if (detail == null) continue;
                list.Add(detail);
            }
            return list;
        }
        // Get book
        private BookModel GetBookByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            return new BookBUS().GetBookByName(name);
        }

        // Get device
        private DeviceModel GetDeviceByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            return new DeviceBUS().GetDeviceByName(name);
        }

        // Create transaction item
        private TransactionItemModel CreateValidTransactionItem(TransactionListItemTableModel item, int id)
        {
            BookModel book = GetBookByName(item.productName);
            DeviceModel device = GetDeviceByName(item.productName);

            if (book == null && device == null) return null;
            else if (book == null)
                return new TransactionItemModel(0, id, null, device.DeviceID, item.amount);
            else if (device == null)
                return new TransactionItemModel(0, id, book.BookID, null, item.amount);
            return new TransactionItemModel(0, id, book.BookID, device.DeviceID, item.amount);
        }

        // Update amount of products
        private void UpdateAmountOfProducts()
        {
            BookBUS books = new BookBUS();
            DeviceBUS devices = new DeviceBUS();
            foreach (TransactionListItemTableModel item in tables)
            {
                BookModel book = GetBookByName(item.productName);
                DeviceModel device = GetDeviceByName(item.productName);

                // validate 
                if (book == null && device == null) continue;
                else if (book == null)
                {
                    Debug.WriteLine("Devices: " + device.DeviceQuantity);
                    device.DeviceQuantity -= item.amount;
                    Debug.WriteLine("Devices: " + device.DeviceQuantity);
                    devices.UpdateDevice(device);
                }
                else if (device == null)
                {
                    Debug.WriteLine("Books: " + book.BookQuantity);
                    book.BookQuantity -= item.amount;
                    Debug.WriteLine("Books: " + book.BookQuantity);
                    books.UpdateBook(book);
                }
                else
                    continue;
            }
        }
        private void SetViewForTable(List<TransactionListItemTableModel> list)
        {
            this.tables = list; // set for tables
            dgvListProducts.DataSource = (TransactionListItemTableBUS.GetInstance().GetDataSet(list)).Tables[0];
            dgvListProducts.Columns[0].Width = 50;
            dgvListProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListProducts.Columns[2].Width = 50;
            dgvListProducts.ReadOnly = true;
            SetDefaultForTable();
        }

        private List<TransactionListItemTableModel> GetNewTable()
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            DataGridViewRowCollection rows = dgvListProducts.Rows;
            foreach (DataGridViewRow row in dgvListProducts.Rows)
            {
                if (row.IsNewRow) continue;

                string productName = row.Cells["Product Name"].Value.ToString();
                int amount = ValidateParseToOtherType.GetInstance().CanParseToInt(row.Cells["Amount"].Value.ToString());
                if (!IsValidQuantity(productName, amount))
                {
                    NotificationServices.GetInstance().ShowError("amount is invalid !", "Amount Error");
                    amount = 1;
                }
                list.Add(new TransactionListItemTableModel(productName, amount));
            }
            return list;
        }

        // NOTE: PLACE FOR VALIDATION

        private bool IsValidQuantity(string productName, int amount)
        {
            BookModel book = GetBookByName(productName);
            DeviceModel device = GetDeviceByName(productName);

            if (book == null && device == null)
                return false;
            else if (book == null && device.DeviceQuantity < amount)
                return false;
            else if (device == null && book.BookQuantity < amount)
                return false;
            return true;
        }

        private bool CheckValidValueForTransaction(string memberID, DateTime dueDate)
        {
            if (ValidateParseToOtherType.GetInstance().CanParseToInt(memberID) == -1)
            {
                NotificationServices.GetInstance().ShowError("Member ID should be an integer!", "Error memberID");
                return false;
            }
            if (dueDate.CompareTo(DateTime.Today) < 0)
            {
                NotificationServices.GetInstance().ShowError("Due Date should be equal to or greater than today!", "Error DueDate");
                return false;
            }
            return true;
        }

        private bool IsValidProductType(string type)
        {
            if (!type.Equals(ProductType.Books.ToString()) && !type.Equals(ProductType.Devices.ToString()) && !type.Equals(ProductType.All.ToString()))
                return false;
            return true;
        }

        // NOTE: EVENT FOR COMPONENT
        private void txtGetBorrowMemberID_Click(object sender, EventArgs e)
        {
            if (txtGetBorrowMemberID.Text.Equals(defaultMemberIDField))
                txtGetBorrowMemberID.Clear();
        }

        private void btnSubmitFormBorrow_Click(object sender, EventArgs e)
        {
            // get values for transaction and transaction items
            string memberID = txtGetBorrowMemberID.Text;
            DateTime dueDate = dtpGetBorrowDueDate.Value;
            DialogResult result = NotificationServices.GetInstance().ShowConfirm("Are you sure ?", "Confirm");
            if (result == DialogResult.OK)
            {
                dgvListProducts.EndEdit();
                dgvListProducts.Columns["Amount"].ReadOnly = true;
                SetViewForTable(GetNewTable());
                CreateValidTransaction(memberID, dueDate);
                this.Close();
            }
        }

        private void btnExitBorrowProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!IsValidProductType(cbxTypeProduct.Text))
            {
                NotificationServices.GetInstance().ShowError("Select type of product!", "Select type");
                return;
            }
            FormSelectProducts form = new FormSelectProducts(cbxTypeProduct.Text);
            form.ShowDialog();
            SetViewForTable(form.listItems);
        }

        private void btnResetFormBorrow_Click(object sender, EventArgs e)
        {
            txtGetBorrowMemberID.Text = "";
            dtpGetBorrowDueDate.Value = DateTime.Now;
            dgvListProducts.DataSource = null;
        }

        private void btnEditListProducts_Click(object sender, EventArgs e)
        {
            if (dgvListProducts == null || dgvListProducts.Columns["Amount"] == null)
            {
                NotificationServices.GetInstance().ShowError("Not found data!", "Not found");
                return;
            }

            dgvListProducts.ReadOnly = false;
            dgvListProducts.Columns["Product Name"].ReadOnly = true;
            dgvListProducts.Columns["ID"].ReadOnly = true;
            MessageBox.Show("You can now edit the 'Amount' column.");
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            dgvListProducts.EndEdit();
            dgvListProducts.Columns["Amount"].ReadOnly = true;
            SetViewForTable(GetNewTable());
            MessageBox.Show("Changes saved successfully.");
        }

        private void dgvListProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvListProducts.CurrentCell.ColumnIndex == dgvListProducts.Columns["Amount"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= onlyNumbers_KeyPress; // tránh trùng event nhiều lần
                    tb.KeyPress += onlyNumbers_KeyPress;
                }
            }
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ nhận số và phím điều khiển (backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
