using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class BookBUS
    {
        private BookDAO bookDAO = new BookDAO();

        public List<BookModel> GetAllBooks()
        {
            return bookDAO.GetAllBooks();
        }
        public BookModel GetBookByID(int Id)
        {
            return bookDAO.GetBookByID(Id);
        }
        public BookModel GetBookByName(string name)
        {
            return bookDAO.GetBookByName(name);
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
            return bookDAO.SearchBooks(keyword);
        }

        public int GetTotalBookQuantity()
        {
            return bookDAO.GetTotalBookQuantity();
        }
    }
}