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
    public partial class FormDeviceStatistic : Form
    {
        private DeviceBUS deviceBUS = new DeviceBUS();
        private TransactionBUS transactionBUS = new TransactionBUS();
        private MemberBUS memberBUS = new MemberBUS();

        public FormDeviceStatistic()
        {
            InitializeComponent();
            FormDeviceStatistic_Load();
        }

        private void FormDeviceStatistic_Load()
        {
            // Set default dates (e.g., start of month to today)
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpDeviceFrom.Value = startOfMonth;
            dtpDeviceTo.Value = today;
            // Load initial data (e.g., borrowed count by default)
            LoadBorrowedCountData(DateTime.MinValue, DateTime.MaxValue, null);
        }

        private void btnDeviceBorrowedCount_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpDeviceFrom.Value.Date;
            DateTime toDate = dtpDeviceTo.Value.Date.AddDays(1).AddTicks(-1);
            string deviceNameFilter = txtDeviceName.Text.Trim();
            LoadBorrowedCountData(fromDate, toDate, deviceNameFilter);
        }

        private void btnDeviceCurrentlyBorrowed_Click(object sender, EventArgs e)
        {
            LoadCurrentlyBorrowedData();
        }

        private void LoadBorrowedCountData(DateTime fromDate, DateTime toDate, string deviceNameFilter)
        {
            try
            {
                dgvDeviceStats.DataSource = null; // Clear previous data
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allDevices = deviceBUS.GetAllDevices() ?? new List<DeviceModel>(); // Add null check

                if (allTransactions.Count == 0 || allDevices.Count == 0)
                {
                    // Optionally show a message if base data is empty
                    // MessageBox.Show("Không có dữ liệu giao dịch hoặc thiết bị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                if (stats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thống kê lượt mượn thiết bị phù hợp với bộ lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

        private void LoadCurrentlyBorrowedData()
        {
            string deviceNameFilter = txtDeviceName.Text.Trim();

            try
            {
                dgvDeviceStats.DataSource = null; // Clear previous data
                var allTransactions = transactionBUS.GetAllTransactionsWithItems() ?? new List<TransactionModel>(); // Updated method call
                var allDevices = deviceBUS.GetAllDevices() ?? new List<DeviceModel>(); // Add null check
                var allMembers = memberBUS.GetAllMembers() ?? new List<MemberModel>(); // Add null check

                if (allTransactions.Count == 0 || allDevices.Count == 0 || allMembers.Count == 0)
                {
                    // Optionally show a message if base data is empty
                    // MessageBox.Show("Không có dữ liệu giao dịch, thiết bị hoặc thành viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                if (stats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thiết bị đang được mượn phù hợp với bộ lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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
    }
}
