using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;

namespace QuanLyThuQuan.GUI.SubStatisticForms
{
    public partial class FormMemberStatistic : Form
    {
        private SessionStudyBUS sessionStudyBUS;
        private MemberBUS memberBUS;

        public FormMemberStatistic()
        {
            InitializeComponent();
            initValue();
            btnMemberStatistic_Click(this, EventArgs.Empty);
        }

        private void initValue()
        {
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            dtpMemberFrom.Value = startOfMonth;
            dtpMemberTo.Value = today;
            sessionStudyBUS = new SessionStudyBUS();
            memberBUS = new MemberBUS();
            cmbMemberType.Items.Add("All"); // Add "All" option
            cmbMemberType.Items.AddRange(Enum.GetNames(typeof(UserType)));
            cmbMemberType.SelectedIndex = 0; // Default to "All"
        }

        private void btnMemberStatistic_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpMemberFrom.Value.Date; // Get date part only
            DateTime toDate = dtpMemberTo.Value.Date.AddDays(1).AddTicks(-1); // Include the whole end day
            string selectedType = cmbMemberType.SelectedItem?.ToString() ?? "All";

            try
            {
                dgvMemberStats.DataSource = null; // Clear previous data

                // Get data from business layer with null checking
                var allSessions = sessionStudyBUS.GetAllSessionStudies();
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
                var joinedData = filteredSessions.Join(
                    allMembers,
                    session => session.MemberId,
                    member => member.MemberID,
                    (session, member) => new { session, member }
                );

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
    }
}
