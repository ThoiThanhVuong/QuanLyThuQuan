using System;

namespace QuanLyThuQuan.Model
{
    class ViolationModel
    {
        public int ViolationID { get; set; }
        public int MemberID { get; set; }
        public int TransactionID { get; set; }
        public int RuleID { get; set; }
        public decimal FineAmount { get; set; }
        public string Reason { get; set; }
        public DateTime ViolationDate { get; set; }
        public PaidStatus PaidStatus { get; set; }

        // Navigation Properties
        public MemberModel Member { get; set; }
        public TransactionModel Transaction { get; set; }
        public RuleModel Rule { get; set; }

        public ViolationModel()
        {

        }

        public ViolationModel(int violationID, int memberID, int transactionID, int ruleID, decimal fineAmount, string reason, DateTime violationDate, PaidStatus paidStatus)
        {
            ViolationID = violationID;
            MemberID = memberID;
            TransactionID = transactionID;
            RuleID = ruleID;
            FineAmount = fineAmount;
            Reason = reason;
            ViolationDate = violationDate;
            PaidStatus = paidStatus;
        }

        public ViolationModel(int violationID, int memberID, int transactionID, int ruleID, decimal fineAmount, string reason, DateTime violationDate, PaidStatus paidStatus, MemberModel member, TransactionModel transaction, RuleModel rule) : this(violationID, memberID, transactionID, ruleID, fineAmount, reason, violationDate, paidStatus)
        {
            Member = member;
            Transaction = transaction;
            Rule = rule;
        }
    }
}
