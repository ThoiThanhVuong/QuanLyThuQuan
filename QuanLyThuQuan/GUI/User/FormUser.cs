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
        public FormUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl addMember = new AddUser();
            addMember.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(addMember);
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserControl addMember = new AddUser();
            addMember.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(addMember);
        }
    }
}
