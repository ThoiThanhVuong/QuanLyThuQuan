using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.BUS
{
    class BookBUS
    {
        private BookDAO bookDAO = new BookDAO();

        public List<BookModel> GetAllBooks()
        {
            return bookDAO.GetAllBooks().ToList();
        }
        public BookModel GetBookByID(int Id)
        {
            BookModel book = bookDAO.GetBookByID(Id);
            if (book == null)
                return null;
            return new BookModel(book.BookID, book.BookTitle, book.AuthorID, book.BookImage, book.CategoryID, book.PublisYear, book.BookQuantity, book.BookStatus, book.FeePerDay);
        }
        public BookModel GetBookByName(string name)
        {
            BookModel book = bookDAO.GetBookByName(name);
            if (book == null)
                return null;
            return new BookModel(book.BookID, book.BookTitle, book.AuthorID, book.BookImage, book.CategoryID, book.PublisYear, book.BookQuantity, book.BookStatus, book.FeePerDay);
        }
        public bool AddBook(BookModel book)
        {
            return bookDAO.AddBook(book);
        }

        public bool UpdateBook(BookModel book)
        {
            return bookDAO.UpdateBook(book);
        }

        public bool DeleteBook(int bookID)
        {
            return bookDAO.DeleteBook(bookID);
        }

        public List<BookModel> SearchBooks(string keyword)
        {
            if (string.IsNullOrEmpty(keyword.Trim()))
                return (bookDAO.GetAllBooks()).ToList();
            return (bookDAO.SearchBooks(keyword)).ToList();
        }

        public int GetTotalBookQuantity()
        {
            return bookDAO.GetTotalBookQuantity();
        }
    }
}