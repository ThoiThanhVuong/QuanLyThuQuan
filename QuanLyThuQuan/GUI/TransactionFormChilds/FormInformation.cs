using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        public FormInformation(string id)
        {
            InitializeComponent();
            ShowTransactionDetail(id);
            ShowTransactionItemDetail(id);

        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // get id and show detail of this transaction id
        private void ShowTransactionDetail(string id)
        {
            TransactionModel transaction = GetTransaction(id);
            if (transaction == null)
                return;
            RenderTransactionDetail(transaction);
        }

        // get id and show item detail of this transaction id
        private void ShowTransactionItemDetail(string id)
        {
            List<TransactionItemModel> transactionItems = GetTransacionItemDetail(id);
            if ((transactionItems == null) || transactionItems.Count <= 0)
                return;

            List<BookModel> books = new List<BookModel>();
            List<DeviceModel> devices = new List<DeviceModel>();
            List<int> bookAmount = new List<int>();
            List<int> deviceAmount = new List<int>();
            DeviceBUS deviceBus = new DeviceBUS();
            BookBUS bookBus = new BookBUS();
            // loop and Add product to list
            foreach (TransactionItemModel transactionItem in transactionItems)
            {
                List<(int id, int amount)> book = GetBook(transactionItem);
                List<(int id, int amount)> device = GetDevice(transactionItem);
                //BookModel book = GetBook(transactionItem);
                //DeviceModel device = GetDevice(transactionItem);
                if (book == null && device == null)
                {
                    Debug.Print("Error product id!" + "     FormInformation Line 61");
                    return;
                }
                else if (book == null || book.Count == 0)
                {
                    devices.Add(deviceBus.GetDeviceByID(device[0].id));
                    deviceAmount.Add(device[0].amount);
                }
                else if (device == null || device.Count == 0)
                {
                    books.Add(bookBus.GetBookByID(book[0].id));
                    bookAmount.Add(book[0].amount);
                }
            }
            // call render

            RenderTableProduct(books, devices, bookAmount, deviceAmount);
        }

        // get transaction
        private TransactionModel GetTransaction(string id)
        {
            return new TransactionBUS().GetByID(id, "TransactionID");
        }

        // get detail item of this transaction 
        private List<TransactionItemModel> GetTransacionItemDetail(string id)
        {
            return new TransactionItemBUS().getByTransactionID(id);
        }

        // get book by id on transaction item
        private List<(int, int)> GetBook(TransactionItemModel transactionItem)
        {
            int bookID = ValidateParseToOtherType.GetInstance().CanParseToInt(transactionItem.BookID.ToString());
            if (bookID.Equals(-1))
                return null;
            //return new BookBUS().GetBookByID(bookID);
            return new List<(int, int)> { (bookID, transactionItem.Amount) };
        }

        // get device by id on transaction item
        private List<(int, int)> GetDevice(TransactionItemModel transactionItem)
        {
            int deviceID = ValidateParseToOtherType.GetInstance().CanParseToInt(transactionItem.DeviceID.ToString());
            if (deviceID.Equals(-1))
                return null;
            //return new DeviceBUS().GetDeviceByID(deviceID);
            return new List<(int, int)> { (deviceID, transactionItem.Amount) };
        }

        // render it to view
        private void RenderTransactionDetail(TransactionModel transaction)
        {
            lbValueTransactionID.Text = transaction.TransactionID.ToString();
            lbValueMemberID.Text = transaction.MemberID.ToString();
            lbValueTransactionType.Text = transaction.TransactionType.ToString();
            lbValueTransactionDate.Text = transaction.TransactionDate.ToString();
            lbValueDueDate.Text = transaction.DueDate.ToString();
            lbValueReturnDate.Text = transaction.ReturnDate.ToString();
            lbValueTransactionStatus.Text = transaction.Status.ToString();
        }

        // render table product
        private void RenderTableProduct(List<BookModel> books, List<DeviceModel> devices, List<int> bookAmount, List<int> deviceAmount)
        {
            List<TransactionListItemTable> list = new List<TransactionListItemTable>();
            if (books == null && devices == null && bookAmount == null && deviceAmount == null)
            {
                Debug.WriteLine("books and devices is undefined!" + "   FormInformation Line 120");
                return;
            }
            else if (books == null || books.Count == 0)
            {
                Debug.WriteLine(devices.Count);
                list.AddRange(GetListForDevice(devices, deviceAmount));
            }
            else if (devices == null || devices.Count == 0)
            {
                Debug.WriteLine(books.Count);
                list.AddRange(GetListForBook(books, bookAmount));
            }
            else
            {
                Debug.WriteLine(devices.Count);
                Debug.WriteLine(books.Count);
                list.AddRange(GetListForDevice(devices, deviceAmount));
                list.AddRange(GetListForBook(books, bookAmount));
            }
            SetViewForTable(list);
        }

        private List<TransactionListItemTable> GetListForBook(List<BookModel> books, List<int> bookAmount)
        {
            List<TransactionListItemTable> list = new List<TransactionListItemTable>();
            int length = books.Count;
            for (int i = 0; i < length; i++)
                list.Add(new TransactionListItemTable(books[i].BookTitle, bookAmount[i]));
            return list;
        }

        private List<TransactionListItemTable> GetListForDevice(List<DeviceModel> devices, List<int> deviceAmount)
        {
            List<TransactionListItemTable> list = new List<TransactionListItemTable>();
            int length = devices.Count;
            for (int i = 0; i < length; i++)
                list.Add(new TransactionListItemTable(devices[i].DeviceName, deviceAmount[i]));
            return list;
        }

        private void SetViewForTable(List<TransactionListItemTable> list)
        {
            TransactionListItemTable temp = new TransactionListItemTable();
            dgvDataItemList.DataSource = (temp.GetDataSet(list)).Tables[0];
            dgvDataItemList.Columns[0].Width = 50;
            dgvDataItemList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataItemList.Columns[2].Width = 50;
            dgvDataItemList.ReadOnly = true;
        }
    }
}
