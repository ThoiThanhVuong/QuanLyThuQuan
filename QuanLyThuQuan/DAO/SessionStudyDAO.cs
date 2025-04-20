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
    class SessionStudyDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<SessionStudy> GetSessionStudies()
        {
            db.OpenConnection();
            List<SessionStudy> sessionStudys = new List<SessionStudy>();
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
