using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        public FormInformation(string id)
        {
            InitializeComponent();
            Debug.Print(id);
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

        // get id and show detail of this transaction id
        private void ShowTransactionDetail(string id)
        {

        }

        // get detail item of this transaction id
        private bool GetTransacionItemDetail(string id)
        {
            return false;
        }

        // render it to view
        private void RenderTransactionDetail(string id)
        {

        }
    }
}
