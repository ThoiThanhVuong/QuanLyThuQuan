using MySql.Data.MySqlClient;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    class TransactionDAO
    {
        private readonly IDBConnection db;

        public TransactionDAO(IDBConnection dbConnection)
        {
            this.db = dbConnection;
        }

        // get all value on DB (READ)
        public List<TransactionModel> GetAll()
        {
            List<TransactionModel> transactionList = new List<TransactionModel>();
            using (MySqlConnection connection = db.GetConnection())
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
                    return transactionList;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }

        // Get by specific id (READ)
        public TransactionModel GetByID(string id)
        {
            TransactionModel transaction = new TransactionModel();
            using (MySqlConnection connection = db.GetConnection())
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
                        return transaction;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }

        // Insert data (CREATE)
        public bool Insert(TransactionModel transaction)
        {
            string query = "INSERT INTO Transactions (MemberID, TransactionType, TransactionDate, DueDate, ReturnDate, Status) \n VALUES (@MemberID, @TransactionType, @TransactionDate, @DueDate, @ReturnDate, @Status)";
            using (MySqlConnection connection = db.GetConnection())
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
                        return myCmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
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
            using (MySqlConnection connection = db.GetConnection())
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
                        return myCmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    return false;
                }
            }
        }

        // Delete (DELETE)
        public bool Delete(string transactionID)
        {
            string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";
            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    using (MySqlCommand myCmd = new MySqlCommand(query, connection))
                    {
                        myCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        return myCmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.StackTrace);
                    return false;
                }
            }

        }
    }
}
