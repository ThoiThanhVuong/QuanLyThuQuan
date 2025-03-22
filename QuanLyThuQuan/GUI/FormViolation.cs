using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormViolation : Form
    {
        public FormViolation()
        {
            InitializeComponent();
        }

        private void FormViolation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
