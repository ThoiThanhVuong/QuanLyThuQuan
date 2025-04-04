using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.AppConfig;

namespace QuanLyThuQuan.DAO
{
    class BookDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Books";
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
            db.CloseConnection();
            return books;
        }

        public bool AddBook(BookModel book)
        {
            db.OpenConnection();
            string query = "INSERT INTO Books (BookTitle, AuthorID, BookImage, CategoryID, PublishYear, Quantity, Status, fee_per_day) VALUES (@BookTitle, @AuthorID, @BookImage, @CategoryID, @PublishYear, @Quantity, @Status, @fee_per_day)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
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
        public bool UpdateBook(BookModel book)
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
        public bool DeleteBook(int bookID)
        {
            db.OpenConnection();
            string query = "DELETE FROM Books WHERE BookID=@BookID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@BookID", bookID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }
        public List<BookModel> SearchBooks(string keyword)
        {
            List<BookModel> books = new List<BookModel>();
            db.OpenConnection();

            string query = @"
            SELECT * FROM Books 
            WHERE BookTitle LIKE @Keyword 
                OR AuthorID IN (
                    SELECT AuthorID FROM Authors WHERE AuthorName LIKE @Keyword
                 )";

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

            db.CloseConnection();
            return books;
        }


    }
}
