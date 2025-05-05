using QuanLyThuQuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.User
{
    public partial class DeleteCondition: Form
    {
        private MemberBUS memberBUS = new MemberBUS();
        public DeleteCondition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            string userType = radioButton1.Checked ? "User" :
                              radioButton2.Checked ? "Librarian" :
                              radioButton3.Checked ? "Admin" : "";

            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Vui lòng nhập UserType.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int deleted = memberBUS.DeleteMembersByDateRangeAndType(startDate, endDate, userType);

            MessageBox.Show($"Đã xóa {deleted} thành viên có UserType là '{userType}' trong khoảng thời gian được chọn.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

