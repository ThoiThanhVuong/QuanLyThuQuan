using QuanLyThuQuan.GUI.TransactionFormChilds;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormTransaction : Form
    {
        // private methods
        private void ChangeColorHoverBtn(Button button, Color color)
        {
            button.BackColor = color;
        }

        public FormTransaction()
        {
            InitializeComponent();
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnBorrow_MouseEnter(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnBorrow, Color.LightCyan);
        }

        private void btnReturnBook_MouseEnter(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnReturnBook, Color.LightCyan);
        }

        private void btnBookReservation_MouseEnter(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnBookReservation, Color.LightCyan);
        }

        private void btnBorrow_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnBorrow, Color.Transparent);
        }

        private void btnReturnBook_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnReturnBook, Color.Transparent);
        }

        private void btnBookReservation_MouseLeave(object sender, EventArgs e)
        {
            ChangeColorHoverBtn(btnBookReservation, Color.Transparent);
        }

        private void pnlChildDetailInfo_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderSize = 10;
            Color borderColor = Color.Red;
            Control panel = sender as Control;
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
            }
            //ControlPaint.DrawBorder(e.Graphics, pnlChildDetailInfo.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        //Borrow button click
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FormBorrowBook borrowForm = new FormBorrowBook();
            borrowForm.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            FormReturnBook returnForm = new FormReturnBook();
            returnForm.ShowDialog();
        }

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            FormBorrowBook borrowForm = new FormBorrowBook();
            borrowForm.ShowDialog();
        }

        private void dgvDataTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormInformation informationForm = new FormInformation();
            informationForm.ShowDialog();
        }
    }
}
