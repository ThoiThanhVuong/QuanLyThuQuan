using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    internal class TempDataReservationItemDAO
    {
        private ConnectDB db = new ConnectDB();

        public TempDataReservationItemDAO()
        {
            if (db == null)
                db = new ConnectDB();
        }

        public TempDataReservationItemDAO(ConnectDB dbConnect)
        {
            this.db = dbConnect;
        }
        // READ all
        public List<TempDataItemReservationModel> GetAll()
        {
            string query = "SELECT * FROM ReservationItems";
            List<TempDataItemReservationModel> list = new List<TempDataItemReservationModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader dataReader = myCmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            TempDataItemReservationModel item = new TempDataItemReservationModel();
                            item.reservationID = dataReader.GetInt16("ReservationID");
                            item.itemID = dataReader.GetInt16("ItemID");
                            item.bookID = dataReader.IsDBNull(dataReader.GetOrdinal("BookID")) ? (Int16?)null : dataReader.GetInt16("BookID");
                            item.deviceID = dataReader.IsDBNull(dataReader.GetOrdinal("DeviceID")) ? (Int16?)null : dataReader.GetInt16("DeviceID");
                            item.amount = dataReader.GetInt16("Amount");
                            list.Add(item);
                        }
                    }
                    return list;
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

        // READ wit specific reservationID
        public List<TempDataItemReservationModel> GetByReservationID(string reservationID)
        {
            string query = "SELECT * FROM ReservationItems WHERE ReservationID = @ID";
            List<TempDataItemReservationModel> list = new List<TempDataItemReservationModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", reservationID);
                        using (MySqlDataReader dataReader = myCmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                TempDataItemReservationModel item = new TempDataItemReservationModel();
                                item.reservationID = dataReader.GetInt16("ReservationID");
                                item.itemID = dataReader.GetInt16("ItemID");
                                item.bookID = dataReader.IsDBNull(dataReader.GetOrdinal("BookID")) ? (Int16?)null : dataReader.GetInt16("BookID");
                                item.deviceID = dataReader.IsDBNull(dataReader.GetOrdinal("DeviceID")) ? (Int16?)null : dataReader.GetInt16("DeviceID");
                                item.amount = dataReader.GetInt16("Amount");
                                list.Add(item);
                            }
                        }
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        //READ -> Specific reservationItem 
        public TempDataItemReservationModel GetByID(string id)
        {
            TempDataItemReservationModel reservationItem = new TempDataItemReservationModel();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            {
                Console.WriteLine("Success");
                string query = "SELECT * FROM ReservationItems WHERE ReservationID = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                        {
                            if (dtReader.Read())
                            {
                                reservationItem.itemID = dtReader.GetInt32("ItemID");
                                reservationItem.reservationID = dtReader.GetInt32("ReservationID");
                                reservationItem.bookID = dtReader.IsDBNull(dtReader.GetOrdinal("BookID")) ? (Int16?)null : dtReader.GetInt16("BookID");
                                reservationItem.deviceID = dtReader.IsDBNull(dtReader.GetOrdinal("DeviceID")) ? (Int16?)null : dtReader.GetInt16("DeviceID");
                                reservationItem.amount = dtReader.GetInt16("Amount");
                            }
                        }
                        return reservationItem;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    return null;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        // CREATE
        public bool Insert(TempDataItemReservationModel item)
        {
            string query = "INSERT INTO ReservationItems (ItemID, ReservationID, BookID, DeviceID, Amount)\nVALUES (@ItemID, @ReservationID, @BookID, @DeviceID, @Amount)";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ItemID", item.itemID);
                        myCmd.Parameters.AddWithValue("@ReservationID", item.reservationID);
                        myCmd.Parameters.AddWithValue("@BookID", item.bookID);
                        myCmd.Parameters.AddWithValue("@DeviceID", item.deviceID);
                        myCmd.Parameters.AddWithValue("@Amount", item.amount);
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

        // UPDATE
        public bool Update(TempDataItemReservationModel item)
        {
            string query = "UPDATE reservationitem\n " +
                "SET BookID = @bookID, DeviceID = @deviceID, Amount = @amount\n" +
                "WHERE ReservationID = @reservationID AND ItemID = @itemID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@bookID", item.bookID);
                        myCmd.Parameters.AddWithValue("@deviceID", item.deviceID);
                        myCmd.Parameters.AddWithValue("@amount", item.amount);
                        myCmd.Parameters.AddWithValue("@reservationID", item.reservationID);
                        myCmd.Parameters.AddWithValue("@itemID", item.itemID);
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

        // DELETE
        public bool Delete(string reservationID, string itemID)
        {
            string query = @"
                DELETE FROM ReservationItems
                WHERE ReservationID = @reservationID AND ItemID = @itemID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@reservationID", reservationID);
                        cmd.Parameters.AddWithValue("@itemID", itemID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Delete Error: " + ex.Message);
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
