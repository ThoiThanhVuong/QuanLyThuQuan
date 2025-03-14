using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
  
    class BookModel
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string BookImage { get; set; }
        public string Category { get; set; }
        public int PublisYear { get; set; }
        public int BookQuantity { get; set; }
        public ProductStatus BookStatus { get; set; }
        public BookModel()
        {
            
        }

        public BookModel(int bookID, string bookTitle, string author, string bookImage, string category, int publisYear, int bookQuantity, ProductStatus bookStatus)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            Author = author;
            BookImage = bookImage;
            Category = category;
            PublisYear = publisYear;
            BookQuantity = bookQuantity;
            BookStatus = bookStatus;
        }
    }
}
