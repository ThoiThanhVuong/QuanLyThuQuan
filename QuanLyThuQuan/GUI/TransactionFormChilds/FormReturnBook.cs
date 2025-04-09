using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormReturnBook : Form
    {
        public FormReturnBook()
        {
            InitializeComponent();
        }
        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnExitFormReturnBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
