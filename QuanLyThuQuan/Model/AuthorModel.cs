using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class AuthorModel
    {
        public int AuthorID { get; set; }
        public int AuthorName { get; set; }
        public AuthorModel()
        {
            
        }

        public AuthorModel(int authorID, int authorName)
        {
            AuthorID = authorID;
            AuthorName = authorName;
        }
    }
}
