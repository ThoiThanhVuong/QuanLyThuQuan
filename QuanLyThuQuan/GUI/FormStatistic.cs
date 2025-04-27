using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace QuanLyThuQuan.GUI
{
    public partial class FormStatistic : Form
    {
        private SessionStudyBUS sessionStudyBUS = new SessionStudyBUS();
        private MemberBUS memberBUS = new MemberBUS();
        private TransactionBUS transactionBUS = new TransactionBUS();
        private DeviceBUS deviceBUS = new DeviceBUS();
        private BookBUS bookBUS = new BookBUS();

        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            // Populate Member Type ComboBox
            cmbMemberType.Items.Add("All"); // Add "All" option
            cmbMemberType.Items.AddRange(Enum.GetNames(typeof(UserType)));
            cmbMemberType.SelectedIndex = 0; // Default to "All"

            // Set default dates (e.g., start of month to today)
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpMemberFrom.Value = startOfMonth;
            dtpMemberTo.Value = today;
            dtpDeviceFrom.Value = startOfMonth;
            dtpDeviceTo.Value = today;
            dtpBookFrom.Value = startOfMonth;
            dtpBookTo.Value = today;
        }

        // --- Member Statistics --- 
        private void btnMemberStatistic_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpMemberFrom.Value.Date; // Get date part only
            DateTime toDate = dtpMemberTo.Value.Date.AddDays(1).AddTicks(-1); // Include the whole end day
            string selectedType = cmbMemberType.SelectedItem?.ToString() ?? "All";

            try
            {
                dgvMemberStats.DataSource = null; // Clear previous data

                // Get data from business layer with null checking
                var allSessions = sessionStudyBUS.GetSessionStudies();
                if (allSessions == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu phiên học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var allMembers = memberBUS.GetAllMembers();
                if (allMembers == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu thành viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filter sessions by date range
                var filteredSessions = allSessions
                    .Where(s => s.CheckInTime >= fromDate && s.CheckInTime <= toDate);

                // Join session with member details - careful with case sensitivity
                var joinedData = from session in filteredSessions
                                 join member in allMembers
                                 on session.MemberId equals member.MemberID
                                 select new { session, member };

                // Apply filter by member type if "All" is not selected
                if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
                {
                    var userTypeFilter = (UserType)Enum.Parse(typeof(UserType), selectedType);
                    joinedData = joinedData.Where(joined => joined.member.UserType == userTypeFilter);
                }

                // Group by date and count entries
                var stats = joinedData
                    .GroupBy(joined => joined.session.CheckInTime.Date)
                    .Select(g => new
                    {
                        Date = g.Key.ToString("yyyy-MM-dd"),
                        MemberCount = g.Count()
                    })
                    .OrderBy(s => s.Date)
                    .ToList();

                if (stats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thống kê phù hợp với bộ lọc đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvMemberStats.DataSource = stats;
                dgvMemberStats.Columns["Date"].HeaderText = "Ngày";
                dgvMemberStats.Columns["MemberCount"].HeaderText = "Số lượng thành viên";
                dgvMemberStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê thành viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Device Statistics --- 
        private void btnDeviceBorrowedCount_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpDeviceFrom.Value.Date;
            DateTime toDate = dtpDeviceTo.Value.Date.AddDays(1).AddTicks(-1);
            string deviceNameFilter = txtDeviceName.Text.Trim();


            try
            {
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allDevices = deviceBUS.GetAllDevices() ?? new List<DeviceModel>(); // Add null check

                var borrowedDevices = allTransactions
                    .Where(t => t.TransactionType == TransactionType.Borrow && t.TransactionDate >= fromDate && t.TransactionDate <= toDate)
                    .SelectMany(t => t.Items?.Where(ti => ti.DeviceID.HasValue) ?? Enumerable.Empty<TransactionItemModel>(),
                               (t, ti) => new { Transaction = t, Item = ti })
                    .Join(allDevices, joined => joined.Item.DeviceID.Value, d => d.DeviceID,
                          (joined, device) => new { joined.Transaction, joined.Item, device });

                // Filter by device name if provided
                if (!string.IsNullOrEmpty(deviceNameFilter))
                {
                    borrowedDevices = borrowedDevices.Where(bd => bd.device.DeviceName.IndexOf(deviceNameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var stats = borrowedDevices
                    .GroupBy(bd => bd.device.DeviceName)
                    .Select(g => new
                    {
                        DeviceName = g.Key,
                        BorrowCount = g.Sum(item => item.Item.Amount) // Sum amounts if multiple borrowed in one transaction
                    })
                    .OrderBy(s => s.DeviceName)
                    .ToList();

                dgvDeviceStats.DataSource = stats;
                dgvDeviceStats.Columns["DeviceName"].HeaderText = "Tên Thiết Bị";
                dgvDeviceStats.Columns["BorrowCount"].HeaderText = "Số Lượt Mượn";
                dgvDeviceStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê lượt mượn thiết bị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeviceCurrentlyBorrowed_Click(object sender, EventArgs e)
        {
            string deviceNameFilter = txtDeviceName.Text.Trim();


            try
            {
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allDevices = deviceBUS.GetAllDevices() ?? new List<DeviceModel>(); // Add null check
                var allMembers = memberBUS.GetAllMembers() ?? new List<MemberModel>(); // Add null check

                var currentlyBorrowed = allTransactions
                    .Where(t => t.TransactionType == TransactionType.Borrow &&
                               (t.Status == TransactionStatus.Active || t.Status == TransactionStatus.Overdue))
                    .SelectMany(t => t.Items?.Where(ti => ti.DeviceID.HasValue) ?? Enumerable.Empty<TransactionItemModel>(),
                               (t, ti) => new { Transaction = t, Item = ti })
                    .Join(allDevices, joined => joined.Item.DeviceID.Value, d => d.DeviceID,
                          (joined, device) => new { joined.Transaction, joined.Item, device })
                    .Join(allMembers, joined => joined.Transaction.MemberID, m => m.MemberID,
                          (joined, member) => new { joined.Transaction, joined.Item, joined.device, member });

                // Filter by device name if provided
                if (!string.IsNullOrEmpty(deviceNameFilter))
                {
                    currentlyBorrowed = currentlyBorrowed.Where(cb => cb.device.DeviceName.IndexOf(deviceNameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var stats = currentlyBorrowed
                    .Select(cb => new
                    {
                        cb.device.DeviceName,
                        MemberName = cb.member.FullName,
                        BorrowDate = cb.Transaction.TransactionDate,
                        DueDate = cb.Transaction.DueDate,
                        Status = cb.Transaction.Status.ToString()
                    })
                    .OrderBy(s => s.DeviceName).ThenBy(s => s.BorrowDate)
                    .ToList();

                dgvDeviceStats.DataSource = stats;
                dgvDeviceStats.Columns["DeviceName"].HeaderText = "Tên Thiết Bị";
                dgvDeviceStats.Columns["MemberName"].HeaderText = "Người Mượn";
                dgvDeviceStats.Columns["BorrowDate"].HeaderText = "Ngày Mượn";
                dgvDeviceStats.Columns["DueDate"].HeaderText = "Hạn Trả";
                dgvDeviceStats.Columns["Status"].HeaderText = "Trạng Thái";
                dgvDeviceStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thiết bị đang được mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Book Statistics --- 
        private void btnBookBorrowedCount_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpBookFrom.Value.Date;
            DateTime toDate = dtpBookTo.Value.Date.AddDays(1).AddTicks(-1);
            string bookNameFilter = txtBookName.Text.Trim();


            try
            {
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allBooks = bookBUS.GetAllBooks() ?? new List<BookModel>(); // Add null check

                var borrowedBooks = allTransactions
                    .Where(t => t.TransactionType == TransactionType.Borrow && t.TransactionDate >= fromDate && t.TransactionDate <= toDate)
                    .SelectMany(t => t.Items?.Where(ti => ti.BookID.HasValue) ?? Enumerable.Empty<TransactionItemModel>(),
                               (t, ti) => new { Transaction = t, Item = ti })
                    .Join(allBooks, joined => joined.Item.BookID.Value, b => b.BookID,
                          (joined, book) => new { joined.Transaction, joined.Item, book });

                // Filter by book name if provided
                if (!string.IsNullOrEmpty(bookNameFilter))
                {
                    borrowedBooks = borrowedBooks.Where(bb => bb.book.BookTitle.IndexOf(bookNameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var stats = borrowedBooks
                    .GroupBy(bb => bb.book.BookTitle)
                    .Select(g => new
                    {
                        BookTitle = g.Key,
                        BorrowCount = g.Sum(item => item.Item.Amount)
                    })
                    .OrderBy(s => s.BookTitle)
                    .ToList();

                dgvBookStats.DataSource = stats;
                dgvBookStats.Columns["BookTitle"].HeaderText = "Tên Sách";
                dgvBookStats.Columns["BorrowCount"].HeaderText = "Số Lượt Mượn";
                dgvBookStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê lượt mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookCurrentlyBorrowed_Click(object sender, EventArgs e)
        {
            string bookNameFilter = txtBookName.Text.Trim();


            try
            {
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allBooks = bookBUS.GetAllBooks() ?? new List<BookModel>(); // Add null check
                var allMembers = memberBUS.GetAllMembers() ?? new List<MemberModel>(); // Add null check

                var currentlyBorrowed = allTransactions
                    .Where(t => t.TransactionType == TransactionType.Borrow &&
                               (t.Status == TransactionStatus.Active || t.Status == TransactionStatus.Overdue))
                    .SelectMany(t => t.Items?.Where(ti => ti.BookID.HasValue) ?? Enumerable.Empty<TransactionItemModel>(),
                               (t, ti) => new { Transaction = t, Item = ti })
                    .Join(allBooks, joined => joined.Item.BookID.Value, b => b.BookID,
                          (joined, book) => new { joined.Transaction, joined.Item, book })
                    .Join(allMembers, joined => joined.Transaction.MemberID, m => m.MemberID,
                          (joined, member) => new { joined.Transaction, joined.Item, joined.book, member });

                // Filter by book name if provided
                if (!string.IsNullOrEmpty(bookNameFilter))
                {
                    currentlyBorrowed = currentlyBorrowed.Where(cb => cb.book.BookTitle.IndexOf(bookNameFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var stats = currentlyBorrowed
                    .Select(cb => new
                    {
                        BookTitle = cb.book.BookTitle,
                        MemberName = cb.member.FullName,
                        BorrowDate = cb.Transaction.TransactionDate,
                        DueDate = cb.Transaction.DueDate,
                        Status = cb.Transaction.Status.ToString()
                    })
                    .OrderBy(s => s.BookTitle).ThenBy(s => s.BorrowDate)
                    .ToList();

                dgvBookStats.DataSource = stats;
                dgvBookStats.Columns["BookTitle"].HeaderText = "Tên Sách";
                dgvBookStats.Columns["MemberName"].HeaderText = "Người Mượn";
                dgvBookStats.Columns["BorrowDate"].HeaderText = "Ngày Mượn";
                dgvBookStats.Columns["DueDate"].HeaderText = "Hạn Trả";
                dgvBookStats.Columns["Status"].HeaderText = "Trạng Thái";
                dgvBookStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sách đang được mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
