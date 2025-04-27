using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class AuthorBUS
    {
        private AuthorDAO AuthorDAO = new AuthorDAO();
        public List<AuthorModel> GetAllAuthor()
        {
            return AuthorDAO.GetAllAuthors();
        }
        public AuthorModel GetAuthorByID(int ID)
        {
            return AuthorDAO.GetAuthorByID(ID);
        }
        public int GetAuthorByName(string name)
        {
            return AuthorDAO.GetAuthorIDByName(name);
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
        public int GenerateNewAuthorCode()
        {
            return AuthorDAO.GenerateNewAuthorCode() + 1;
        }
        public bool CheckAuthorExists(string authorName)
        {
            return AuthorDAO.CheckAuthorExists(authorName);
        }
    }
}
