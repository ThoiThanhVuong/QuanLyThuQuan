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
                violations.Add(new ViolationModel(
                    reader.GetInt32("ViolationID"),
                    reader.GetInt32("MemberId"),
                    reader.GetInt32("TransactionId"),
                    reader.GetInt32("RuleId"),
                    reader.GetInt32("FineAmount"),
                    reader.GetString("Reason"),
                    reader.GetDateTime("ViolationDate"),
                    reader.GetBoolean("IsCompensationRequired")
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

    }
}
