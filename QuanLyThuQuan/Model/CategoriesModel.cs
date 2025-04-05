namespace QuanLyThuQuan.Model
{
   public class CategoriesModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public CategoriesModel()
        {

        }

        public CategoriesModel(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
        public override string ToString()
        {
            return $"CategoryID:{CategoryID} , CategoryName: {CategoryName}";
        }
    }
}
