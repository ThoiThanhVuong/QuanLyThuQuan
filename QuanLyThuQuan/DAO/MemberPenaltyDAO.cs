using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
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
    }
}
