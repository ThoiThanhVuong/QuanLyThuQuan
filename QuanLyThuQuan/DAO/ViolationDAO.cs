using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

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

                violations.Add(new ViolationModel(
                    violationId,
                    memberId,
                    transactionId,
                    ruleId,
                    fineAmount,
                    reason,
                    violationDate,
                    isCompRequired
                ));
            }

            reader.Close();
            db.CloseConnection();
            return violations;
        }

        public bool AddViolation(ViolationModel violation)
        {
            db.OpenConnection();
            string query = "INSERT INTO Violation (MemberId, TransactionId, RuleId," +
                " FineAmount, Reason, ViolationDate, IsCompensationRequired)" +
                " VALUES (@MemberId, @TransactionId, @RuleId, @FineAmount, @Reason, @ViolationDate, @IsCompensationRequired)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberId", violation.MemberID);
                cmd.Parameters.AddWithValue("@TransactionId", violation.TransactionID);
                cmd.Parameters.AddWithValue("@RuleId", violation.RuleID);
                cmd.Parameters.AddWithValue("@FineAmount", violation.FineAmount);
                cmd.Parameters.AddWithValue("@Reason", violation.Reason);
                cmd.Parameters.AddWithValue("@ViolationDate", violation.ViolationDate);
                cmd.Parameters.AddWithValue("@IsCompensationRequired", violation.IsCompensationRequired);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool UpdateViolation(ViolationModel violation)
        {
            db.OpenConnection();
            string query = "UPDATE Violation SET MemberId = @MemberId, TransactionId = @TransactionId," +
                " RuleId = @RuleId, FineAmount = @FineAmount, Reason = @Reason, ViolationDate = @ViolationDate," +
                " IsCompensationRequired = @IsCompensationRequired WHERE ViolationID = @ViolationID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberId", violation.MemberID);
                cmd.Parameters.AddWithValue("@TransactionId", violation.TransactionID);
                cmd.Parameters.AddWithValue("@RuleId", violation.RuleID);
                cmd.Parameters.AddWithValue("@FineAmount", violation.FineAmount);
                cmd.Parameters.AddWithValue("@Reason", violation.Reason);
                cmd.Parameters.AddWithValue("@ViolationDate", violation.ViolationDate);
                cmd.Parameters.AddWithValue("@PaidStatus", violation.IsCompensationRequired);
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
    }
}
