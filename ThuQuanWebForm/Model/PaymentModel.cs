using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuQuanWebForm.Model
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }
        public int MemberID { get; set; }
        public int? ViolationID { get; set; }
        public int? TransactionID { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaidStatus Status { get; set; }

        public PaymentModel() { }

        public PaymentModel(int memberID, int? violationID, int? transactionID, decimal amount, string description, PaidStatus status)
        {
            MemberID = memberID;
            ViolationID = violationID;
            TransactionID = transactionID;
            Amount = amount;
            Description = description;
            PaymentDate = DateTime.Now;
            Status = status;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
