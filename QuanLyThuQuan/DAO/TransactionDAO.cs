using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    class TransactionDAO
    {
        private ConnectDB db = new ConnectDB();

        public TransactionDAO()
        {
            if (db == null)
                db = new ConnectDB();
        }

        // get all value on DB (READ)
        public List<TransactionModel> GetAll()
        {
            List<TransactionModel> transactionList = new List<TransactionModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            {

                string query = "SELECT * FROM Transactions";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                    {
                        while (dtReader.Read())
                        {
                            TransactionModel transaction = new TransactionModel();
                            transaction.TransactionID = dtReader.GetInt32("TransactionID");
                            transaction.MemberID = dtReader.GetInt32("MemberID");
                            transaction.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), dtReader.GetString("TransactionType"));
                            transaction.TransactionDate = dtReader.GetDateTime("TransactionDate");
                            transaction.DueDate = dtReader.IsDBNull(dtReader.GetOrdinal("DueDate")) ? (DateTime?)null : dtReader.GetDateTime("DueDate");
                            transaction.ReturnDate = dtReader.IsDBNull(dtReader.GetOrdinal("ReturnDate")) ? (DateTime?)null : dtReader.GetDateTime("ReturnDate");
                            transaction.Status = (TransactionStatus)Enum.Parse(typeof(TransactionStatus), dtReader.GetString("Status"));
                            transactionList.Add(transaction);
                        }
                    }
                    db.CloseConnection();
                    return transactionList;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    db.CloseConnection();
                    return null;
                }
            }
        }

        // Get by specific id (READ)
        public List<TransactionModel> GetByID(string id, string condition)
        {
            List<TransactionModel> list = new List<TransactionModel>();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            {
                Console.WriteLine("Success");
                if (!ValidateConditionServices.GetInstance().IsValidForTransaction(condition))
                {
                    Console.WriteLine("Error");
                    return null;
                }
                string query = $"SELECT * FROM Transactions WHERE {condition} = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", id);
                        using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                        {
                            if (dtReader.Read())
                            {
                                TransactionModel transaction = new TransactionModel();
                                transaction.TransactionID = dtReader.GetInt32("TransactionID");
                                transaction.MemberID = dtReader.GetInt32("MemberID");
                                transaction.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), dtReader.GetString("TransactionType"));
                                transaction.TransactionDate = dtReader.GetDateTime("TransactionDate");
                                transaction.DueDate = dtReader.IsDBNull(dtReader.GetOrdinal("DueDate")) ? (DateTime?)null : dtReader.GetDateTime("DueDate");
                                transaction.ReturnDate = dtReader.IsDBNull(dtReader.GetOrdinal("ReturnDate")) ? (DateTime?)null : dtReader.GetDateTime("ReturnDate");
                                transaction.Status = (TransactionStatus)Enum.Parse(typeof(TransactionStatus), dtReader.GetString("Status"));
                                list.Add(transaction);
                            }
                        }
                        db.CloseConnection();
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    db.CloseConnection();
                    return null;
                }
            }
        }

        // Get by 2 id (READ)
        public TransactionModel GetByTwoID(string transactionID, string memberID)
        {
            TransactionModel transaction = new TransactionModel();
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            {
                Console.WriteLine("Success");

                string query = $"SELECT * FROM Transactions WHERE TransactionID = @TransactionID AND MemberID = @MemberID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        myCmd.Parameters.AddWithValue("@MemberID", memberID);
                        using (MySqlDataReader dtReader = myCmd.ExecuteReader())
                        {
                            if (dtReader.Read())
                            {
                                transaction.TransactionID = dtReader.GetInt32("TransactionID");
                                transaction.MemberID = dtReader.GetInt32("MemberID");
                                transaction.TransactionType = (TransactionType)Enum.Parse(typeof(TransactionType), dtReader.GetString("TransactionType"));
                                transaction.TransactionDate = dtReader.GetDateTime("TransactionDate");
                                transaction.DueDate = dtReader.IsDBNull(dtReader.GetOrdinal("DueDate")) ? (DateTime?)null : dtReader.GetDateTime("DueDate");
                                transaction.ReturnDate = dtReader.IsDBNull(dtReader.GetOrdinal("ReturnDate")) ? (DateTime?)null : dtReader.GetDateTime("ReturnDate");
                                transaction.Status = (TransactionStatus)Enum.Parse(typeof(TransactionStatus), dtReader.GetString("Status"));
                            }
                        }
                        db.CloseConnection();
                        return transaction;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    db.CloseConnection();
                    return null;
                }
            }
        }

        // Insert data (CREATE)
        public bool Insert(TransactionModel transaction)
        {
            string query = "INSERT INTO Transactions (MemberID, TransactionType, DueDate, ReturnDate, Status) " +
                           "VALUES (@MemberID, @TransactionType, @DueDate, @ReturnDate, @Status)";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            using (MySqlConnection connection = db.Connection)
            using (MySqlTransaction transactions = connection.BeginTransaction())
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@MemberID", transaction.MemberID);
                        myCmd.Parameters.AddWithValue("@TransactionType", transaction.TransactionType.ToString());
                        myCmd.Parameters.AddWithValue("@DueDate", (object)transaction.DueDate ?? DBNull.Value);
                        myCmd.Parameters.AddWithValue("@ReturnDate", (object)transaction.ReturnDate ?? DBNull.Value);
                        myCmd.Parameters.AddWithValue("@Status", transaction.Status.ToString());
                        myCmd.ExecuteNonQuery();
                    }
                    transactions.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Insert Transaction Error: " + ex.Message);
                    transactions.Rollback();
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }


        // Update value of specific TransactionID (UPDATE)
        public bool Update(TransactionModel newTransaction)
        {
            string query = "UPDATE Transactions\n" +
                "SET MemberID = @MemberID, TransactionType = @TransactionType, TransactionDate = @TransactionDate, DueDate = @DueDate, ReturnDate = @ReturnDate, Status = @Status\n" +
                "WHERE TransactionID = @TransactionID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            using (MySqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    bool result = false;
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", newTransaction.TransactionID);
                        myCmd.Parameters.AddWithValue("@MemberID", newTransaction.MemberID);
                        myCmd.Parameters.AddWithValue("@TransactionType", newTransaction.TransactionType.ToString());
                        myCmd.Parameters.AddWithValue("@TransactionDate", newTransaction.TransactionDate);
                        myCmd.Parameters.AddWithValue("@DueDate", newTransaction.DueDate);
                        myCmd.Parameters.AddWithValue("@ReturnDate", newTransaction.ReturnDate);
                        myCmd.Parameters.AddWithValue("@Status", newTransaction.Status.ToString());
                        result = myCmd.ExecuteNonQuery() > 0;
                    }
                    transaction.Commit();
                    db.CloseConnection();
                    return result;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    transaction.Rollback();
                    db.CloseConnection();
                    return false;
                }
            }
        }

        // Delete (DELETE)
        public bool Delete(string transactionID)
        {
            string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";
            if (db == null) db = new ConnectDB();
            db.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = db.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", transactionID);

                        bool result = myCmd.ExecuteNonQuery() > 0;
                        db.CloseConnection();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    db.CloseConnection();
                    return false;
                }
            }
        }
    }
}
