using System;

namespace QuanLyThuQuan.Model
{
    public class ReviewModel
    {
        private int reviewID;
        private int memberID;
        private int? bookID;
        private int? deviceID;
        private int rating;
        private string reviewText;
        private DateTime reviewDate;

        public int ReviewID { get => reviewID; set => reviewID = value; }
        public int MemberID { get => memberID; set => memberID = value; }
        public int? BookID { get => bookID; set => bookID = value; }
        public int? DeviceID { get => deviceID; set => deviceID = value; }
        public int Rating { get => rating; set => rating = value; }
        public string ReviewText { get => reviewText; set => reviewText = value; }
        public DateTime ReviewDate { get => reviewDate; set => reviewDate = value; }

        public ReviewModel() { }

        public ReviewModel(int reviewID, int memberID, int? bookID, int? deviceID, int rating, string reviewText, DateTime reviewDate)
        {
            this.reviewID = reviewID;
            this.memberID = memberID;
            this.bookID = bookID;
            this.deviceID = deviceID;
            this.rating = rating;
            this.reviewText = reviewText;
            this.reviewDate = reviewDate;
        }
    }
}
