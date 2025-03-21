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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHandleViolations_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
