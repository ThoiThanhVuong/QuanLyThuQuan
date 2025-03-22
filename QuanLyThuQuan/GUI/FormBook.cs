using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
