using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormSelectProducts : Form
    {
        private string productType;
        public List<TransactionListItemTableModel> listItems { get; private set; }

        public FormSelectProducts(string type)
        {
            InitializeComponent();
            SetDefaultSetupForForm(type);
        }

        private void FormSelectProducts_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        // NOTE: FOR OTHER LOGICS
        private void SetDefaultSetupForForm(string type)
        {
            productType = type;
            listItems = new List<TransactionListItemTableModel>();
            RenderInitTable(productType);
            dgvListProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListProducts.AllowUserToAddRows = false;
        }

        private void RenderInitTable(string type)
        {
            SetViewForTable(GetListProductByName("", type));
        }

        private List<TransactionListItemTableModel> GetListProductByName(string name, string type)
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            List<DeviceModel> devices = new List<DeviceModel>();
            List<BookModel> books = new List<BookModel>();
            //check type
            if (string.IsNullOrEmpty(type))
                return list;
            else if (type.Equals("Books"))
                books = GetFromBooks(name);
            else if (type.Equals("Devices"))
                devices = GetFromDevices(name);
            else if (type.Equals("All"))
            {
                books = GetFromBooks(name);
                devices = GetFromDevices(name);
            }
            else
                return list;

            //valid list
            if ((devices == null || devices.Count == 0) && (books == null || books.Count == 0))
            {
                Debug.WriteLine(devices);
                Debug.WriteLine(books);
                return list;
            }
            if (devices == null || devices.Count == 0)
            {
                foreach (BookModel book in books)
                    list.Add(new TransactionListItemTableModel(book.BookTitle, book.BookQuantity)); // change here if quantity is wrong
                return list;
            }
            if (books == null || books.Count == 0)
            {
                foreach (DeviceModel device in devices)
                    list.Add(new TransactionListItemTableModel(device.DeviceName, device.DeviceQuantity));
                return list;
            }
            else
            {
                foreach (BookModel book in books)
                    list.Add(new TransactionListItemTableModel(book.BookTitle, book.BookQuantity)); // change here if quantity is wrong
                foreach (DeviceModel device in devices)
                    list.Add(new TransactionListItemTableModel(device.DeviceName, device.DeviceQuantity));
                return list;
            }
        }

        private List<DeviceModel> GetFromDevices(string name)
        {
            DeviceBUS devices = new DeviceBUS();
            //devices.GetAllDevices();
            return devices.SearchDevices(name);
        }

        private List<BookModel> GetFromBooks(string name)
        {
            BookBUS books = new BookBUS();
            //books.GetAllBooks();
            return books.SearchBooks(name);
        }

        private void SetViewForTable(List<TransactionListItemTableModel> list)
        {
            dgvListProducts.DataSource = (TransactionListItemTableBUS.GetInstance().GetDataSet(list)).Tables[0];
            dgvListProducts.Columns[0].Width = 50;
            dgvListProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListProducts.Columns[2].Width = 50;
            dgvListProducts.ReadOnly = true;
        }
        // NOTE: FOR VALIDATION

        // NOTE: FOR EVENT 
        private void btnExitProductSelect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            dgvListProducts.ClearSelection();
        }

        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection list = dgvListProducts.SelectedRows;
            foreach (DataGridViewRow selected in list)
                this.listItems.Add(new TransactionListItemTableModel(selected.Cells["Product Name"]?.Value.ToString(), 1));
            this.listItems.Reverse();
            this.Close();
        }

        private void txtSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetViewForTable(GetListProductByName(txtSearchProduct.Text, productType));
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SetViewForTable(GetListProductByName(txtSearchProduct.Text, productType));
        }
    }
}
