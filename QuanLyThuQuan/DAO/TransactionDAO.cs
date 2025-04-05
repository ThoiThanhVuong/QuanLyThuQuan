using MySql.Data.MySqlClient;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using QuanLyThuQuan.AppConfig;

namespace QuanLyThuQuan.DAO
{
    class TransactionDAO
    {
        private readonly IDBConnection db;
        private readonly ConnectDB dbConnect;

        public TransactionDAO(IDBConnection dbConnection)
        {
            this.db = dbConnection;
        }

        public TransactionDAO(ConnectDB db)
        {
            this.dbConnect = db;
        }

        // get all value on DB (READ)
        public List<TransactionModel> GetAll()
        {
            List<TransactionModel> transactionList = new List<TransactionModel>();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                Console.WriteLine("Success");
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
                    dbConnect.CloseConnection();
                    return transactionList;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    dbConnect.CloseConnection();
                    return null;
                }
            }
        }

        // Get by specific id (READ)
        public TransactionModel GetByID(string id)
        {
            TransactionModel transaction = new TransactionModel();
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                Console.WriteLine("Success");
                string query = "SELECT * FROM Transactions WHERE TransactionID = @ID";
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@ID", id);
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
                        dbConnect.CloseConnection();
                        return transaction;
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

        // Insert data (CREATE)
        public bool Insert(TransactionModel transaction)
        {
            string query = "INSERT INTO Transactions (MemberID, TransactionType, TransactionDate, DueDate, ReturnDate, Status) \n VALUES (@MemberID, @TransactionType, @TransactionDate, @DueDate, @ReturnDate, @Status)";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@MemberID", transaction.MemberID);
                        myCmd.Parameters.AddWithValue("@TransactionType", transaction.TransactionType);
                        myCmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                        myCmd.Parameters.AddWithValue("@DueDate", transaction.DueDate);
                        myCmd.Parameters.AddWithValue("@ReturnDate", transaction.ReturnDate);
                        myCmd.Parameters.AddWithValue("@Status", transaction.Status);
                        dbConnect.CloseConnection();                        
                        bool result = myCmd.ExecuteNonQuery() > 0;
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

        // Update value of specific TransactionID (UPDATE)
        public bool Update(TransactionModel newTransaction)
        {
            string query = "UPDATE TABLE Transactions\n" +
                "SET MemberID = @MemberID, TransactionType = @TransactionType, TransactionDate = @TransactionDate, DueDate = @DueDate, ReturnDate = @ReturnDate, Status = @Status\n" +
                "WHERE TransactionID = @TransactionID";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", newTransaction.TransactionID);
                        myCmd.Parameters.AddWithValue("@MemberID", newTransaction.MemberID);
                        myCmd.Parameters.AddWithValue("@TransactionType", newTransaction.TransactionType);
                        myCmd.Parameters.AddWithValue("@TransactionDate", newTransaction.TransactionDate);
                        myCmd.Parameters.AddWithValue("@DueDate", newTransaction.DueDate);
                        myCmd.Parameters.AddWithValue("@ReturnDate", newTransaction.ReturnDate);
                        myCmd.Parameters.AddWithValue("@Status", newTransaction.Status);
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

        // Delete (DELETE)
        public bool Delete(string transactionID)
        {
            string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";
            dbConnect.OpenConnection();
            //using (MySqlConnection connection = db.GetConnection())
            using (MySqlConnection connection = dbConnect.Connection)
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        bool result =  myCmd.ExecuteNonQuery() > 0;
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
