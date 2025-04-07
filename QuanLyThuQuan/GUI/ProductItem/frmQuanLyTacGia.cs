using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmQuanLyTacGia : Form
    {
        private FormMain mainForm;
        public frmQuanLyTacGia(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }
    }
}
