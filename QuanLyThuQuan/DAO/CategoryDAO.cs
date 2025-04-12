using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    public class CategoriesDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<CategoriesModel> GetAllCategories()
        {
            List<CategoriesModel> list = new List<CategoriesModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Categories WHERE CategoryStatus='Active' ";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new CategoriesModel(
                        reader.GetInt32("CategoryID"),
                        reader.GetString("CategoryName"),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                    ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách thể loại: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }
        public CategoriesModel GetCategoryByID(int ID)
        {
            CategoriesModel category = null;
            try {
                db.OpenConnection();
                string query = "SELECT * FROM Categories WHERE CategoryID=@ID AND CategoryStatus='Active'";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("ID", ID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    category = new CategoriesModel(
                         reader.GetInt32("CategoryID"),
                         reader.GetString("CategoryName"),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                        );
                }
            
            }catch(Exception ex)
            {
                Console.WriteLine("lỗi khi lấy dữ liệu " + ex.Message);
            }
            db.CloseConnection();
            return category;
        }
        public bool AddCategory(CategoriesModel category)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO Categories (CategoryName, CategoryStatus) VALUES (@name, @status)";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@name", category.CategoryName);
                cmd.Parameters.AddWithValue("@status", category.CategoryStatus.ToString());

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm thể loại: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdateCategory(CategoriesModel category)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Categories SET CategoryName = @name, CategoryStatus = @status WHERE CategoryID = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", category.CategoryID);
                cmd.Parameters.AddWithValue("@name", category.CategoryName);
                cmd.Parameters.AddWithValue("@status", category.CategoryStatus.ToString());

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật thể loại: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            try
            {
                db.OpenConnection();
                string query = "DELETE FROM Categories WHERE CategoryID = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", categoryId);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa thể loại: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public List<CategoriesModel> SearchCategories(string keyword)
        {
            List<CategoriesModel> list = new List<CategoriesModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Categories WHERE CategoryName LIKE @keyword AND CategoryStatus='Active' ";
                bool isNumber = int.TryParse(keyword, out int categoryID);
                if (isNumber)
                {
                    query += " OR CategoryID=@CategoryID";
                }
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                if (isNumber)
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new CategoriesModel(
                        reader.GetInt32("CategoryID"),
                        reader.GetString("CategoryName"),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("CategoryStatus"))
                    ));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tìm kiếm thể loại: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return list;
        }
    }
}
