using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.SubStatisticForms
{
    public partial class FormBookStatistic : Form
    {
        private BookBUS bookBUS = new BookBUS();
        private TransactionBUS transactionBUS = new TransactionBUS();
        private MemberBUS memberBUS = new MemberBUS();

        public FormBookStatistic()
        {
            InitializeComponent();
            FormBookStatistic_Load();
        }

        private void FormBookStatistic_Load()
        {
            // Set default dates (e.g., start of month to today)
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpBookFrom.Value = startOfMonth;
            dtpBookTo.Value = today;
            // Load initial data (e.g., borrowed count by default)
            LoadBorrowedCountData(DateTime.MinValue, DateTime.MaxValue, null);
        }

        private void btnBookBorrowedCount_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpBookFrom.Value.Date;
            DateTime toDate = dtpBookTo.Value.Date.AddDays(1).AddTicks(-1);
            string bookNameFilter = txtBookName.Text.Trim();
            LoadBorrowedCountData(fromDate, toDate, bookNameFilter);
        }

        private void btnBookCurrentlyBorrowed_Click(object sender, EventArgs e)
        {
            LoadCurrentlyBorrowedData();
        }

        private void LoadBorrowedCountData(DateTime fromDate, DateTime toDate, string bookNameFilter)
        {

            try
            {
                dgvBookStats.DataSource = null; // Clear previous data
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>();
                var allBooks = bookBUS.GetAllBooks() ?? new List<BookModel>();

                if (allTransactions.Count == 0 || allBooks.Count == 0)
                {
                    // Optionally show a message if base data is empty
                    // MessageBox.Show("Không có dữ liệu giao dịch hoặc sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


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

                if (stats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thống kê lượt mượn sách phù hợp với bộ lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


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

        private void LoadCurrentlyBorrowedData()
        {
            string bookNameFilter = txtBookName.Text.Trim();

            try
            {
                dgvBookStats.DataSource = null; // Clear previous data
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>();
                var allBooks = bookBUS.GetAllBooks() ?? new List<BookModel>();
                var allMembers = memberBUS.GetAllMembers() ?? new List<MemberModel>();

                if (allTransactions.Count == 0 || allBooks.Count == 0 || allMembers.Count == 0)
                {
                    // Optionally show a message if base data is empty
                    // MessageBox.Show("Không có dữ liệu giao dịch, sách hoặc thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                if (stats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu sách đang được mượn phù hợp với bộ lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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
