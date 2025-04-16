using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormDashBoard : Form
    {
        private SessionStudyBUS sessionStudyBUS = new SessionStudyBUS();
        public FormDashBoard()
        {
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            List<SessionStudy> sessionStudies = sessionStudyBUS.GetSessionStudies(); // Giả sử GetActiveViolations lấy danh sách vi phạm
            if (sessionStudies == null)
            {
                Console.WriteLine("Không có dữ liệu đăng nhập.");
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (SessionStudy sessionStudy in sessionStudies)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["SessionId"].Value = sessionStudy.SessionId;
                    row.Cells["MemberId"].Value = sessionStudy.MemberId;
                    row.Cells["CheckInTIme"].Value = sessionStudy.CheckInTime;
                }
            }
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idMember = textBox1.Text;
            sessionStudyBUS.CheckInTime(int.Parse(idMember));
            loadTable();
        }

        
    }
}
