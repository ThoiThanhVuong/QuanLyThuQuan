using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace QuanLyThuQuan.DAO
{
    class TransactionItemDAO
    {
        private readonly IDBConnection db;
        private ConnectDB dbConnect;
        public TransactionItemDAO(IDBConnection dbConnection)
        {
            this.db = dbConnection;
        }

        public TransactionItemDAO(ConnectDB dbConnect)
        {
            this.dbConnect = dbConnect;
        }

        public TransactionItemDAO()
        {
            if (dbConnect == null)
                dbConnect = new ConnectDB();
        }

        // READ
        public List<TransactionItemModel> GetAll()
        {
            List<TransactionItemModel> transactionItemList = new List<TransactionItemModel>();
            if (dbConnect == null) dbConnect = new ConnectDB();
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
            if (dbConnect == null) dbConnect = new ConnectDB();
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
            if (dbConnect == null) dbConnect = new ConnectDB();
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
            string query = "INSERT INTO Transactionitems (transactionID, BookID, DeviceID, Amount)\n VALUES (@TransactionID, @BookID, @DeviceID, @Amount)";
            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    bool result = false;
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        //myCmd.Parameters.AddWithValue("@ItemID", transactionItem.ItemID);
                        myCmd.Parameters.AddWithValue("@TransactionID", transactionItem.TransactionID);
                        myCmd.Parameters.AddWithValue("@BookID", transactionItem.BookID);
                        myCmd.Parameters.AddWithValue("@DeviceID", transactionItem.DeviceID);
                        myCmd.Parameters.AddWithValue("@Amount", transactionItem.Amount);
                        result = myCmd.ExecuteNonQuery() > 0;
                    }
                    transaction.Commit();
                    dbConnect.CloseConnection();
                    return result;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    dbConnect.CloseConnection();
                    return false;
                }
            }
        }

        // CREATE WITH PARAMS IS LIST<>
        public bool Insert(List<TransactionItemModel> transactionItems)
        {
            string query = "INSERT INTO TransactionItems (transactionID, BookID, DeviceID, Amount) VALUES (@TransactionID, @BookID, @DeviceID, @Amount)";

            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();

            using (MySqlConnection connection = dbConnect.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (TransactionItemModel item in transactionItems)
                        using (MySqlCommand cmd = new MySqlCommand(query, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@TransactionID", item.TransactionID);
                            cmd.Parameters.AddWithValue("@BookID", item.BookID);
                            cmd.Parameters.AddWithValue("@DeviceID", item.DeviceID);
                            cmd.Parameters.AddWithValue("@Amount", item.Amount);

                            cmd.ExecuteNonQuery();
                        }
                    // Nếu insert hết không lỗi => commit
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Insert list failed: " + ex.Message);
                    transaction.Rollback(); // hoàn tác nếu có lỗi
                    return false;
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }


        // UPDATE 
        public bool Update(TransactionItemModel newItem)
        {
            string query = @"
                UPDATE TransactionItems
                SET BookID = @BookID, DeviceID = @DeviceID, Amount = @Amount
                WHERE TransactionID = @TransactionID AND ItemID = @ItemID";
            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();
            using (MySqlConnection connection = dbConnect.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TransactionID", newItem.TransactionID);
                        cmd.Parameters.AddWithValue("@ItemID", newItem.ItemID);
                        cmd.Parameters.AddWithValue("@BookID", newItem.BookID);
                        cmd.Parameters.AddWithValue("@DeviceID", newItem.DeviceID);
                        cmd.Parameters.AddWithValue("@Amount", newItem.Amount);

                        transaction.Commit();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Update Error: " + ex.Message);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }

        // UPDATE WITH PARAMS IS LIST
        public bool Update(List<TransactionItemModel> newItems)
        {
            string query = @"
                UPDATE TransactionItems
                SET BookID = @BookID, DeviceID = @DeviceID, Amount = @Amount
                WHERE TransactionID = @TransactionID AND ItemID = @ItemID";
            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();
            using (MySqlConnection connection = dbConnect.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (TransactionItemModel newItem in newItems)
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@TransactionID", newItem.TransactionID);
                            cmd.Parameters.AddWithValue("@ItemID", newItem.ItemID);
                            cmd.Parameters.AddWithValue("@BookID", newItem.BookID);
                            cmd.Parameters.AddWithValue("@DeviceID", newItem.DeviceID);
                            cmd.Parameters.AddWithValue("@Amount", newItem.Amount);
                            cmd.ExecuteNonQuery();
                        }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Update Error: " + ex.Message);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }


        // DELETE
        public bool Delete(string transactionID, string itemID)
        {
            string query = @"
                DELETE FROM TransactionItems
                WHERE TransactionID = @TransactionID AND ItemID = @ItemID";
            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        cmd.Parameters.AddWithValue("@ItemID", itemID);

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
                    dbConnect.CloseConnection();
                }
            }
        }
         
        // OPTIMIZE: DELETE WITH PARAMS IS DICTIONARY<transacionID,itemID>
        public bool Delete(Dictionary<string, string> listKeyValues)
        {
            string query = @"
                DELETE FROM TransactionItems
                WHERE TransactionID = @TransactionID AND ItemID = @ItemID";
            if (dbConnect == null) dbConnect = new ConnectDB();
            dbConnect.OpenConnection();
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    Dictionary<string, string>.Enumerator isEnum = listKeyValues.GetEnumerator();
                    while(isEnum.MoveNext())
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@TransactionID", isEnum.Current.Key);
                            cmd.Parameters.AddWithValue("@ItemID", isEnum.Current.Value);
                            cmd.ExecuteNonQuery();
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Delete Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    dbConnect.CloseConnection();
                }
            }
        }
    }
}
