using MySql.Data.MySqlClient;
using ThuQuanWebForm.AppConfig;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;


namespace ThuQuanWebForm.DAO
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
        public int GetAuthorIDByName(string name)
        {
            int authorID = -1;
            try
            {
                db.OpenConnection();
                string query = "SELECT AuthorID FROM Authors WHERE AuthorName=@AuthorName AND AuthorStatus='Active' ";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@AuthorName", name);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            authorID = reader.GetInt32("AuthorID");
                        }
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
            return authorID;
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
                string query = "UPDATE Authors SET AuthorStatus='Inactive' WHERE AuthorID =@AuthorID ";

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
        public int GenerateNewAuthorCode()
        {
            int lastID = 0;
            db.OpenConnection();
            string query = "SELECT MAX(AuthorID) FROM Authors";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            var result = cmd.ExecuteScalar();
            lastID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            return lastID;
        }
        public bool CheckAuthorExists(string authorName)
        {
            bool exists = false;
            db.OpenConnection();
            string query = "SELECT COUNT(*) FROM Authors WHERE AuthorName = @AuthorName";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@AuthorName", authorName);

            var result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                exists = Convert.ToInt32(result) > 0;
            }
            db.CloseConnection();
            return exists;
        }


    }
}
