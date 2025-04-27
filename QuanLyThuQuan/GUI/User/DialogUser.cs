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
    public partial class DialogUser: Form
    {

        MemberBUS bus = new MemberBUS();
        private FormUser parentForm; // dùng để gọi lại loadTable
        public DialogUser(FormUser parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.");
                return false;
            }
            else if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Họ tên phải có ít nhất 6 ký tự.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || !IsValidEmail(textBox3.Text))
            {
                MessageBox.Show("Email không hợp lệ.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text) || !textBox4.Text.All(char.IsDigit) || textBox4.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                return false;
            }
            else if (textBox5.Text.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text) || textBox6.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;

            MemberBUS bus = new MemberBUS();

            UserType userType = radioButton1.Checked ? UserType.User :
                                radioButton2.Checked ? UserType.Librarian :
                                UserType.Admin;

            MemberModel member = new MemberModel
            {
                MemberID = int.Parse(textBox1.Text),
                FullName = textBox2.Text,
                Email = textBox3.Text,
                PhoneNumber = textBox4.Text,
                Username = textBox5.Text,
                Password = textBox6.Text,
                RegistrationDate = dateTimePicker1.Value,
                UserType = userType,
            };

            if (button1.Text == "Thêm thành viên")
            {
                bus.AddMember(member);
                MessageBox.Show("Đã thêm thành viên!");
            }
            else if (button1.Text == "Sửa thành viên")
            {
                bus.UpdateMember(member);
                MessageBox.Show("Đã cập nhật thông tin thành viên!");
            }

            parentForm.loadTable();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
