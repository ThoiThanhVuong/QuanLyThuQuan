using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormBorrowBook : Form
    {

        public FormBorrowBook()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.BackColor = Color.White;
            //this.Paint += (s, e) =>
            //{
            //    e.Graphics.DrawRectangle(new Pen(Color.Red, 0), 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
            //};
        }
        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnExitBookBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
