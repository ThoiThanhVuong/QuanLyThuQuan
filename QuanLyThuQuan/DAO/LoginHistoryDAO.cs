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

        //maybe useless ??
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

        public List<LoginCountModel> GetAllLoginCounts()
        {
            List<LoginCountModel> loginCounts = new List<LoginCountModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT mb.MemberID, mb.FullName, COUNT(*) AS LoginCount FROM LoginHistory JOIN Member mb ON LoginHistory.MemberID = mb.MemberID GROUP BY mb.MemberID, mb.FullName";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loginCounts.Add(new LoginCountModel
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("FullName"),
                        LoginCount = reader.GetInt32("LoginCount")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving login counts: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return loginCounts;
        }

        public List<LoginCountModel> GetLoginCountByMemberID(int memberID)
        {
            List<LoginCountModel> loginCounts = new List<LoginCountModel>();
            try
            {
                db.OpenConnection();
                string query = $"SELECT mb.MemberID, mb.FullName, COUNT(*) AS LoginCount FROM LoginHistory JOIN Member mb ON LoginHistory.MemberID = mb.MemberID WHERE mb.MemberID = {memberID} GROUP BY mb.MemberID, mb.FullName";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loginCounts.Add(new LoginCountModel
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("FullName"),
                        LoginCount = reader.GetInt32("LoginCount")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving login counts: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return loginCounts;
        }

        public List<LoginCountModel> GetLoginCountByDate(DateTime from, DateTime to)
        {
            List<LoginCountModel> loginCounts = new List<LoginCountModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT mb.MemberID, mb.FullName, COUNT(*) AS LoginCount FROM LoginHistory JOIN Member mb ON LoginHistory.MemberID = mb.MemberID WHERE LoginTime BETWEEN @from AND @to GROUP BY mb.MemberID, mb.FullName";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loginCounts.Add(new LoginCountModel
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("FullName"),
                        LoginCount = reader.GetInt32("LoginCount")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving login counts by date: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return loginCounts;
        }

        public List<LoginCountModel> GetLoginCountByMemberAndDate(int memberID, DateTime from, DateTime to)
        {
            List<LoginCountModel> loginCounts = new List<LoginCountModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT mb.MemberID, mb.FullName, COUNT(*) AS LoginCount FROM LoginHistory JOIN Member mb ON LoginHistory.MemberID = mb.MemberID WHERE mb.MemberID = @memberID AND LoginTime BETWEEN @from AND @to GROUP BY mb.MemberID, mb.FullName";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loginCounts.Add(new LoginCountModel
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("FullName"),
                        LoginCount = reader.GetInt32("LoginCount")
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving login counts by member and date: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return loginCounts;
        }
    }
}