using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DAO
{
    class ReviewDao
    {
        private ConnectDB db = new ConnectDB();

        public List<ReviewModel> getAllReviews()
        {
            List<ReviewModel> reviews = new List<ReviewModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Reviews";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Add(new ReviewModel(
                            reader.GetInt32("ReviewID"),
                            reader.GetInt32("MemberID"),
                            reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                            reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                            reader.GetInt32("Rating"),
                            reader.GetString("ReviewText"),
                            reader.GetDateTime("ReviewDate")
                    ));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving reviews: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return reviews;
        }

        public ReviewModel GetReviewByID(int reviewID)
        {
            ReviewModel review = null;
            try
            {
                db.OpenConnection();
                string query = $"SELECT * FROM Reviews WHERE ReviewID = {reviewID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            review = new ReviewModel(
                                reader.GetInt32("ReviewID"),
                                reader.GetInt32("MemberID"),
                                reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                                reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                                reader.GetInt32("Rating"),
                                reader.GetString("ReviewText"),
                                reader.GetDateTime("ReviewDate")
                            );
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving review: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return review;
        }
        public bool AddReview(ReviewModel review)
        {
            try
            {
                db.OpenConnection();
                string query = $"INSERT INTO Reviews (MemberID, BookID, DeviceID, Rating, ReviewText, ReviewDate) VALUES ({review.MemberID}, {review.BookID}, {review.DeviceID}, {review.Rating}, '{review.ReviewText}', '{review.ReviewDate.ToString("yyyy-MM-dd")}')";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding review: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool UpdateReview(ReviewModel review)
        {
            var (reviewID, memberID, bookID, deviceID, rating, reviewText, reviewDate) = review;
            try
            {
                db.OpenConnection();
                string query = $"UPDATE Reviews SET MemberID = {memberID}, BookID = {bookID}, DeviceID = {deviceID}, Rating = {rating}, ReviewText = '{reviewText}', ReviewDate = '{reviewDate.ToString("yyyy-MM-dd")}' WHERE ReviewID = {reviewID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating review: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool DeleteReview(int reviewID)
        {
            try
            {
                db.OpenConnection();
                string query = $"DELETE FROM Reviews WHERE ReviewID = {reviewID}";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting review: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        // public List<ReviewModel> SearchReviews();

    }
}