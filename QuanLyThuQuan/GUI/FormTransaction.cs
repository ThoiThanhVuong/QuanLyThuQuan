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
        }

        public FormTransaction()
        {
            InitializeComponent();

            // Add col button for data transaction table
            DataGridViewButtonColumn colAdvancedBtn = new DataGridViewButtonColumn();
            colAdvancedBtn.HeaderText = "Options";
            colAdvancedBtn.Text = "More";
            colAdvancedBtn.UseColumnTextForButtonValue = true;
            dataTransactions.Columns.Add(colAdvancedBtn);
            colAdvancedBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            colAdvancedBtn.DefaultCellStyle.ForeColor = Color.Black;
            colAdvancedBtn.DefaultCellStyle.BackColor = Color.White;
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataTransactions.CellClick += dataTransactions_CellContentClick;

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

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "The program is currently development!",
                "Alert",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
                );
            txtResult.Text = result.ToString();
            txtResult.Visible = true;
            TimerForComponent(txtResult, 3000);
        }

        private void FormTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult alert = MessageBox.Show(
                "Do you wanna exit ?",
                "Exit Program Alert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void timeTextBoxResult_Tick(object sender, EventArgs e)
        //{
        //    timeTextBoxResult.Stop();
        //    txtResult.Visible = false;
        //}
    }
}
