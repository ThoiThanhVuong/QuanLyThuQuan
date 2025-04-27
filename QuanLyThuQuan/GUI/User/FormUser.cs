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

namespace QuanLyThuQuan.GUI.User
{
    public partial class FormUser: Form
    {
        MemberBUS bus = new MemberBUS();
        private FormMain mainForm;
        MemberModel memberModel = new MemberModel();

        public FormUser()
        {
            InitializeComponent();
            loadTable();
        }

        public void loadTable()
        {
            MemberBUS memberBus = new MemberBUS();
            List<MemberModel> members = memberBus.GetActiveMembers();

            if (members == null || members.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu thành viên.");
                return;
            }

            dataGridView1.Rows.Clear();

            foreach (MemberModel member in members)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells["MemberID"].Value = member.MemberID;
                row.Cells["FullName"].Value = member.FullName;
                row.Cells["Email"].Value = member.Email;
                row.Cells["PhoneNumber"].Value = member.PhoneNumber;
                row.Cells["Username"].Value = member.Username;
                row.Cells["Password"].Value = member.Password;
                row.Cells["RegistrationDate"].Value = member.RegistrationDate.ToString("yyyy-MM-dd");
                row.Cells["UserType"].Value = member.UserType.ToString();
            }
            button3.Enabled = false; 
            button4.Enabled = false;
            memberModel = null; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogUser dialogUser = new DialogUser(this);
            dialogUser.StartPosition = FormStartPosition.CenterScreen; // Thêm dòng này
            dialogUser.textBox1.Text = bus.GetMaxMemberID().ToString();
            dialogUser.button1.Text = "Thêm thành viên"; 

            dialogUser.ShowDialog();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (memberModel == null)
            {
                MessageBox.Show("Vui lòng chọn thành viên để sửa.");
                return;
            }

            DialogUser dialogUser = new DialogUser(this);
            dialogUser.StartPosition = FormStartPosition.CenterScreen; // Thêm dòng này
            dialogUser.textBox1.Text = memberModel.MemberID.ToString();
            dialogUser.textBox2.Text = memberModel.FullName;
            dialogUser.textBox3.Text = memberModel.Email;
            dialogUser.textBox4.Text = memberModel.PhoneNumber;
            dialogUser.textBox5.Text = memberModel.Username;
            dialogUser.textBox6.Text = memberModel.Password;
            dialogUser.dateTimePicker1.Value = memberModel.RegistrationDate;
            dialogUser.radioButton1.Checked = memberModel.UserType == Model.UserType.User;
            dialogUser.radioButton2.Checked = memberModel.UserType == Model.UserType.Librarian;
            dialogUser.radioButton3.Checked = memberModel.UserType == Model.UserType.Admin;
            dialogUser.button1.Text = "Sửa thành viên";     

            dialogUser.ShowDialog();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = true;

            if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                memberModel = new MemberModel(); // Nếu chưa khởi tạo
                memberModel.MemberID = int.Parse(row.Cells["MemberID"].Value?.ToString());

                memberModel.FullName = row.Cells["FullName"].Value.ToString();
                memberModel.Email = row.Cells["Email"].Value.ToString();
                memberModel.PhoneNumber = row.Cells["PhoneNumber"].Value.ToString();
                memberModel.Username = row.Cells["Username"].Value.ToString();
                memberModel.Password = row.Cells["Password"].Value.ToString();
                memberModel.RegistrationDate = DateTime.Parse(row.Cells["RegistrationDate"].Value.ToString());
                memberModel.UserType = (UserType)Enum.Parse(typeof(UserType), row.Cells["UserType"].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bus.DeleteMember(memberModel.MemberID);
            loadTable();
            MessageBox.Show("Xóa thành công.");
        }
    }
}
