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

        private void TimerForComponent(Control control, int time)
        {
            //timeTextBoxResult.Interval = time;
            Timer countdown = new Timer();
            countdown.Interval = time;
            countdown.Tick += (s, e) =>
            {
                countdown.Stop();
                countdown.Dispose();
                control.Visible = false;
            };
            countdown.Start();
            dataTransactions.CellClick += dataTransactions_CellContentClick;
            pnlChildDetailInfo.Paint += pnlChildDetailInfo_Paint;
        }

        // disable parent component
        private void DisableParentComponent(Control.ControlCollection controls, Control targetControl)
        {
            // Block event from parent component
            foreach (Control control in controls)
                if (!control.Equals(targetControl))
                    control.Enabled = false;
        }

        // enable parent component
        private void EnableParentComponent(Control.ControlCollection controls, Control targetControl)
        {
            foreach (Control control in controls)
                if (!control.Equals(targetControl))
                    control.Enabled = true;
        }

        // resize panel container
        private void ResizePanelContainer(Control children, Control parent)
        {
            parent.Width = children.Width;
            //parent.Height = children.Height;
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

        private void btnHandleViolations_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            pnlChildDetailInfo.Visible = true;
            DisableParentComponent(this.Controls, pnlContainer);
            ResizePanelContainer(pnlChildDetailInfo, pnlContainer);
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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            pnlFormBorrowBook.Visible = true;
            DisableParentComponent(this.Controls, pnlContainer);
            ResizePanelContainer(pnlFormBorrowBook, pnlContainer);
        }

        private void btnExitBookBorrow_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = false;
            pnlFormBorrowBook.Visible = false;
            EnableParentComponent(this.Controls, pnlContainer);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = true;
            pnlFormReturnBook.Visible = true;
            DisableParentComponent(this.Controls, pnlContainer);
            ResizePanelContainer(pnlFormReturnBook, pnlContainer);
        }

        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = false;
            pnlChildDetailInfo.Visible = false;
            EnableParentComponent(this.Controls, pnlContainer);
        }

        private void FormTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Block Cancel button when child parent is visible
            if (pnlChildDetailInfo.Visible)
            {
                e.Cancel = true;
                return;
            }
            else
                e.Cancel = false;

            DialogResult alert = MessageBox.Show(
                "Do you wanna exit ?",
                "Exit Program Alert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            // MessageBox for exit
            if (alert.Equals(DialogResult.Yes))
            {
                DialogResult result = MessageBox.Show(
                    "Have a good day friend =_=!",
                    "See ya",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void dataTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tbBody_Paint(object sender, PaintEventArgs e)
        {

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

        private void tbBlockInfoOne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitFormReturnBook_Click(object sender, EventArgs e)
        {
            pnlContainer.Visible = false;
            pnlFormReturnBook.Visible = false;
            EnableParentComponent(this.Controls, pnlContainer);
        }

        //private void timeTextBoxResult_Tick(object sender, EventArgs e)
        //{
        //    timeTextBoxResult.Stop();
        //    txtResult.Visible = false;
        //}
    }
}
