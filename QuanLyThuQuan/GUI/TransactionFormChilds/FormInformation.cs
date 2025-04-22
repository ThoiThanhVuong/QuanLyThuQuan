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
            SetDefaultForForm();
            ShowTransactionDetail(id);
            ShowTransactionItemDetail(id);
            ShowMemberInfo(id);
            ShowViolationInfo(id);
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }

        // NOTE: FOR OTHER LOGIC

        private void SetDefaultForForm()
        {
            dgvDataViolationHandle.AllowUserToAddRows = false;
            dgvDataItemList.AllowUserToAddRows = false;
            dgvDataViolationHandle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void ShowMemberInfo(string id)
        {
            TransactionModel transaction = GetTransaction(id);
            if (transaction == null)
                return;
            RenderMemberInfoDetail(GetMemberForForm(transaction.MemberID.ToString()));
        }

        private void ShowViolationInfo(string id)
        {
            TransactionModel transaction = GetTransaction(id);
            if (transaction == null)
                return;
            RenderMemberViolation(GetViolationForForm(transaction.MemberID.ToString()));
        }

        // get transaction
        private TransactionModel GetTransaction(string id)
        {
            return new TransactionBUS().GetByID(id, "TransactionID")[0];
        }

        // get detail item of this transaction 
        private List<TransactionItemModel> GetTransacionItemDetail(string id)
        {
            return new TransactionItemBUS().GetByTransactionID(id);
        }

        // get book by id on transaction item
        private List<(int, int)> GetBook(TransactionItemModel transactionItem)
        {
            int bookID = ValidateParseToOtherType.GetInstance().CanParseToInt(transactionItem.BookID.ToString().Trim());
            if (bookID.Equals(-1))
                return null;
            //return new BookBUS().GetBookByID(bookID);
            return new List<(int, int)> { (bookID, transactionItem.Amount) };
        }

        // get device by id on transaction item
        private List<(int, int)> GetDevice(TransactionItemModel transactionItem)
        {
            int deviceID = ValidateParseToOtherType.GetInstance().CanParseToInt(transactionItem.DeviceID.ToString().Trim());
            if (deviceID.Equals(-1))
                return null;
            //return new DeviceBUS().GetDeviceByID(deviceID);
            return new List<(int, int)> { (deviceID, transactionItem.Amount) };
        }

        // render it to view
        private void RenderTransactionDetail(TransactionModel transaction)
        {
            if (transaction == null) return;
            lbValueTransactionID.Text = transaction.TransactionID.ToString();
            lbValueMemberID.Text = transaction.MemberID.ToString();
            lbValueTransactionType.Text = transaction.TransactionType.ToString();
            lbValueTransactionDate.Text = transaction.TransactionDate.ToString();
            lbValueDueDate.Text = transaction.DueDate.ToString();
            lbValueReturnDate.Text = transaction.ReturnDate.ToString();
            lbValueTransactionStatus.Text = transaction.Status.ToString();
        }

        private void RenderMemberInfoDetail(MemberModel member)
        {
            if (member == null) return;
            lbValueMemberFullName.Text = member.FullName;
            lbValueMemberUserName.Text = member.Username;
            lbValueUserType.Text = member.UserType.ToString();
            lbValueUserStatus.Text = member.MemberStatus.ToString();
            lbValueUserEmail.Text = member.Email;
            lbValuePhoneNumber.Text = member.PhoneNumber;
        }

        private void RenderMemberViolation(List<ViolationModel> violations)
        {
            if (violations == null || violations.Count == 0)
            {
                lbViolationStatus.Text = "NO";
                return;
            }
            lbValueViolationStatus.Text = "YES";
            RenderViewForViolations(violations);
        }

        // render table product
        private void RenderTableProduct(List<BookModel> books, List<DeviceModel> devices, List<int> bookAmount, List<int> deviceAmount)
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
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

        private void RenderViewForViolations(List<ViolationModel> violations)
        {
            if (violations == null || violations.Count == 0)
            {
                dgvDataViolationHandle.Rows.Clear();
                dgvDataViolationHandle.Columns.Clear();
            }

            List<ViolationsListItemTable> list = new List<ViolationsListItemTable>();
            list.AddRange(GetListViolationsForTable(violations));
            ViolationsListItemTable temp = new ViolationsListItemTable();
            Console.WriteLine(list.Count);
            Console.WriteLine(temp.GetDataSet(list).Tables[0]);
            dgvDataViolationHandle.DataSource = (temp.GetDataSet(list)).Tables[0];
            dgvDataViolationHandle.Columns[0].Width = 50;
            dgvDataViolationHandle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataViolationHandle.Columns[2].Width = 50;
            dgvDataViolationHandle.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataViolationHandle.ReadOnly = true;
        }

        private List<TransactionListItemTableModel> GetListForBook(List<BookModel> books, List<int> bookAmount)
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            int length = books.Count;
            for (int i = 0; i < length; i++)
                list.Add(new TransactionListItemTableModel(books[i].BookTitle, bookAmount[i]));
            return list;
        }

        private List<TransactionListItemTableModel> GetListForDevice(List<DeviceModel> devices, List<int> deviceAmount)
        {
            List<TransactionListItemTableModel> list = new List<TransactionListItemTableModel>();
            int length = devices.Count;
            for (int i = 0; i < length; i++)
                list.Add(new TransactionListItemTableModel(devices[i].DeviceName, deviceAmount[i]));
            return list;
        }

        private List<ViolationsListItemTable> GetListViolationsForTable(List<ViolationModel> violations)
        {
            List<ViolationsListItemTable> list = new List<ViolationsListItemTable>();
            int length = violations.Count;
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                list.Add(new ViolationsListItemTable(GetRulesForForm(violations[i].RuleID.ToString()).RuleTitle, violations[i].FineAmount, violations[i].ViolationDate, violations[i].IsCompensationRequired.ToString()));
            }
            return list;
        }

        private MemberModel GetMemberForForm(string memberID)
        {
            MemberBUS temp = new MemberBUS();
            List<MemberModel> list = temp.GetAllMembers();
            foreach (MemberModel member in list)
                if (member.MemberID.Equals(Int16.Parse(memberID)))
                    return member;
            return null;
        }

        private List<ViolationModel> GetViolationForForm(string memberID)
        {
            ViolationBUS temp = new ViolationBUS();
            List<ViolationModel> listFilter = new List<ViolationModel>();
            List<ViolationModel> list = temp.GetViolations();
            foreach (ViolationModel violation in list)
                if (violation.MemberID.Equals(Int16.Parse(memberID)))
                    listFilter.Add(violation);
            return listFilter;
        }

        private RuleModel GetRulesForForm(string ruleID)
        {
            if (ruleID == null)
                return null;
            RuleBUS ruleBus = new RuleBUS();
            List<RuleModel> list = ruleBus.GetActiveRules();
            foreach (RuleModel rule in list)
                if (rule.RuleID.Equals(Int16.Parse(ruleID)))
                    return rule;
            return null;
        }

        private void SetViewForTable(List<TransactionListItemTableModel> list)
        {
            dgvDataItemList.DataSource = (TransactionListItemTableBUS.GetInstance().GetDataSet(list)).Tables[0];
            dgvDataItemList.Columns[0].Width = 50;
            dgvDataItemList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDataItemList.Columns[2].Width = 50;
            dgvDataItemList.ReadOnly = true;
        }
        // NOTE: FOR VALIDATION

        // NOTE: FOR EVENT
        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
