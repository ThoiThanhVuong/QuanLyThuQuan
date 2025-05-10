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
        private TransactionBUS trans = new TransactionBUS();

        private string lastSearchTerm = "";

        public FormTransaction()
        {
            InitializeComponent();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            LoadAllTransaction();
            cbbStatusTrans.SelectedIndex = 0;
            dgvTransactions.CellContentClick -= dgvTransactions_CellContentClick; 
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cbbStatusTrans.SelectedIndexChanged += cbbStatusTrans_SelectedIndexChanged;

        }

        private void LoadAllTransaction()
        {

            List<TransactionModel> transactions = trans.GetAllTransactionsWithItems();
            if(transactions == null || transactions.Count == 0)
            {
                Console.WriteLine("Không có dữ liệu !");
            }
            else
            {
                dgvTransactions.Rows.Clear();
                dgvTransactions.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTransactions.Columns[7].DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                foreach (var transaction in transactions)
                {
                    dgvTransactions.Rows.Add(
                        transaction.TransactionID,
                        transaction.MemberID,
                        transaction.TransactionType,
                        transaction.TransactionDate,
                        transaction.DueDate,
                        transaction.ReturnDate,
                        transaction.Status,
                        "..."                      
                        );
                }
            }
                
        }
     
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FormBorrowBook borrowForm = new FormBorrowBook();
            borrowForm.ShowDialog();
            LoadAllTransaction();
        }


        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            FormReservation reservation = new FormReservation();
            reservation.ShowDialog();
            LoadAllTransaction();
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0)
            {
                int transactionID = Convert.ToInt32(dgvTransactions.Rows[e.RowIndex].Cells[0].Value);
                TransactionModel transaction = trans.GetTransactionByID(transactionID);
                trans.LoadExtraDetails(transaction); 
                FormInformation transactionInfo = new FormInformation();
                transactionInfo.SetValue(transaction);
                transactionInfo.ShowDialog();
                LoadAllTransaction();
            }
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (searchTerm != lastSearchTerm)
            {
                lastSearchTerm = searchTerm;
                searchTimer.Stop();
                searchTimer.Start();
            }
        }
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();

            string status = cbbStatusTrans.SelectedItem.ToString().Trim();
            string memberIDInput = txtSearch.Text.Trim();

            List<TransactionModel> filteredTransactions = trans.SearchTransactionsByFilter(status, memberIDInput);

            dgvTransactions.Rows.Clear();
            dgvTransactions.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[7].DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

            if (filteredTransactions.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giao dịch phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var transaction in filteredTransactions)
            {
                dgvTransactions.Rows.Add(
                    transaction.TransactionID,
                    transaction.MemberID,
                    transaction.TransactionType,
                    transaction.TransactionDate,
                    transaction.DueDate,
                    transaction.ReturnDate,
                    transaction.Status,
                    "..."
                );
            }


        }

        private void cbbStatusTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
    }
}
