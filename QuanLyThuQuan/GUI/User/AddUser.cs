using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.User
{
    public partial class AddUser: UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public static implicit operator Form(AddUser v)
        {
            throw new NotImplementedException();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
