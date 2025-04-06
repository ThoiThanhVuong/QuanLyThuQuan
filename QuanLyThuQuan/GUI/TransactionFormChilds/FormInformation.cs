using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
