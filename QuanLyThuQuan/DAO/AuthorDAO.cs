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
    class AuthorDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<AuthorModel> GetAllAuthors()
        {
            List<AuthorModel> authors = new List<AuthorModel>();
            try {
                db.OpenConnection();
                string query = "SELECT * FROM Authors";
                using(MySqlCommand cmd =new MySqlCommand(query, db.Connection))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(new AuthorModel(
                                reader.GetInt32("AuthorID"),
                                reader.GetString("AuthorName"),
                                 (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                                ));
                        }
                        reader.Close();
                    }
                }

              
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return authors;
        }
        public bool AddAuthor(AuthorModel author)
        {
            try {
                db.OpenConnection();
                string query = "INSERT INTO Authors (AuthorID,AuthorName,AuthorStatus) " +
                    "VALUES(@AuthorID,@AuthorName,@AuthorStatus)";
                using(MySqlCommand cmd=new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorID", author.AuthorID);
                    cmd.Parameters.AddWithValue("@AuthorName", author.AuthorName);
                    cmd.Parameters.AddWithValue("@AuthorStatus", author.AuthorStatus.ToString());
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm mới " + ex.Message);
                return false;
            }
        }
    }
}
