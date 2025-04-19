namespace QuanLyThuQuan.Model
{
    public class CategoriesModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ActivityStatus CategoryStatus { get; set; }
        public CategoriesModel()
        {

        }

        public CategoriesModel(string categoryName, ActivityStatus categoryStatus)
        {
            CategoryName = categoryName;
            CategoryStatus = categoryStatus;
        }

        public CategoriesModel(int categoryID, string categoryName, ActivityStatus categoryStatus)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            CategoryStatus = categoryStatus;
        }

        public override string ToString()
        {
            return $"CategoryID:{CategoryID} , CategoryName: {CategoryName}";
        }
    }
}
