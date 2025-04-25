using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.Model
{
    public class TransactionModel
    {
       public int TransactionID { get; set; }
        public int MemberID { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public TransactionStatus Status { get; set; }

        public MemberModel Member { get; set; }
        public List<TransactionItemModel> TransactionItems { get; set; } = new List<TransactionItemModel>();
        public List<PaymentModel> Payments { get; set; } = new List<PaymentModel>();
        public List<ViolationModel> Violations { get; set; } = new List<ViolationModel>();

        public decimal TotalPaymentAmount => Payments?.Where(p => !p.Description.Contains("Tổng")).Sum(p => p.Amount) ?? 0;
        public bool IsFullyPaid => Payments != null && Payments.All(p => p.Status == PaidStatus.Paid);
        public TransactionModel()
        {
            TransactionItems = new List<TransactionItemModel>();
        }

        public TransactionModel(int transactionID, int memberID, TransactionType transactionType, DateTime transactionDate, DateTime? dueDate, DateTime? returnDate, TransactionStatus status)
        {
            TransactionID = transactionID;
            MemberID = memberID;
            TransactionType = transactionType;
            TransactionDate = transactionDate;
            DueDate = dueDate;
            ReturnDate = returnDate;
            Status = status;
            TransactionItems = new List<TransactionItemModel>();
        }

        public TransactionModel(int transactionID, int memberID, TransactionType transactionType, DateTime transactionDate, DateTime? dueDate, DateTime? returnDate, TransactionStatus status, MemberModel member) : this(transactionID, memberID, transactionType, transactionDate, dueDate, returnDate, status)
        {
            Member = member;
        }
        public override string ToString()
        {
            string items = TransactionItems != null && TransactionItems.Count > 0
                           ? string.Join(", ", TransactionItems.Select(item => $"ItemID: {item.ItemID}, BookID: {item.BookID}, DeviceID: {item.DeviceID}, Amount: {item.Amount}"))
                           : "No items";
            return $"TransactionID: {TransactionID}, MemberID: {MemberID}, TransactionType: {TransactionType}, Status: {Status}, Items: {items} ,Member:{Member}";
        }
    }

}
