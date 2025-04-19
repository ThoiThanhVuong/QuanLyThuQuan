using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
        }

        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
