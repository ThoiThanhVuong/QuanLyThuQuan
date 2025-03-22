using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
