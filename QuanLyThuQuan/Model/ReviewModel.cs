using System;

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

        public ReviewModel(int reviewID, int memberID, int? bookID, int? deviceID, int rating, string reviewText, DateTime reviewDate)
        {
            ReviewID = reviewID;
            MemberID = memberID;
            BookID = bookID;
            DeviceID = deviceID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }

        public ReviewModel(int reviewID, int memberID, int? bookID, int? deviceID, int rating, string reviewText, DateTime reviewDate, MemberModel member, BookModel book, DeviceModel device)
        : this(reviewID, memberID, bookID, deviceID, rating, reviewText, reviewDate)
        {
            Member = member;
            Book = book;
            Device = device;
        }
    }
}
