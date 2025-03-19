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
        public int AuthorID { get; set; }
        public string BookImage { get; set; }
        public int CategoryID { get; set; }
        public int PublisYear { get; set; }
        public int BookQuantity { get; set; }
        public ProductStatus BookStatus { get; set; }

        public CategoriesModel Category { get; set; }
        public AuthorModel Author { get; set; }
        public BookModel()
        {
            
        }

        public BookModel(int bookID, string bookTitle, int authorID, string bookImage, int categoryID, int publisYear, int bookQuantity, ProductStatus bookStatus)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            AuthorID = authorID;
            BookImage = bookImage;
            CategoryID = categoryID;
            PublisYear = publisYear;
            BookQuantity = bookQuantity;
            BookStatus = bookStatus;
        }

        public BookModel(int bookID, string bookTitle, int authorID, string bookImage, int categoryID, int publisYear, int bookQuantity, ProductStatus bookStatus, CategoriesModel category, AuthorModel author) : this(bookID, bookTitle, authorID, bookImage, categoryID, publisYear, bookQuantity, bookStatus)
        {
            Category = category;
            Author = author;
        }
    }
}
