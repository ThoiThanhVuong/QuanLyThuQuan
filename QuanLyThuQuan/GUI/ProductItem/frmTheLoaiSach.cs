using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmTheLoaiSach : Form
    {
        private FormMain mainForm;
        public frmTheLoaiSach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }
    }
}
