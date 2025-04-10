using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
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

        public List<LoginHistoryModel> GetLoginHistoryByMemberID(int memberID)
        {
            List<LoginHistoryModel> loginHistory = new List<LoginHistoryModel>();
            try
            {
                db.OpenConnection();
                string query = $"SELECT * FROM LoginHistory WHERE MemberID = {memberID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
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

        public LoginHistoryModel GetLoginHistoryByID(int loginID)
        {
            LoginHistoryModel loginHistory = null;
            try
            {
                db.OpenConnection();
                string query = $"SELECT * FROM LoginHistory WHERE LoginID = {loginID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loginHistory = new LoginHistoryModel(
                                reader.GetInt32("LoginID"),
                                reader.GetInt32("MemberID"),
                                reader.GetDateTime("LoginTime"),
                                reader.IsDBNull(reader.GetOrdinal("LogoutTime")) ? (DateTime?)null : reader.GetDateTime("LogoutTime"),
                                (LoginStatus)Enum.Parse(typeof(LoginStatus), reader.GetString("Status"))
                            );
                        }
                    }
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

        public bool AddLoginHistory(LoginHistoryModel loginHistory)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO LoginHistory (MemberID, LoginTime, LogoutTime, Status) " +
                              $"VALUES ({loginHistory.MemberID}, " +
                              $"'{loginHistory.LoginTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                              (loginHistory.LogoutTime.HasValue ? $"'{loginHistory.LogoutTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL") + ", " +
                              $"'{loginHistory.Status.ToString()}')";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding login history: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdateLoginHistory(LoginHistoryModel loginHistory)
        {
            try
            {
                db.OpenConnection();
                string query = $"UPDATE LoginHistory SET " +
                              $"MemberID = {loginHistory.MemberID}, " +
                              $"LoginTime = '{loginHistory.LoginTime.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                              $"LogoutTime = " + (loginHistory.LogoutTime.HasValue ? $"'{loginHistory.LogoutTime.Value.ToString("yyyy-MM-dd HH:mm:ss")}'" : "NULL") + ", " +
                              $"Status = '{loginHistory.Status.ToString()}' " +
                              $"WHERE LoginID = {loginHistory.LoginID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating login history: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DeleteLoginHistory(int loginID)
        {
            try
            {
                db.OpenConnection();
                string query = $"DELETE FROM LoginHistory WHERE LoginID = {loginID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting login history: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdateLogoutTime(int loginID, DateTime logoutTime)
        {
            try
            {
                db.OpenConnection();
                string query = $"UPDATE LoginHistory SET " +
                              $"LogoutTime = '{logoutTime.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                              $"WHERE LoginID = {loginID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating logout time: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}