using QuanLyThuQuan.BUS;
using QuanLyThuQuan.GUI.TransactionFormChilds;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
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
            LoadAllTransaction();
            //dgvDataTransactions.CellContentClick += dgvDataTransactions_CellContentClick;

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
            FormReservation reservation = new FormReservation();
            reservation.ShowDialog();
        }

        private void dgvDataTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDataTransactions.Columns[e.ColumnIndex].Name.Equals("colMoreOptions"))
            {
                FormInformation informationForm = new FormInformation(dgvDataTransactions.Rows[e.RowIndex].Cells[1].Value.ToString());
                informationForm.ShowDialog();
            }
        }

        // NOTE: CREATE COLUMNS
        private void CreateColumn(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("More"))
            {
                DataGridViewButtonColumn moreColumn = new DataGridViewButtonColumn();
                moreColumn.Name = "colMoreOptions";
                moreColumn.HeaderText = "";
                moreColumn.Text = "...";
                moreColumn.UseColumnTextForButtonValue = true;
                moreColumn.Width = 10;
                dgv.Columns.Add(moreColumn);
            }
        }

        private void LoadAllTransaction()
        {

            //List<TransactionModel> transactions = TransactionBUS.GetInstance().GetAllLocal();
            TransactionBUS trans = new TransactionBUS();
            trans.LoadLocal();
            List<TransactionModel> transactions = trans.GetAllLocal();
            ClearTable(dgvDataTransactions);
            dgvDataTransactions.DataSource = null;
            dgvDataTransactions.DataSource = transactions;
            Console.WriteLine("transactions" + transactions);
            CreateColumn(dgvDataTransactions);
            dgvDataTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataTransactions.ReadOnly = true;
            dgvDataTransactions.Columns["Status"].MinimumWidth = 50;
            dgvDataTransactions.DefaultCellStyle.ForeColor = Color.Blue;
            List<string> colList = new List<string>{"TransactionType", "TransactionDate", "TransactionID", "DueDate",
                                                    "ReturnDate", "MemberID"};
            ResizeSpecificCols(colList, dgvDataTransactions, DataGridViewAutoSizeColumnMode.AllCells);

        }

        // Resize columns
        private void ResizeSpecificCols(List<string> colList, DataGridView dgv, DataGridViewAutoSizeColumnMode mode)
        {
            IEnumerator<string> list = colList.GetEnumerator();
            while (list.MoveNext())
                dgv.Columns[list.Current].AutoSizeMode = mode;
        }
        // clear tables
        private void ClearTable(DataGridView dgv)
        {
            if (dgv == null) return;
            dgv.DataSource = null;
            dgv.Columns.Clear();
            dgv.Rows.Clear();
        }
        // Relative with other classes
    }
}
