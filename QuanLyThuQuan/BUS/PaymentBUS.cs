using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class PaymentBUS
    {
        private PaymentDAO paymentDAO = new PaymentDAO();
        public bool AddPayment(PaymentModel payment)
        {
            return paymentDAO.AddPayment(payment);

        }
        public bool UpdatePaymentStatus(int paymentID, PaidStatus newStatus)
        {
            return paymentDAO.UpdatePaymentStatus(paymentID, newStatus);
        }
        public PaymentModel GetPaymentByViolationID(int violationID)
        {
            return paymentDAO.GetPaymentByViolationID(violationID);
        }
        public bool MarkAsPaidByViolationID(int violationID)
        {
            return paymentDAO.MarkAsPaidByViolationID(violationID);
        }
        public bool MarkAllPaymentsAsPaid(int transactionID)
        {
            return paymentDAO.MarkAllPaymentsAsPaid(transactionID);
        }

    }
}
