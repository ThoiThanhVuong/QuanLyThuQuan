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
    class MemberPenaltyDAO
    {
        private ConnectDB db = new ConnectDB();
        public void AutoUnblockMembers()
        {
            db.OpenConnection();
            string query = "CALL AutoUnblockMembers();";
            using (MySqlConnection conn = db.Connection)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
        }
        public bool IsMemberBlocked(int memberID)
        {
            db.OpenConnection();
             string query = @"
                SELECT COUNT(*) 
                FROM MemberPenalty mp
                JOIN Violation v ON mp.ViolationID = v.ViolationID
                WHERE v.MemberID = @memberID 
                  AND (mp.EndDate IS NULL OR mp.EndDate >= CURDATE())";

            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@memberID", memberID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                db.CloseConnection();
                return count > 0;
            }
        }

        public bool AddPenalty(MemberPenaltyModel penalty)
        {
            db.OpenConnection();
            string query = "INSERT INTO MemberPenalty (ViolationID, StartDate, EndDate, Description) " +
                           "VALUES (@ViolationID, @StartDate, @EndDate, @Description)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                
                cmd.Parameters.AddWithValue("@ViolationID", penalty.ViolationID);
                cmd.Parameters.AddWithValue("@StartDate", penalty.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", (object)penalty.EndDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Description", penalty.Description);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

    }
}
