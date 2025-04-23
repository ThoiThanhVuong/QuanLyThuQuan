using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    internal class TempDataReservationDAO
    {
        private ConnectDB db = new ConnectDB();

        public TempDataReservationDAO()
        {
            if (db == null)
                db = new ConnectDB();
        }

        // READ - Lấy tất cả Reservation
        public List<TempDataReservationModel> GetAll()
        {
            List<TempDataReservationModel> reservationList = new List<TempDataReservationModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                string query = "SELECT * FROM Reservation";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = myCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TempDataReservationModel reservation = new TempDataReservationModel();
                            reservation.reservationID = reader.GetInt16("ReservationID");
                            reservation.memberID = reader.GetInt16("MemberID");
                            reservation.startTime = reader.GetDateTime("StartTime");
                            reservation.endTime = reader.GetDateTime("EndTime");
                            reservation.status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status"));
                            reservationList.Add(reservation);
                        }
                    }
                    return reservationList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // READ - Lấy reservation theo ID hoặc điều kiện cụ thể
        public TempDataReservationModel GetByID(string id, string condition)
        {
            TempDataReservationModel reservation = new TempDataReservationModel();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                if (!ValidateConditionServices.GetInstance().IsValidForReservation(condition))
                {
                    Console.WriteLine("Invalid condition.");
                    return null;
                }

                string query = $"SELECT * FROM Reservation WHERE {condition} = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader reader = myCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reservation.reservationID = reader.GetInt16("ReservationID");
                                reservation.memberID = reader.GetInt16("MemberID");
                                reservation.startTime = reader.GetDateTime("StartTime");
                                reservation.endTime = reader.GetDateTime("EndTime");
                                reservation.status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status"));
                            }
                        }
                        return reservation;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // READ - Lấy reservation theo ID hoặc điều kiện cụ thể
        public List<TempDataReservationModel> GetByStatus(ReservationStatus statusType)
        {
            List<TempDataReservationModel> list = new List<TempDataReservationModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                string query = $"SELECT * FROM Reservation WHERE Status = @Status";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@Status", statusType.ToString());
                        using (MySqlDataReader reader = myCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TempDataReservationModel reservation = new TempDataReservationModel();
                                reservation.reservationID = reader.GetInt16("ReservationID");
                                reservation.memberID = reader.GetInt16("MemberID");
                                reservation.startTime = reader.GetDateTime("StartTime");
                                reservation.endTime = reader.GetDateTime("EndTime");
                                reservation.status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), reader.GetString("Status"));
                                list.Add(reservation);
                            }
                        }
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return list;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // CREATE - Thêm mới reservation
        public bool Insert(TempDataReservationModel reservation)
        {
            string query = @"INSERT INTO Reservation 
                (MemberID, ReservationDate, StartTime, EndTime, Status) 
                VALUES 
                (@MemberID, @StartTime, @EndTime, @Status)";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@MemberID", reservation.memberID);
                        myCmd.Parameters.AddWithValue("@StartTime", reservation.startTime);
                        myCmd.Parameters.AddWithValue("@EndTime", reservation.endTime);
                        myCmd.Parameters.AddWithValue("@Status", reservation.status.ToString());
                        myCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // UPDATE - Cập nhật reservation theo ID
        public bool Update(TempDataReservationModel reservation)
        {
            string query = @"UPDATE Reservation 
                SET MemberID = @MemberID, StartTime = @StartTime, EndTime = @EndTime, Status = @Status 
                WHERE ReservationID = @ReservationID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ReservationID", reservation.reservationID);
                        myCmd.Parameters.AddWithValue("@MemberID", reservation.memberID);
                        myCmd.Parameters.AddWithValue("@StartTime", reservation.startTime);
                        myCmd.Parameters.AddWithValue("@EndTime", reservation.endTime);
                        myCmd.Parameters.AddWithValue("@Status", reservation.status.ToString());
                        myCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // DELETE - Xoá reservation theo ID
        public bool Delete(string reservationID)
        {
            string query = "DELETE FROM Reservation WHERE ReservationID = @ReservationID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        return myCmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }
    }
}
