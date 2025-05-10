using MySql.Data.MySqlClient;
using ThuQuanWebForm.AppConfig;
using ThuQuanWebForm.BUS;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuQuanWebForm.DAO
{
    class SessionStudyDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<SessionStudy> GetAllSessionStudies()
        {
            List<SessionStudy> sessionStudys = new List<SessionStudy>();
            try
            {
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


            }
            catch (Exception ex)
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

                string query = "SELECT * FROM studysession WHERE DATE(CheckInTime) = CURDATE()";
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


            }
            catch (Exception ex)
            {
                Console.WriteLine("lỗi khi lấy dữ liệu " + ex.Message);
            }
            db.CloseConnection();
            return sessionStudys;
        }

        public bool addSessionStudy(int id)
        {
            bool success = false;
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO studysession (MemberId , CheckInTime)" +
                    " VALUES (@MemberId , NOW())";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@MemberId", id);
                int result = cmd.ExecuteNonQuery();
                success = result > 0;
            }
            catch (Exception ex)
            {
                // Log the exception details
                System.Diagnostics.Debug.WriteLine($"Error adding session study for member ID {id}: {ex.Message}");
                success = false;
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (db.Connection != null && db.Connection.State == System.Data.ConnectionState.Open)
                {
                    db.CloseConnection();
                }
            }
            return success;
        }

    }
}
