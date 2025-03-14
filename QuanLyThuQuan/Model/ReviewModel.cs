using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class ReviewModel
    {
        public int ReviewID { get; set; }
        public int MemberID { get; set; }
        public int? BookID { get; set; }
        public int? DeviceID { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

        // Navigation Properties
        public MemberModel Member { get; set; }
        public BookModel Book { get; set; }
        public DeviceModel Device { get; set; }
        public ReviewModel()
        {
            
        }

        public ReviewModel(int reviewID, int memberID, int? bookID, int? deviceID, int rating, string reviewText, DeviceModel device)
        {
            ReviewID = reviewID;
            MemberID = memberID;
            BookID = bookID;
            DeviceID = deviceID;
            Rating = rating;
            ReviewText = reviewText;
            Device = device;
        }

        public ReviewModel(int reviewID, int memberID, int? bookID, int? deviceID, int rating, string reviewText, DateTime reviewDate, MemberModel member, BookModel book, DeviceModel device)
        {
            ReviewID = reviewID;
            MemberID = memberID;
            BookID = bookID;
            DeviceID = deviceID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
            Member = member;
            Book = book;
            Device = device;
        }
    }
}
