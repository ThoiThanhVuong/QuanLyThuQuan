using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class TransactionModel
    {
        public int TransactionID { get; set; }
        public int MemberID { get; set; } // Khóa ngoại

        public TransactionType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? DueDate { get; set; } 
        public DateTime? ReturnDate { get; set; } 

        public TransactionStatus Status { get; set; } 

        // Nếu muốn lấy thông tin Member trực tiếp
        public MemberModel Member { get; set; }
        public TransactionModel()
        {
            
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
        }

        public TransactionModel(int transactionID, int memberID, TransactionType transactionType, DateTime transactionDate, DateTime? dueDate, DateTime? returnDate, TransactionStatus status, MemberModel member) : this(transactionID, memberID, transactionType, transactionDate, dueDate, returnDate, status)
        {
            Member = member;
        }
    }

}
