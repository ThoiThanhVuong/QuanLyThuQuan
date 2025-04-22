using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormReturnBook : Form
    {
        private TransactionModel transaction { get; set; }
        private List<TransactionListItemTableModel> tables { get; set; }
        public FormReturnBook()
        {
            InitializeComponent();
        }
        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        // NOTE: FOR OTHER LOGICS

        // default settings for data grid view 
        private void SetDefaultForTable()
        {
            dgvListReturnProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPenalty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListReturnProduct.AllowUserToAddRows = false;
            dgvListPenalty.AllowUserToAddRows = false;
        }

        private void SetMemberTransaction(TransactionModel transaction)
        {
            this.transaction = transaction;
        }

        // create data for table
        private void SetViewForTable(List<TransactionListItemTableModel> list)
        {
            this.tables = list; // set for tables
            dgvListReturnProduct.DataSource = (TransactionListItemTableBUS.GetInstance().GetDataSet(list)).Tables[0];
            dgvListReturnProduct.Columns[0].Width = 50;
            dgvListReturnProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListReturnProduct.Columns[2].Width = 50;
            dgvListReturnProduct.ReadOnly = true;
            SetDefaultForTable();
        }

        // create new table
        private List<TransactionListItemTableModel> CreateNewTable(DataGridViewRow ignoreRow, bool isDeleted)
        {
            if (ignoreRow == null) return new List<TransactionListItemTableModel>();
            if (dgvListReturnProduct == null)
            {
                NotificationServices.GetInstance().ShowError("Not found data table!", "Not Found");
                return new List<TransactionListItemTableModel>();
            }

            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            DataGridViewRowCollection rows = dgvListReturnProduct.Rows;
            foreach (DataGridViewRow row in rows)

            {
                if (row.IsNewRow) continue;
                if (isDeleted && ignoreRow != null && row.Equals(ignoreRow)) continue;
                string productName = row.Cells["Product Name"].Value.ToString();
                int amount = ValidateParseToOtherType.GetInstance().CanParseToInt(row.Cells["Amount"].Value.ToString());
                list.Add(new TransactionListItemTableModel(productName, amount));
            }
            return list;
        }

        // get product of this transaction
        private List<TransactionItemModel> GetListTransactionDetail(string transactionID)
        {
            TransactionItemBUS items = new TransactionItemBUS();
            return items.GetByTransactionID(transactionID);
        }

        private List<TransactionListItemTableModel> GetListItems(List<TransactionItemModel> details)
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            BookBUS books = new BookBUS();
            DeviceBUS devices = new DeviceBUS();
            foreach (TransactionItemModel item in details)
            {
                if (item.BookID == null)
                {
                    DeviceModel device = devices.GetDeviceByID(item.DeviceID.Value);
                    if (device == null) continue;
                    list.Add(new TransactionListItemTableModel(device.DeviceName, item.Amount));
                }
                else if (item.DeviceID == null)
                {
                    BookModel book = books.GetBookByID(item.BookID.Value);
                    if (book == null) continue;
                    list.Add(new TransactionListItemTableModel(book.BookTitle, item.Amount));
                }
            }
            return list;
        }

        private void UpdateTransaction(TransactionType transactionType, TransactionStatus status)
        {
            transaction.TransactionType = TransactionType.Return;
            transaction.Status = TransactionStatus.Completed;
            TransactionBUS transactions = new TransactionBUS();
            //transactions.Update(transaction);
            NotificationServices.GetInstance().ShowSuccess("Upadate Done!", "Done");
        }

        // NOTE: FOR VALIDATION
        private bool ValidateMemberID(string memberID)
        {
            if (string.IsNullOrWhiteSpace(memberID))
            {
                NotificationServices.GetInstance().ShowError("Member ID cannot be empty!", "Missing Member ID");
                return false;
            }
            return true;
        }

        private bool ValidateTransactionID(string transactionID)
        {
            if (string.IsNullOrWhiteSpace(transactionID))
            {
                NotificationServices.GetInstance().ShowError("Transaction ID cannot be empty!", "Missing Transaction ID");
                return false;
            }
            return true;
        }

        private bool ValidateReturnDate(DateTime returnDate)
        {
            if (returnDate == null || returnDate == default(DateTime))
            {
                NotificationServices.GetInstance().ShowError("Return date must be selected!", "Missing Return Date");
                return false;
            }
            return true;
        }

        // NOTE: FOR EVENTS
        private void btnExitFormReturn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnResetFromReturn_Click(object sender, EventArgs e)
        {
            txtGetMemberIDReturn.Text = "";
            txtGetTransactionID.Text = "";
            dtpRealReturnDate.Value = DateTime.Now;
            dgvListReturnProduct.DataSource = null;
            dgvListPenalty.DataSource = null;
        }

        private void btnSubmitFormReturn_Click(object sender, EventArgs e)
        {
            // get values for transaction and transaction items
            string memberID = txtGetMemberIDReturn.Text;
            DateTime dueDate = dtpRealReturnDate.Value;
            DialogResult result = NotificationServices.GetInstance().ShowConfirm("Are you sure ?", "Confirm");
            if (result == DialogResult.OK)
            {
                //UpdateTransaction(TransactionType.Return, TransactionStatus.Completed);
            }

        }

        // get value from 3 fields, check valid, get transaction, get detail and show it on datagridview
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            string memberID = txtGetMemberIDReturn.Text;
            string transactionID = txtGetTransactionID.Text;
            DateTime returnDate = dtpRealReturnDate.Value;

            if (!ValidateMemberID(memberID) || !ValidateTransactionID(transactionID) || !ValidateReturnDate(returnDate))
                return;
            TransactionModel transactionOfThisMember = new TransactionBUS().GetByTwoID(transactionID, memberID);

            // check list details
            if (transactionOfThisMember == null)
            {
                NotificationServices.GetInstance().ShowError("Not have any transaction!", "Not Have Any Transaction");
                return;
            }
            SetMemberTransaction(transactionOfThisMember); // OPTIMIZE: set for local transaction of this form
            List<TransactionItemModel> listDetails = GetListTransactionDetail(transactionOfThisMember.TransactionID.ToString());
            SetViewForTable(GetListItems(listDetails));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvListReturnProduct.CurrentRow == null)
            {
                NotificationServices.GetInstance().ShowError("Please select Product for remove!", "Error Select");
                return;
            }
            SetViewForTable(CreateNewTable(dgvListReturnProduct.CurrentRow, true));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvListReturnProduct == null || dgvListReturnProduct.Columns["Amount"] == null)
            {
                NotificationServices.GetInstance().ShowError("Not found data!", "Not found");
                return;
            }

            dgvListReturnProduct.ReadOnly = false;
            dgvListReturnProduct.Columns["Product Name"].ReadOnly = true;
            dgvListReturnProduct.Columns["ID"].ReadOnly = true;
            MessageBox.Show("You can now edit the 'Amount' column.");
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            dgvListReturnProduct.EndEdit();
            dgvListReturnProduct.Columns["Amount"].ReadOnly = true;
            SetViewForTable(CreateNewTable(null, false));
            MessageBox.Show("Changes saved successfully.");
        }

        private void dgvListReturnProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvListReturnProduct.CurrentCell.ColumnIndex == dgvListReturnProduct.Columns["Amount"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= OnlyNumber_KeyPress;
                    tb.KeyPress += OnlyNumber_KeyPress;
                }
            }
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs keypress)
        {
            if (!char.IsControl(keypress.KeyChar) && !char.IsDigit(keypress.KeyChar))
                keypress.Handled = true;
        }
    }
}
