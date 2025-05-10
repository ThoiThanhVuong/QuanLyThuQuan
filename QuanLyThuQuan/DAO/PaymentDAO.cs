using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DAO
{
    class PaymentDAO
    {
        private ConnectDB db = new ConnectDB();

        public bool AddPayment(PaymentModel payment)
        {
            db.OpenConnection();
            string query = "INSERT INTO Payment (MemberID, ViolationID, TransactionID, Amount, Description, PaymentDate, Status) " +
                           "VALUES (@MemberID, @ViolationID, @TransactionID, @Amount, @Description, @PaymentDate, @Status)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", payment.MemberID);
                cmd.Parameters.AddWithValue("@ViolationID", (object)payment.ViolationID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TransactionID", (object)payment.TransactionID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                cmd.Parameters.AddWithValue("@Description", payment.Description);
                cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate);
                cmd.Parameters.AddWithValue("@Status", payment.Status.ToString());
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool UpdatePaymentStatus(int paymentID, PaidStatus newStatus)
        {
            db.OpenConnection();
            string query = "UPDATE Payment SET Status = @Status WHERE PaymentID = @PaymentID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Status", newStatus.ToString());
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }
        public PaymentModel GetPaymentByViolationID(int violationID)
        {
            PaymentModel payment = null;
            db.OpenConnection();
            string query = "SELECT * FROM Payment WHERE ViolationID = @ViolationID LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@ViolationID", violationID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        payment= new PaymentModel
                        {
                            PaymentID = reader.GetInt32("PaymentID"),
                            MemberID = reader.GetInt32("MemberID"),
                            ViolationID = reader.GetInt32("ViolationID"),
                            TransactionID = reader.IsDBNull(reader.GetOrdinal("TransactionID"))
                                            ? (int?)null
                                            : reader.GetInt32(reader.GetOrdinal("TransactionID")),
                            Amount = reader.GetDecimal("Amount"),
                            Description = reader.GetString("Description"),
                            PaymentDate = reader.GetDateTime("PaymentDate"),
                            Status = (PaidStatus)Enum.Parse(typeof(PaidStatus), reader.GetString("Status"))
                        };
                    }
                }
            }
            db.CloseConnection();
            return payment;
        }
        public bool MarkAsPaidByViolationID(int violationID)
        {
            db.OpenConnection();
            string query = "UPDATE Payment SET Status = 'Paid' WHERE ViolationID = @ViolationID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@ViolationID", violationID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }


    }

}
