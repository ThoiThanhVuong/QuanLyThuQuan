using System.Collections.Generic;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;

namespace QuanLyThuQuan.BUS
{
    class ReviewBUS
    {
        private ReviewDao reviewDao = new ReviewDao();

        public List<ReviewModel> GetAllReviews()
        {
            return reviewDao.getAllReviews();
        }

        public ReviewModel GetReviewByID(int reviewID)
        {
            return reviewDao.GetReviewByID(reviewID);
        }

        public bool AddReview(ReviewModel review)
        {
            return reviewDao.AddReview(review);
        }

        public bool UpdateReview(ReviewModel review)
        {
            return reviewDao.UpdateReview(review);
        }

        public bool DeleteReview(int reviewID)
        {
            return reviewDao.DeleteReview(reviewID);
        }
    }
}