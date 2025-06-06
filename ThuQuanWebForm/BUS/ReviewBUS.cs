using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using System.Collections.Generic;

namespace ThuQuanWebForm.BUS
{
    class ReviewBUS
    {
        private ReviewDAO reviewDao = new ReviewDAO();

        public List<ReviewModel> GetAllReviews()
        {
            return reviewDao.GetAllReviews();
        }

        public int GetMaxReviewID()
        {
            return reviewDao.GetMaxReviewID();
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