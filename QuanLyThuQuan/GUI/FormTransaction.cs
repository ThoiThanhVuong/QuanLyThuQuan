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
       
      

        public FormTransaction()
        {
            InitializeComponent();
          
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            LoadAllTransaction();

            dgvTransactions.CellContentClick -= dgvTransactions_CellContentClick; 
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;

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
            }
        }
    }
}
