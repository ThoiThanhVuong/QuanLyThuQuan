using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        // NOTE: for other logics
        private void OpenState(string formName, MemberModel member)
        {
            SessionManagerService.GetInstance.SetLoggedMember(member);
            if (formName.ToLower().Equals("main"))
            {
                FormMain main = new FormMain();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
        }

        // NOTE: for validates
        private MemberModel GetMemberByAccountLogin(string userName, string password)
        {
            MemberBUS memberBus = new MemberBUS();
            List<MemberModel> members = memberBus.GetAllMembers();
            foreach (MemberModel member in members)
                if (member.Username.Equals(userName) && member.Password.Equals(password))
                    return member;
            return null;
        }

        // NOTE: for events
        private void ptbExitForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            MemberModel member = GetMemberByAccountLogin(tbxUserName.Text, tbxPassword.Text);
            if (member == null)
            {
                NotificationServices.GetInstance().ShowError("Wrong username or password", "Wrong Account!");
                return;
            }

            // check member's Role
            if (member.UserType.Equals(UserType.User))
            {
                NotificationServices.GetInstance().ShowError("Not have permission", "Error Permission!");
                return;
            }
            else if (!member.UserType.Equals(UserType.Admin) && !member.UserType.Equals(UserType.Librarian))
            {
                NotificationServices.GetInstance().ShowError("Error user type", "Error User Type!");
                return;
            }
            OpenState("main", member);
        }
    }
}
