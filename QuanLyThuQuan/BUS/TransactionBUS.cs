
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyThuQuan.BUS
{
    class TransactionBUS 
    {
        private TransactionDAO transactionDAO = new TransactionDAO();

 
        public TransactionBUS() { }
        public List<TransactionModel> GetAllTransactionsWithItems()
        {
            return transactionDAO.GetAllTransactionsWithItems();
        }
        public TransactionModel GetTransactionByID(int ID)
        {
            return transactionDAO.GetTransactionByID(ID);
        }
        public bool AddTransactionWithItems(TransactionModel transaction)
        {
            return transactionDAO.AddTransactionWithItems(transaction);
        }
        public bool UpdateTransactionWithItems(TransactionModel transaction)
        {
            return transactionDAO.UpdateTransactionWithItems(transaction);
        }
        public bool DeleteTransactionWithItems(int transactionID)
        {
            return transactionDAO.DeleteTransactionWithItems(transactionID);
        }
        public List<PaymentModel> GetPaymentsByTransactionID(int transactionID)
        {
            return transactionDAO.GetPaymentsByTransactionID(transactionID);
        }
        public List<ViolationModel> GetViolationsByTransactionID(int transactionID)
        {
            return transactionDAO.GetViolationsByTransactionID(transactionID);
        }


        public bool ConfirmReturnAndCalculatePayment(int transactionID)
        {
            return transactionDAO.ConfirmReturnAndCalculatePayment(transactionID);
        }
        //public bool ReturnTransaction(int transactionID)
        //{
        //    return transactionDAO.ReturnTransaction(transactionID);
        //}

        public void LoadExtraDetails(TransactionModel transaction)
        {
            transaction.Payments = transactionDAO.GetPaymentsByTransactionID(transaction.TransactionID)
                .Where(p => !p.Description.Contains("T?ng"))
                .ToList();

            transaction.Violations = transactionDAO.GetViolationsByTransactionID(transaction.TransactionID);

            if (transaction.Status == TransactionStatus.Active && transaction.DueDate.HasValue && transaction.ReturnDate.HasValue)
            {
                var due = transaction.DueDate.Value;
                var returned = transaction.ReturnDate.Value;

                if (returned > due)
                {
                    int daysLate = (returned - due).Days;
                    if (!transaction.Violations.Any(v => v.Reason.Contains("tr? h?n")))
                    {
                        var lateViolation = new ViolationModel
                        {
                            MemberID = transaction.MemberID,
                            TransactionID = transaction.TransactionID,
                            RuleID = 3,
                            FineAmount = daysLate * 10000,
                            Reason = "Tr? sách tr? h?n",
                            ViolationDate = returned,
                            IsCompensationRequired = false
                        };
                        transaction.Violations.Add(lateViolation);

                        var fine = new PaymentModel(transaction.MemberID, null, transaction.TransactionID, lateViolation.FineAmount, "Tr? sách quá h?n", PaidStatus.Unpaid);
                        transaction.Payments.Add(fine);
                    }
                }
            }
        }

        public bool ReturnSingleItem(int itemID)
        {
            return transactionDAO.ReturnSingleItem(itemID);
        }
        public bool UpdateDueDate(int transactionID, DateTime dueDate)
        {
            return transactionDAO.UpdateDueDate(transactionID, dueDate);
        }

    }
}
