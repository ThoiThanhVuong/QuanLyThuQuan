using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormDevice : Form
    {
        public FormDevice()
        {
            InitializeComponent();
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
