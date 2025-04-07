namespace QuanLyThuQuan.Model
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public AuthorModel()
        {

        }

        public AuthorModel(int authorID, string authorName)
        {
            AuthorID = authorID;
            AuthorName = authorName;
        }
        public override string ToString()
        {
            return $"AuthorID:{AuthorID} , AuthorName: {AuthorName}";
        }
    }
}
