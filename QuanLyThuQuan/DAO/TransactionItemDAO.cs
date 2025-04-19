using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    class TransactionItemDAO
    {
        private readonly IDBConnection db;
        private readonly ConnectDB dbConnect;
        public TransactionItemDAO(IDBConnection dbConnection)
        {
            this.db = dbConnection;
        }

        public TransactionItemDAO(ConnectDB dbConnect)
        {
            this.dbConnect = dbConnect;
        }

        // READ
        public List<TransactionItemModel> GetAll()
        {
            List<TransactionItemModel> transactionItemList = new List<TransactionItemModel>();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                Console.WriteLine("Success");
                string query = "SELECT * FROM Transactionitems";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                    {
                        while (dtReader.Read())
                        {
                            TransactionItemModel transactionItem = new TransactionItemModel();
                            transactionItem.ItemID = dtReader.GetInt32("ItemID");
                            transactionItem.TransactionID = dtReader.GetInt32("TransactionID");
                            // just get Int16 for save memory
                            transactionItem.BookID = dtReader.IsDBNull(dtReader.GetOrdinal("BookID")) ? (Int16?)null : dtReader.GetInt16("BookID");
                            transactionItem.DeviceID = dtReader.IsDBNull(dtReader.GetOrdinal("DeviceID")) ? (Int16?)null : dtReader.GetInt16("DeviceID");
                            transactionItem.Amount = dtReader.GetInt16("Amount");
                            transactionItemList.Add(transactionItem);
                        }
                    }
                    dbConnect.CloseConnection();
                    return transactionItemList;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return null;
                }
            }
        }

        // READ -> List of specific transactionID
        public List<TransactionItemModel> GetByTransactionID(string transactionID)
        {
            List<TransactionItemModel> transactionItemList = new List<TransactionItemModel>();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                Console.WriteLine("Success");
                string query = "SELECT * FROM Transactionitems WHERE TransactionID = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", transactionID);
                        using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                        {
                            while (dtReader.Read())
                            {
                                TransactionItemModel transactionItem = new TransactionItemModel();
                                transactionItem.ItemID = dtReader.GetInt32("ItemID");
                                transactionItem.TransactionID = dtReader.GetInt32("TransactionID");
                                // just get Int16 for save memory
                                transactionItem.BookID = dtReader.IsDBNull(dtReader.GetOrdinal("BookID")) ? (Int16?)null : dtReader.GetInt16("BookID");
                                transactionItem.DeviceID = dtReader.IsDBNull(dtReader.GetOrdinal("DeviceID")) ? (Int16?)null : dtReader.GetInt16("DeviceID");
                                transactionItem.Amount = dtReader.GetInt16("Amount");
                                transactionItemList.Add(transactionItem);
                            }
                        }
                        dbConnect.CloseConnection();
                        return transactionItemList;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return null;
                }
            }
        }

        //Read -> Specific TransactionItem 
        public TransactionItemModel GetByID(string id)
        {
            TransactionItemModel transactionItem = new TransactionItemModel();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                Console.WriteLine("Success");
                string query = "SELECT * FROM Transactionitems WHERE TransactionID = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                        {
                            if (dtReader.Read())
                            {
                                transactionItem.ItemID = dtReader.GetInt32("ItemID");
                                transactionItem.TransactionID = dtReader.GetInt32("TransactionID");
                                transactionItem.BookID = dtReader.IsDBNull(dtReader.GetOrdinal("BookID")) ? (Int16?)null : dtReader.GetInt16("BookID");
                                transactionItem.DeviceID = dtReader.IsDBNull(dtReader.GetOrdinal("DeviceID")) ? (Int16?)null : dtReader.GetInt16("DeviceID");
                                transactionItem.Amount = dtReader.GetInt16("Amount");
                            }
                        }
                        dbConnect.CloseConnection();
                        return transactionItem;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return null;
                }
            }
        }

        // CREATE
        public bool Insert(TransactionItemModel transactionItem)
        {
            string query = "INSERT INTO Transactionitems (ItemID, BookID, DeviceID, Amount)\n VALUES (@ItemID, @BookID, @DeviceID, @Amount)";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ItemID", transactionItem.ItemID);
                        myCmd.Parameters.AddWithValue("@BookID", transactionItem.BookID);
                        myCmd.Parameters.AddWithValue("@DeviceID", transactionItem.DeviceID);
                        myCmd.Parameters.AddWithValue("@Amount", transactionItem.Amount);
                        bool result = myCmd.ExecuteNonQuery() > 0;
                        dbConnect.CloseConnection();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return false;
                }
            }
        }

        // UPDATE 
        public bool Update(TransactionItemModel newTranSactionItem)
        {
            string query = "UPDATE TABLE Transactionitems\n" +
                "SET ItemID = @ItemID, BookID = @BookID, DeviceID = @DeviceID, Amount = @Amount\n" +
                "WHERE TransactionID = @TransacionID";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", newTranSactionItem.TransactionID);
                        myCmd.Parameters.AddWithValue("@ItemID", newTranSactionItem.ItemID);
                        myCmd.Parameters.AddWithValue("@BookID", newTranSactionItem.BookID);
                        myCmd.Parameters.AddWithValue("@DeviceID", newTranSactionItem.DeviceID);
                        myCmd.Parameters.AddWithValue("@Amount", newTranSactionItem.Amount);
                        bool result = myCmd.ExecuteNonQuery() > 0;
                        dbConnect.CloseConnection();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return false;
                }
            }
        }

        // DELETE
        public bool Delete(string transactionID)
        {
            string query = "DELETE FROM Transactionitems WHERE TransactionID = @TransactionID";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransacionID", transactionID);
                        bool result = myCmd.ExecuteNonQuery() > 0;
                        dbConnect.CloseConnection();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return false;
                }
            }
        }
    }
}
