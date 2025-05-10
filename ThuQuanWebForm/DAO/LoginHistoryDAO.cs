using MySql.Data.MySqlClient;
using ThuQuanWebForm.AppConfig;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;

namespace ThuQuanWebForm.DAO
{
    class LoginHistoryDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<LoginHistoryModel> GetAllLoginHistory()
        {
            List<LoginHistoryModel> loginHistory = new List<LoginHistoryModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM LoginHistory";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loginHistory.Add(new LoginHistoryModel(
                        reader.GetInt32("LoginID"),
                        reader.GetInt32("MemberID"),
                        reader.GetDateTime("LoginTime"),
                        reader.IsDBNull(reader.GetOrdinal("LogoutTime")) ? (DateTime?)null : reader.GetDateTime("LogoutTime"),
                        (LoginStatus)Enum.Parse(typeof(LoginStatus), reader.GetString("Status"))
                    ));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving login history: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return loginHistory;
        }

        public bool RecordLogin(int memberId)
        {
            try
            {
                db.OpenConnection();
                string query = @"INSERT INTO LoginHistory (MemberID, LoginTime, Status) 
                               VALUES (@MemberID, @LoginTime, @Status)";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", LoginStatus.Success.ToString());

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error recording login: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}