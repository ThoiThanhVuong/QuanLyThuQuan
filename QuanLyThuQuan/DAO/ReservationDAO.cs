using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DAO
{
    class ReservationDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<ReservationModel> GetAllReservationsWithItems()
        {
            List<ReservationModel> reservations = new List<ReservationModel>();
            Dictionary<int, ReservationModel> reservationMap = new Dictionary<int, ReservationModel>();

            try
            {
                db.OpenConnection();
                string query = @"
                    SELECT r.*, ri.ItemID, ri.BookID, ri.DeviceID, ri.Amount
                    FROM Reservation r
                    LEFT JOIN ReservationItems ri ON r.ReservationID = ri.ReservationID 
                    WHERE r.Status ='Pending'
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int reservationID = reader.GetInt32("ReservationID");

                        if (!reservationMap.ContainsKey(reservationID))
                        {
                            var reservation = new ReservationModel
                            {
                                ReservationID = reservationID,
                                MemberID = reader.GetInt32("MemberID"),
                                StartTime = reader.GetDateTime("StartTime"),
                                EndTime = reader.GetDateTime("EndTime"),
                                Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status")),
                                Items = new List<ReservationItemModel>()
                            };
                            reservationMap[reservationID] = reservation;
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("ItemID")))
                        {
                            var item = new ReservationItemModel
                            {
                                ItemID = reader.GetInt32("ItemID"),
                                ReservationID = reservationID,
                                BookID = reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                                DeviceID = reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                                Amount = reader.GetInt32("Amount")
                            };

                            reservationMap[reservationID].Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetAllReservationsWithItems: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            reservations.AddRange(reservationMap.Values);
            return reservations;
        }
        public ReservationModel GetReservationByID(int ID)
        {
            ReservationModel reservation = null;

            try
            {
                db.OpenConnection();
                string query = @"
                    SELECT r.*, ri.ItemID, ri.BookID, ri.DeviceID, ri.Amount
                    FROM Reservation r
                    LEFT JOIN ReservationItems ri ON r.ReservationID = ri.ReservationID
                    WHERE r.ReservationID = @ID
                ";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reservation == null)
                            {
                                reservation = new ReservationModel
                                {
                                    ReservationID = reader.GetInt32("ReservationID"),
                                    MemberID = reader.GetInt32("MemberID"),
                                    StartTime = reader.GetDateTime("StartTime"),
                                    EndTime = reader.GetDateTime("EndTime"),
                                    Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status")),
                                    Items = new List<ReservationItemModel>()
                                };
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("ItemID")))
                            {
                                var item = new ReservationItemModel
                                {
                                    ItemID = reader.GetInt32("ItemID"),
                                    ReservationID = reservation.ReservationID,
                                    BookID = reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                                    DeviceID = reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                                    Amount = reader.GetInt32("Amount")
                                };

                                reservation.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetReservationByID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return reservation;
        }
        public bool AddReservationWithItems(ReservationModel reservation)
        {
            try
            {
                db.OpenConnection();
                string query = @"
                    INSERT INTO Reservation (MemberID, StartTime, EndTime, Status)
                    VALUES (@MemberID, @StartTime, @EndTime, @Status);
                    SELECT LAST_INSERT_ID();
                ";

                int reservationID;
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", reservation.MemberID);
                    cmd.Parameters.AddWithValue("@StartTime", reservation.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", reservation.EndTime);
                    cmd.Parameters.AddWithValue("@Status", reservation.Status.ToString());

                    reservationID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (var item in reservation.Items)
                {
                    string itemQuery = @"
                        INSERT INTO ReservationItems (ReservationID, BookID, DeviceID, Amount)
                        VALUES (@ReservationID, @BookID, @DeviceID, @Amount);
                    ";

                    using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, db.Connection))
                    {
                        itemCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        itemCmd.Parameters.AddWithValue("@BookID", item.BookID ?? (object)DBNull.Value);
                        itemCmd.Parameters.AddWithValue("@DeviceID", item.DeviceID ?? (object)DBNull.Value);
                        itemCmd.Parameters.AddWithValue("@Amount", item.Amount);
                        itemCmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm đặt trước: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public bool DeleteReservationWithItems(int reservationID)
        {
            try
            {
                db.OpenConnection();

                string deleteItemsQuery = "DELETE FROM ReservationItems WHERE ReservationID = @ReservationID;";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteItemsQuery, db.Connection))
                {
                    deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    deleteCmd.ExecuteNonQuery();
                }

                string deleteReservationQuery = "DELETE FROM Reservation WHERE ReservationID = @ReservationID;";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteReservationQuery, db.Connection))
                {
                    deleteCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    deleteCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa đặt trước: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public int  ConfirmReservationAndTransfer(int reservationID)
        {
            int transactionID = -1;

            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand("TransferConfirmedReservations", db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_ReservationID", reservationID);
                    cmd.Parameters.Add(new MySqlParameter("@p_TransactionID", MySqlDbType.Int32));
                    cmd.Parameters["@p_TransactionID"].Direction = System.Data.ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    transactionID = Convert.ToInt32(cmd.Parameters["@p_TransactionID"].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ConfirmReservationAndTransfer: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return transactionID;
        }

    }

}
