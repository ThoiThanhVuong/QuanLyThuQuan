using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DAO
{
    class SessionStudyDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<SessionStudy> GetAllSessionStudies()
        {
            List<SessionStudy> sessionStudys = new List<SessionStudy>();
            try {
                db.OpenConnection();
               
                string query = "SELECT * FROM studysession";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sessionStudys.Add(new SessionStudy(
                        reader.GetInt32("SessionId"),
                        reader.GetInt32("MemberId"),
                        reader.GetDateTime("CheckInTime"))
                    );
                }

                reader.Close();
               
                
            } catch(Exception ex)
            {
                Console.WriteLine("lỗi khi lấy dữ liệu " + ex.Message);
            }
            db.CloseConnection();
            return sessionStudys;
        }
        public List<SessionStudy> GetSessionStudies()
        {
            List<SessionStudy> sessionStudys = new List<SessionStudy>();
            try
            {
                db.OpenConnection();

                string query = @"
            SELECT s.SessionID, s.MemberID, s.CheckInTime, m.FullName, m.UserName
            FROM StudySession s
            JOIN Member m ON s.MemberID = m.MemberID
            WHERE DATE(s.CheckInTime) = CURDATE()";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SessionStudy session = new SessionStudy(
                        reader.GetInt32("SessionID"),
                        reader.GetInt32("MemberID"),
                        reader.GetDateTime("CheckInTime"),
                        reader.GetString("FullName"),
                        reader.GetString("UserName")
                    );
                    sessionStudys.Add(session);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            db.CloseConnection();
            return sessionStudys;
        }

        public bool addSessionStudy(int id)
        {
            db.OpenConnection();
            string query = "INSERT INTO studysession (MemberId , CheckInTime)" +
                " VALUES (@MemberId , NOW())";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@MemberId", id);
            int result = cmd.ExecuteNonQuery();
            db.CloseConnection();
            return result > 0;
        }

    }
}
