using System.Net;
using System.Security.Policy;

namespace QuanLyThuQuan.Model
{
    public class AuthorModel
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public ActivityStatus AuthorStatus { get; set; }
        public AuthorModel()
        {

        }

        public AuthorModel(int authorID, string authorName, ActivityStatus authorStatus)
        {
            AuthorID = authorID;
            AuthorName = authorName;
            AuthorStatus = authorStatus;
        }

        public override string ToString()
        {
            return $"AuthorID:{AuthorID} , AuthorName: {AuthorName}";
        }
    }
}
