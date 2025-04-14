using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class AuthorBUS
    {
        private AuthorDAO AuthorDAO = new AuthorDAO();
        public List<AuthorModel> GetAllAuthor() {
            return AuthorDAO.GetAllAuthors();
        }
        public AuthorModel GetAuthorByID(int ID)
        {
            return AuthorDAO.GetAuthorByID(ID);
        }
        public bool AddAuthor(AuthorModel author)
        {
            return AuthorDAO.AddAuthor(author);
        }
        public bool UpdateAuthor(AuthorModel author)
        {
            return AuthorDAO.UpdateAuthor(author);
        }
        public bool DeleteAuthor(int ID)
        {
            return AuthorDAO.DeleteAuthor(ID);
        }
        public List<AuthorModel> SearchAuthor(string keyword)
        {
            return AuthorDAO.SearchAuthor(keyword);
        }
    }
}
