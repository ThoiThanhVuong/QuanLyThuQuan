using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThuQuan.DAO
{
    public class ReviewDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<ReviewModel> GetAllReviews()
        {
            string query = "SELECT * FROM Review";
            DataTable result = db.ExecuteSelectQuery(query);
            List<ReviewModel> reviews = new List<ReviewModel>();

            foreach (DataRow row in result.Rows)
            {
                int? bookId = null;
                int? deviceId = null;

                if (row["BookID"] != DBNull.Value)
                {
                    bookId = Convert.ToInt32(row["BookID"]);
                }
                if (row["DeviceID"] != DBNull.Value)
                {
                    deviceId = Convert.ToInt32(row["DeviceID"]);
                }

                ReviewModel review = new ReviewModel(
                    Convert.ToInt32(row["ReviewID"]),
                    Convert.ToInt32(row["MemberID"]),
                    bookId,
                    deviceId,
                    Convert.ToInt32(row["Rating"]),
                    row["ReviewText"].ToString(),
                    Convert.ToDateTime(row["ReviewDate"])
                );
                reviews.Add(review);
            }
            return reviews;
        }

        public int GetMaxReviewID()
        {
            string query = "SELECT MAX(ReviewID) FROM Review";
            object result = db.ExecuteScalar(query);

            if (result == DBNull.Value || result == null)
                return 1;

            return Convert.ToInt32(result) + 1;
        }

        public ReviewModel GetReviewByID(int reviewID)
        {
            string query = "SELECT * FROM Review WHERE ReviewID = @reviewID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@reviewID", reviewID }
            };

            DataTable result = db.ExecuteSelectQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                int? bookId = null;
                int? deviceId = null;

                if (row["BookID"] != DBNull.Value)
                {
                    bookId = Convert.ToInt32(row["BookID"]);
                }
                if (row["DeviceID"] != DBNull.Value)
                {
                    deviceId = Convert.ToInt32(row["DeviceID"]);
                }

                return new ReviewModel(
                    Convert.ToInt32(row["ReviewID"]),
                    Convert.ToInt32(row["MemberID"]),
                    bookId,
                    deviceId,
                    Convert.ToInt32(row["Rating"]),
                    row["ReviewText"].ToString(),
                    Convert.ToDateTime(row["ReviewDate"])
                );
            }
            return null;
        }

        public bool UpdateReview(ReviewModel review)
        {
            string query = "UPDATE Review SET MemberID = @MemberID, BookID = @BookID, " +
                          "DeviceID = @DeviceID, Rating = @Rating, ReviewText = @ReviewText, " +
                          "ReviewDate = @ReviewDate WHERE ReviewID = @ReviewID";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@ReviewID", review.ReviewID },
                { "@MemberID", review.MemberID },
                { "@BookID", review.BookID.HasValue ? (object)review.BookID.Value : DBNull.Value },
                { "@DeviceID", review.DeviceID.HasValue ? (object)review.DeviceID.Value : DBNull.Value },
                { "@Rating", review.Rating },
                { "@ReviewText", review.ReviewText },
                { "@ReviewDate", review.ReviewDate }
            };

            return db.ExecuteUpdateQuery(query, parameters);
        }

        public bool DeleteReview(int reviewID)
        {
            string query = "DELETE FROM Review WHERE ReviewID = @ReviewID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@ReviewID", reviewID }
            };

            return db.ExecuteDeleteQuery(query, parameters);
        }

        public bool AddReview(ReviewModel review)
        {
            string query = "INSERT INTO Review (ReviewID, MemberID, BookID, DeviceID, Rating, ReviewText, ReviewDate) " +
                          "VALUES (@ReviewID, @MemberID, @BookID, @DeviceID, @Rating, @ReviewText, @ReviewDate)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@ReviewID", review.ReviewID },
                { "@MemberID", review.MemberID },
                { "@BookID", review.BookID.HasValue ? (object)review.BookID.Value : DBNull.Value },
                { "@DeviceID", review.DeviceID.HasValue ? (object)review.DeviceID.Value : DBNull.Value },
                { "@Rating", review.Rating },
                { "@ReviewText", review.ReviewText },
                { "@ReviewDate", review.ReviewDate }
            };

            return db.ExecuteInsertQuery(query, parameters);
        }
    }
}