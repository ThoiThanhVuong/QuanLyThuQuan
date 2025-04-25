using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void FormStatistic_Load(object sender, System.EventArgs e)
        {
            LoadStatistics();
        }

        public void LoadStatistics()
        {
            BookBUS bookBus = new BookBUS();
            DeviceBUS deviceBus = new DeviceBUS();

            int totalBooks = bookBus.GetTotalBookQuantity();
            int totalDevices = deviceBus.GetTotalDeviceQuantity();

            txtBookCnt.Text = totalBooks.ToString();
            txtDeviceCnt.Text = totalDevices.ToString();

            LoadLoginStatistics();

        }

        public void LoadLoginStatistics()
        {
            LoginHistoryBUS loginHistoryBus = new LoginHistoryBUS();
            List<LoginCountModel> loginCounts = loginHistoryBus.GetAllLoginCounts();
            dataGridView1.Rows.Clear();
            foreach (LoginCountModel loginCount in loginCounts)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = loginCount.MemberID;
                row.Cells[1].Value = loginCount.MemberName;
                row.Cells[2].Value = loginCount.LoginCount;
                dataGridView1.Rows.Add(row);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
