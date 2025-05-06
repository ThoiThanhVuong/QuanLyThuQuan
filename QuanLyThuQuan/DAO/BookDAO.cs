using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.DAO
{
    class BookDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Books WHERE Status IN ('Available','OutOf')";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new BookModel(
                        reader.GetInt32("BookID"),
                            reader.GetString("BookTitle"),
                            reader.GetInt32("AuthorID"),
                            reader.GetString("BookImage"),
                            reader.GetInt32("CategoryID"),
                            reader.GetInt32("PublishYear"),
                            reader.GetInt32("Quantity"),
                            (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                            reader.GetInt32("fee_per_day")
                    ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sách: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return books;
        }
        public BookModel GetBookByID(int Id)
        {
            BookModel book = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Books " +
                     "JOIN authors ON Authors.AuthorID = Books.AuthorID " +
                    "JOIN Categories c ON c.CategoryID =Books.CategoryID " +
                    "WHERE BookID = @Id AND Status IN ('Available','OutOf')";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AuthorModel author = new AuthorModel(
                                reader.GetInt32("AuthorID"),
                                reader.GetString("AuthorName"),
                                (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                                );
                            CategoriesModel categories = new CategoriesModel(
                                reader.GetInt32("CategoryID"),
                                reader.GetString("CategoryName"),
                                 (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                                );
                            book = new BookModel(
                                reader.GetInt32("BookID"),
                                reader.GetString("BookTitle"),
                                reader.GetInt32("AuthorID"),
                                reader.GetString("BookImage"),
                                reader.GetInt32("CategoryID"),
                                reader.GetInt32("PublishYear"),
                                reader.GetInt32("Quantity"),
                                (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                                reader.GetInt32("fee_per_day"),
                                categories,
                                 author
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sách: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return book;

        }
        public BookModel GetBookByName(String name)
        {
            BookModel book = null;
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Books " +
                    "JOIN authors ON Authors.AuthorID = Books.AuthorID " +
                    "JOIN Categories c ON c.CategoryID =Books.CategoryID" +
                    " WHERE BookTitle =@name AND Status IN ('Available','OutOf')";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AuthorModel author = new AuthorModel(
                                reader.GetInt32("AuthorID"),
                                reader.GetString("AuthorName"),
                                (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                                );
                            CategoriesModel categories = new CategoriesModel(
                                reader.GetInt32("CategoryID"),
                                reader.GetString("CategoryName"),
                                 (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                                );
                            book = new BookModel(
                                reader.GetInt32("BookID"),
                                reader.GetString("BookTitle"),
                                reader.GetInt32("AuthorID"),
                                reader.GetString("BookImage"),
                                reader.GetInt32("CategoryID"),
                                reader.GetInt32("PublishYear"),
                                reader.GetInt32("Quantity"),
                                (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                                reader.GetInt32("fee_per_day"),
                                categories,
                                 author
                            );
                        }
                    }
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Tìm sách bị lỗi " + ex.Message);
            }

            return book;
        }
        public List<BookModel> GetBooksByCategory(string categoryName)
        {
            List<BookModel> books = new List<BookModel>();
            try
            {
                string query = "SELECT * FROM Books " +
                    "JOIN authors ON Authors.AuthorID = Books.AuthorID " +
                    "JOIN Categories c ON c.CategoryID =Books.CategoryID" +
                    " WHERE c.CategoryName =@categoryName AND Books.Status IN ('Available','OutOf')";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    db.OpenConnection();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AuthorModel author = new AuthorModel(
                                 reader.GetInt32("AuthorID"),
                                 reader.GetString("AuthorName"),
                                 (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("AuthorStatus"))
                                 );
                            CategoriesModel categories = new CategoriesModel(
                                reader.GetInt32("CategoryID"),
                                reader.GetString("CategoryName"),
                                 (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                                );
                            books.Add(

                                new BookModel(
                                reader.GetInt32("BookID"),
                                reader.GetString("BookTitle"),
                                reader.GetInt32("AuthorID"),
                                reader.GetString("BookImage"),
                                reader.GetInt32("CategoryID"),
                                reader.GetInt32("PublishYear"),
                                reader.GetInt32("Quantity"),
                                (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                                reader.GetInt32("fee_per_day"),
                                categories,
                                 author
                            ) ); 
                        }
                    }
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu theo thể loại: " + ex.Message);
            }
            return books;
        }

        public bool AddBook(BookModel book)
        {

            try
            {
                db.OpenConnection();
                string query = "INSERT INTO Books (BookTitle, AuthorID, BookImage, CategoryID, PublishYear, Quantity, fee_per_day, Status) VALUES (@BookTitle, @AuthorID, @BookImage, @CategoryID, @PublishYear, @Quantity, @fee_per_day , @Status)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    cmd.Parameters.AddWithValue("@AuthorID", book.AuthorID);
                    cmd.Parameters.AddWithValue("@BookImage", book.BookImage);
                    cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                    cmd.Parameters.AddWithValue("@PublishYear", book.PublisYear);
                    cmd.Parameters.AddWithValue("@Quantity", book.BookQuantity);
                    cmd.Parameters.AddWithValue("@fee_per_day", book.FeePerDay);
                    cmd.Parameters.AddWithValue("@Status", book.BookStatus.ToString());
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sách: " + ex.Message);
                return false;
            }
        }
        public bool UpdateBook(BookModel book)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Books SET BookTitle=@BookTitle, AuthorID=@AuthorID, BookImage=@BookImage, CategoryID=@CategoryID, PublishYear=@PublishYear, Quantity=@Quantity, Status=@Status, fee_per_day=@fee_per_day WHERE BookID=@BookID";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);
                    cmd.Parameters.AddWithValue("@BookTitle", book.BookTitle);
                    cmd.Parameters.AddWithValue("@AuthorID", book.AuthorID);
                    cmd.Parameters.AddWithValue("@BookImage", book.BookImage);
                    cmd.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                    cmd.Parameters.AddWithValue("@PublishYear", book.PublisYear);
                    cmd.Parameters.AddWithValue("@Quantity", book.BookQuantity);
                    cmd.Parameters.AddWithValue("@Status", book.BookStatus.ToString());
                    cmd.Parameters.AddWithValue("@fee_per_day", book.FeePerDay);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi chỉnh sửa sách " + ex.Message);
                return false;
            }

        }
        public bool DeleteBook(int bookID)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Books SET Status = 'Unavailable' WHERE BookID = @BookID";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật trạng thái sách: " + ex.Message);
                return false;
            }

        }

        public List<BookModel> SearchBooks(string keyword)
        {
            List<BookModel> books = new List<BookModel>();
            try
            {
                db.OpenConnection();

                string query = @"
                SELECT * FROM Books 
                 WHERE BookTitle LIKE @Keyword 
                OR AuthorID IN (
                    SELECT AuthorID FROM Authors WHERE AuthorName LIKE @Keyword
                 ) AND Status IN ('Available','OutOf') ";

                bool isNumber = int.TryParse(keyword, out int bookID);
                if (isNumber)
                {
                    query += " OR BookID = @BookID";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    if (isNumber)
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new BookModel(
                                reader.GetInt32("BookID"),
                                reader.GetString("BookTitle"),
                                reader.GetInt32("AuthorID"),
                                reader.GetString("BookImage"),
                                reader.GetInt32("CategoryID"),
                                reader.GetInt32("PublishYear"),
                                reader.GetInt32("Quantity"),
                                (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                                reader.GetInt32("fee_per_day")
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm sách" + ex.Message);
            }


            db.CloseConnection();
            return books;
        }

        public int GetTotalBookQuantity()
        {
            int cnt = 0;
            try
            {
                db.OpenConnection();
                string query = "SELECT SUM(Quantity) FROM Books";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cnt = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đếm sách: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return cnt;
        }

        public int GenerateNewBookCode()
        {
            int lastID = 0;
            db.OpenConnection();
            string query = "SELECT MAX(BookID) FROM Books";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            var result = cmd.ExecuteScalar();
            lastID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            return lastID;
        }

        public int SetBookInactiveByTitleAndYear(string titleKeyword, int publishYear)
        {
            int rowsAffected = 0;

            try
            {
                db.OpenConnection();
                string query = @"
 UPDATE Books
 SET Status = 'Unavailable'
 WHERE BookTitle LIKE @TitlePattern
   AND PublishYear = @PublishYear
   AND Status = 'Available'";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@TitlePattern", "%" + titleKeyword + "%");
                cmd.Parameters.AddWithValue("@PublishYear", publishYear);

                rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} sách đã được cập nhật thành Inactive.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine($"{rowsAffected} sách đã được xóa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Lỗi khi cập nhật trạng thái sách: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return rowsAffected;
        }

    }
}
