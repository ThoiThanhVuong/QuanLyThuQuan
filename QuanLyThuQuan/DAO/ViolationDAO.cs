using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThuQuan.DAO
{
    class ViolationDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<ViolationModel> GetViolations()
        {
            List<ViolationModel> violations = new List<ViolationModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Violation";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int violationId = reader.GetInt32("ViolationID");
                int memberId = reader.GetInt32("MemberID");

                int? transactionId = reader.IsDBNull(reader.GetOrdinal("TransactionID"))
                                        ? (int?)null
                                        : reader.GetInt32(reader.GetOrdinal("TransactionID"));

                int ruleId = reader.GetInt32("RuleID");
                int fineAmount = reader.GetInt32("FineAmount");
                string reason = reader.GetString("Reason");
                DateTime violationDate = reader.GetDateTime("ViolationDate");
                bool isCompRequired = reader.GetBoolean("IsCompensationRequired");
                string HandlingAction = reader.IsDBNull(reader.GetOrdinal("HandlingAction")) ? null : reader.GetString("HandlingAction");
                string Status = reader.GetString("Status");
                violations.Add(new ViolationModel(
                    violationId,
                    memberId,
                    transactionId,
                    ruleId,
                    fineAmount,
                    reason,
                    violationDate,
                    isCompRequired,
                    HandlingAction,
                    Status
                ));
            }

            reader.Close();
            db.CloseConnection();
            return violations;
        }
        public ViolationModel GetViolationByID(int ID)
        {
            ViolationModel violation = null;
            db.OpenConnection();
            string query = "SELECT * FROM Violation WHERE ViolationID=@ID";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int violationId = reader.GetInt32("ViolationID");
                int memberId = reader.GetInt32("MemberID");

                int? transactionId = reader.IsDBNull(reader.GetOrdinal("TransactionID"))
                                        ? (int?)null
                                        : reader.GetInt32(reader.GetOrdinal("TransactionID"));


                int ruleId = reader.GetInt32("RuleID");
                int fineAmount = reader.GetInt32("FineAmount");
                string reason = reader.GetString("Reason");
                DateTime violationDate = reader.GetDateTime("ViolationDate");
                bool isCompRequired = reader.GetBoolean("IsCompensationRequired");
                string HandlingAction = reader.IsDBNull(reader.GetOrdinal("HandlingAction")) ? null : reader.GetString("HandlingAction");
                string Status = reader.GetString("Status");
              violation=(new ViolationModel(
                    violationId,
                    memberId,
                    transactionId,
                    ruleId,
                    fineAmount,
                    reason,
                    violationDate,
                    isCompRequired,
                    HandlingAction,
                    Status
                ));
            }

            reader.Close();
            db.CloseConnection();
            return violation;
        }
        public bool AddViolation(ViolationModel violation)
        {
            db.OpenConnection();
            string query = "INSERT INTO Violation (MemberId, TransactionId, RuleId, FineAmount, Reason, ViolationDate, IsCompensationRequired, HandlingAction, Status) " +
                           "VALUES (@MemberId, @TransactionId, @RuleId, @FineAmount, @Reason, @ViolationDate, @IsCompensationRequired, @HandlingAction, @Status)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberId", violation.MemberID);
                cmd.Parameters.AddWithValue("@TransactionId", (object)violation.TransactionID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RuleId", violation.RuleID);
                cmd.Parameters.AddWithValue("@FineAmount", violation.FineAmount);
                cmd.Parameters.AddWithValue("@Reason", violation.Reason);
                cmd.Parameters.AddWithValue("@ViolationDate", violation.ViolationDate);
                cmd.Parameters.AddWithValue("@IsCompensationRequired", violation.IsCompensationRequired);
                cmd.Parameters.AddWithValue("@HandlingAction", (object)violation.HandlingAction ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", violation.Status);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool UpdateViolation(ViolationModel violation)
        {
            db.OpenConnection();
            string query = "UPDATE Violation SET MemberId = @MemberId, TransactionId = @TransactionId, RuleId = @RuleId, FineAmount = @FineAmount, Reason = @Reason, " +
                           "ViolationDate = @ViolationDate, IsCompensationRequired = @IsCompensationRequired, HandlingAction = @HandlingAction, Status = @Status " +
                           "WHERE ViolationID = @ViolationID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberId", violation.MemberID);
                cmd.Parameters.AddWithValue("@TransactionId", (object)violation.TransactionID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RuleId", violation.RuleID);
                cmd.Parameters.AddWithValue("@FineAmount", violation.FineAmount);
                cmd.Parameters.AddWithValue("@Reason", violation.Reason);
                cmd.Parameters.AddWithValue("@ViolationDate", violation.ViolationDate);
                cmd.Parameters.AddWithValue("@IsCompensationRequired", violation.IsCompensationRequired);
                cmd.Parameters.AddWithValue("@HandlingAction", (object)violation.HandlingAction ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", violation.Status);
                cmd.Parameters.AddWithValue("@ViolationID", violation.ViolationID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool DeleteViolation(int violationID)
        {
            db.OpenConnection();
            string query = "DELETE FROM Violation WHERE ViolationID = @ViolationID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@ViolationID", violationID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }

        }

        public int MaxViolationID()
        {
            db.OpenConnection();
            string query = "SELECT MAX(ViolationID) FROM Violation";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            int maxViolationID = Convert.ToInt32(cmd.ExecuteScalar());
            maxViolationID++;
            db.CloseConnection();
            return maxViolationID;
        }
        // Kiểm tra số lượng đã vi phạm của thành viên
        public int checkCountViolationByID(int ID)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(*) FROM Violation WHERE MemberID = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    object result = cmd.ExecuteScalar();
                    db.CloseConnection();

                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                db.CloseConnection();
                return 0;
            }
        }
        // kiểm tra thành viên có vi phạm nào chưa xử lý không
        public int checkViolationStatusPendingByID(int ID)
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT COUNT(*) FROM Violation WHERE MemberID = @ID AND Status = 'Pending'";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    object result = cmd.ExecuteScalar();
                    db.CloseConnection();

                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                db.CloseConnection();
                return 0;
            }
        }
        public bool MarkViolationAsHandled(int violationID)
        {
            db.OpenConnection();
            string query = "UPDATE Violation SET Status = 'Handled' WHERE ViolationID = @ViolationID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@ViolationID", violationID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }
        public bool MarkViolationsAsHandledByTransactionID(int transactionID)
        {
            db.OpenConnection();
            string query = "UPDATE Violation SET Status = 'Handled' WHERE TransactionID = @TransactionID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public List<ViolationModel> SearchViolationByMemberID(string keyword)
        {
            List<ViolationModel> violations = new List<ViolationModel>();
            try {
                db.OpenConnection();
                bool isNumber = int.TryParse(keyword, out int memberID);
                if (isNumber)
                {
                    string query = "SELECT * FROM Violation WHERE MemberID=@keyword";
                    MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                    cmd.Parameters.AddWithValue("@keyword", memberID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int violationId = reader.GetInt32("ViolationID");
                        int memberId = reader.GetInt32("MemberID");
                        int? transactionId = reader.IsDBNull(reader.GetOrdinal("TransactionID"))
                                                ? (int?)null
                                                : reader.GetInt32(reader.GetOrdinal("TransactionID"));
                        int ruleId = reader.GetInt32("RuleID");
                        int fineAmount = reader.GetInt32("FineAmount");
                        string reason = reader.GetString("Reason");
                        DateTime violationDate = reader.GetDateTime("ViolationDate");
                        bool isCompRequired = reader.GetBoolean("IsCompensationRequired");
                        string HandlingAction = reader.IsDBNull(reader.GetOrdinal("HandlingAction")) ? null : reader.GetString("HandlingAction");
                        string Status = reader.GetString("Status");

                        violations.Add(new ViolationModel(
                            violationId,
                            memberId,
                            transactionId,
                            ruleId,
                            fineAmount,
                            reason,
                            violationDate,
                            isCompRequired,
                            HandlingAction,
                            Status
                        ));

                    }
                    reader.Close();
                }
              

            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm" + ex.Message);
            }
           db.CloseConnection();
            return violations;
        }
    }
}
