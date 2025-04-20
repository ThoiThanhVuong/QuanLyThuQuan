using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;


namespace QuanLyThuQuan.DAO
{
    class AuthorDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<AuthorModel> GetAllAuthors()
        {
            List<AuthorModel> authors = new List<AuthorModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Authors WHERE AuthorStatus='Active'";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return authors;
        }
        public AuthorModel GetAuthorByID(int ID)
        {
            AuthorModel author = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Authors WHERE AuthorID=@AuthorID AND AuthorStatus='Active' ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorID", ID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            author = new AuthorModel(
                             reader.GetInt32("AuthorID"),
                             reader.GetString("AuthorName"),
                             (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                             );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu " + ex.Message);
            }
            db.CloseConnection();
            return author;
        }
        public bool AddAuthor(AuthorModel author)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO Authors (AuthorID,AuthorName,AuthorStatus) " +
                    "VALUES(@AuthorID,@AuthorName,@AuthorStatus)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorID", author.AuthorID);
                    cmd.Parameters.AddWithValue("@AuthorName", author.AuthorName);
                    cmd.Parameters.AddWithValue("@AuthorStatus", author.AuthorStatus.ToString());
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm mới " + ex.Message);
                return false;
            }
        }
        public bool UpdateAuthor(AuthorModel author)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Authors SET AuthorName=@AuthorName,AuthorStatus=@AuthorStatus" +
                    " WHERE AuthorID = @AuthorID ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", author.AuthorName);
                    cmd.Parameters.AddWithValue("@AuthorStatus", author.AuthorStatus.ToString());
                    cmd.Parameters.AddWithValue("@AuthorID", author.AuthorID);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("lỗi khi sửa dữ liệu" + ex.Message);
                return false;
            }
        }
        public bool DeleteAuthor(int AuthorID)
        {

            try
            {
                db.OpenConnection();
                string query = "DELETE Authors SET Status='Inactive' WHERE AuthorID =@AuthorID ";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorID", AuthorID);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("lỗi khi xóa dữ liệu" + ex.Message);
                return false;
            }
        }
        public List<AuthorModel> SearchAuthor(string keyword)
        {

            List<AuthorModel> authors = new List<AuthorModel>();
            try
            {

                db.OpenConnection();
                string query = "SELECT * FROM Authors WHERE AuthorName like @keyword AND AuthorStatus='Active' ";
                bool isNumber = int.TryParse(keyword, out int authorID);
                if (isNumber)
                {
                    query += "OR AuthorID=@AuthorID";
                }
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    if (isNumber)
                        cmd.Parameters.AddWithValue("@AuthorID", authorID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(new AuthorModel(
                               reader.GetInt32("AuthorID"),
                               reader.GetString("AuthorName"),
                                (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                               ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm tác giả " + ex.Message);
            }
            db.CloseConnection();
            return authors;
        }

    }
}
