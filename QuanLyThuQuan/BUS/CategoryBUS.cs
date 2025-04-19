using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class CategoryBUS
    {
        private CategoriesDAO categoriesDAO = new CategoriesDAO();
        public List<CategoriesModel> GetAllCategories()
        {
            return categoriesDAO.GetAllCategories();
        }
        public CategoriesModel GetCategoryByID(int ID)
        {
            return categoriesDAO.GetCategoryByID(ID);
        }
        public int GetCategoryIDByName(string name)
        {
            return categoriesDAO.GetCategoryIDByName(name);
        }
        public bool AddCategory(CategoriesModel category)
        {
            return categoriesDAO.AddCategory(category);
        }
        public bool UpdateCategory(CategoriesModel category)
        {
            return categoriesDAO.UpdateCategory(category);
        }
        public bool DeleteCategory(int categoryId)
        {
            return categoriesDAO.DeleteCategory(categoryId);
        }
        public List<CategoriesModel> SearchCategories(string keyword)
        {
            return categoriesDAO.SearchCategories(keyword);
        }
        public int GenerateNewCategoryCode()
        {
            return categoriesDAO.GenerateNewCategoryCode() + 1;
        }
        public bool CheckAuthorExists(string categoryName)
        {
            return categoriesDAO.CheckAuthorExists(categoryName);
        }
    }
}
