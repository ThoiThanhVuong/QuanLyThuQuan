using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;

using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.DAO
{
    class TransactionDAO
    {
        private ConnectDB db = new ConnectDB();


        public List<TransactionModel> GetAllTransactionsWithItems()
        {
            List<TransactionModel> transactions = new List<TransactionModel>();
            Dictionary<int, TransactionModel> transactionMap = new Dictionary<int, TransactionModel>();

            try
            {
                db.OpenConnection();
                string query = @"
            SELECT t.*, ti.ItemID, ti.BookID, ti.DeviceID, ti.Amount, ti.Status AS ItemStatus
            FROM Transactions t
            LEFT JOIN TransactionItems ti ON t.TransactionID = ti.TransactionID
        ";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int transactionID = reader.GetInt32("TransactionID");

                        if (!transactionMap.ContainsKey(transactionID))
                        {
                            var transaction = new TransactionModel(
                                transactionID,
                                reader.GetInt32("MemberID"),
                                (TransactionType)Enum.Parse(typeof(TransactionType), reader.GetString("TransactionType")),
                                reader.GetDateTime("TransactionDate"),
                                reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime("DueDate"),
                                reader.IsDBNull(reader.GetOrdinal("ReturnDate")) ? (DateTime?)null : reader.GetDateTime("ReturnDate"),
                                (TransactionStatus)Enum.Parse(typeof(TransactionStatus), reader.GetString("Status"))
                            );
                            transaction.TransactionItems = new List<TransactionItemModel>(); 
                            transactionMap[transactionID] = transaction;
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("ItemID")))
                        {
                            var item = new TransactionItemModel(
                                reader.GetInt32("ItemID"),
                                transactionID,
                                reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                                reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                                reader.GetInt32("Amount"),
                                (TransactionItemStatus)Enum.Parse(typeof(TransactionItemStatus), reader.GetString("ItemStatus"))
                            );

                            transactionMap[transactionID].TransactionItems.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetAllTransactionsWithItems: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            transactions.AddRange(transactionMap.Values);
            return transactions;
        }
        public TransactionModel GetTransactionByID(int ID)
        {
            Dictionary<int, TransactionModel> transactionMap = new Dictionary<int, TransactionModel>();

            try
            {
                db.OpenConnection();
                string query = @"
            SELECT t.*, ti.ItemID, ti.BookID, ti.DeviceID, ti.Amount, ti.Status AS ItemStatus,
                   m.MemberID, m.FullName, m.Email, m.PhoneNumber
            FROM Transactions t
            LEFT JOIN TransactionItems ti ON ti.TransactionID = t.TransactionID
            JOIN Member m ON m.MemberID = t.MemberID
            WHERE t.TransactionID = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int transactionID = reader.GetInt32("TransactionID");

                            if (!transactionMap.ContainsKey(transactionID))
                            {
                                var member = new MemberModel(
                                    reader.GetInt32("MemberID"),
                                    reader.GetString("FullName"),
                                    reader.GetString("Email"),
                                    reader.GetString("PhoneNumber")
                                );

                                var transaction = new TransactionModel(
                                    transactionID,
                                    reader.GetInt32("MemberID"),
                                    (TransactionType)Enum.Parse(typeof(TransactionType), reader.GetString("TransactionType")),
                                    reader.GetDateTime("TransactionDate"),
                                    reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime("DueDate"),
                                    reader.IsDBNull(reader.GetOrdinal("ReturnDate")) ? (DateTime?)null : reader.GetDateTime("ReturnDate"),
                                    (TransactionStatus)Enum.Parse(typeof(TransactionStatus), reader.GetString("Status")),
                                    member
                                );
                                transaction.TransactionItems = new List<TransactionItemModel>(); 
                                transactionMap[transactionID] = transaction;
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("ItemID")))
                            {
                                var item = new TransactionItemModel(
                                    reader.GetInt32("ItemID"),
                                    transactionID,
                                    reader.IsDBNull(reader.GetOrdinal("BookID")) ? (int?)null : reader.GetInt32("BookID"),
                                    reader.IsDBNull(reader.GetOrdinal("DeviceID")) ? (int?)null : reader.GetInt32("DeviceID"),
                                    reader.GetInt32("Amount"),
                                    (TransactionItemStatus)Enum.Parse(typeof(TransactionItemStatus), reader.GetString("ItemStatus"))
                                );

                                transactionMap[transactionID].TransactionItems.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetTransactionByID: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            if (transactionMap.TryGetValue(ID, out var foundTransaction))
            {
                return foundTransaction;
            }
            return null;
        }

        public bool AddTransactionWithItems(TransactionModel transaction)
        {
            try
            {
                db.OpenConnection();
                
                string transactionQuery = @"
            INSERT INTO Transactions (MemberID, TransactionType, TransactionDate, DueDate, ReturnDate, Status)
            VALUES (@MemberID, @TransactionType, @TransactionDate, @DueDate, @ReturnDate, @Status);
            SELECT LAST_INSERT_ID();"; 

                using (MySqlCommand cmd = new MySqlCommand(transactionQuery, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", transaction.MemberID);
                    cmd.Parameters.AddWithValue("@TransactionType", transaction.TransactionType.ToString());
                    cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@DueDate", transaction.DueDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReturnDate", transaction.ReturnDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", transaction.Status.ToString());

                    // Lấy TransactionID vừa được thêm vào
                    int transactionID = Convert.ToInt32(cmd.ExecuteScalar());

                    // Thêm các mục giao dịch liên quan
                    foreach (var item in transaction.TransactionItems)
                    {
                        string itemQuery = @"
                    INSERT INTO TransactionItems (TransactionID, BookID, DeviceID, Amount,Status)
                    VALUES (@TransactionID, @BookID, @DeviceID, @Amount,@Status);";

                        using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, db.Connection))
                        {
                            itemCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                            itemCmd.Parameters.AddWithValue("@BookID", item.BookID ?? (object)DBNull.Value);
                            itemCmd.Parameters.AddWithValue("@DeviceID", item.DeviceID ?? (object)DBNull.Value);
                            itemCmd.Parameters.AddWithValue("@Amount", item.Amount);
                            itemCmd.Parameters.AddWithValue("@Status", item.Status.ToString());
                            itemCmd.ExecuteNonQuery(); 
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm giao dịch: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public bool UpdateTransactionWithItems(TransactionModel transaction)
        {
            try
            {
                db.OpenConnection();
             
                string transactionQuery = @"
                UPDATE Transactions
                SET MemberID = @MemberID, TransactionType = @TransactionType, TransactionDate = @TransactionDate, 
                    DueDate = @DueDate, ReturnDate = @ReturnDate, Status = @Status
                WHERE TransactionID = @TransactionID;";

                using (MySqlCommand cmd = new MySqlCommand(transactionQuery, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);
                    cmd.Parameters.AddWithValue("@MemberID", transaction.MemberID);
                    cmd.Parameters.AddWithValue("@TransactionType", transaction.TransactionType.ToString());
                    cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@DueDate", transaction.DueDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReturnDate", transaction.ReturnDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", transaction.Status.ToString());

                    cmd.ExecuteNonQuery();
                }

                // Xóa các mục giao dịch cũ (nếu có) và thêm các mục giao dịch mới
                string deleteItemsQuery = "DELETE FROM TransactionItems WHERE TransactionID = @TransactionID;";
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteItemsQuery, db.Connection))
                {
                    deleteCmd.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);
                    deleteCmd.ExecuteNonQuery();
                }

                // Thêm các mục giao dịch mới
                foreach (var item in transaction.TransactionItems)
                {
                    string itemQuery = @"
                INSERT INTO TransactionItems (TransactionID, BookID, DeviceID, Amount,Status)
                VALUES (@TransactionID, @BookID, @DeviceID, @Amount,@Status);";

                    using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, db.Connection))
                    {
                        itemCmd.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);
                        itemCmd.Parameters.AddWithValue("@BookID", item.BookID ?? (object)DBNull.Value);
                        itemCmd.Parameters.AddWithValue("@DeviceID", item.DeviceID ?? (object)DBNull.Value);
                        itemCmd.Parameters.AddWithValue("@Amount", item.Amount);
                        itemCmd.Parameters.AddWithValue("@Status", item.Status.ToString());
                        itemCmd.ExecuteNonQuery(); 
                    }
                }

                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật giao dịch: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public bool DeleteTransactionWithItems(int transactionID)
        {
            try
            {
                db.OpenConnection();
               
                string deleteItemsQuery = "DELETE FROM TransactionItems WHERE TransactionID = @TransactionID;";
                using (MySqlCommand deleteItemsCmd = new MySqlCommand(deleteItemsQuery, db.Connection))
                {
                    deleteItemsCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    deleteItemsCmd.ExecuteNonQuery();
                }

                // Xóa giao dịch
                string deleteTransactionQuery = "DELETE FROM Transactions WHERE TransactionID = @TransactionID;";
                using (MySqlCommand deleteTransactionCmd = new MySqlCommand(deleteTransactionQuery, db.Connection))
                {
                    deleteTransactionCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    deleteTransactionCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa giao dịch: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

      
        public List<PaymentModel> GetPaymentsByTransactionID(int transactionID)
        {
            List<PaymentModel> list = new List<PaymentModel>();
            
            string query = "SELECT * FROM Payment WHERE TransactionID = @TransactionID";
            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var model = new PaymentModel
                            {
                                PaymentID = reader.GetInt32(reader.GetOrdinal("PaymentID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                ViolationID = reader.IsDBNull(reader.GetOrdinal("ViolationID"))
                                ? null : (int?)reader.GetInt32(reader.GetOrdinal("ViolationID")),
                                            TransactionID = reader.IsDBNull(reader.GetOrdinal("TransactionID"))
                                ? null : (int?)reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                Amount = reader.GetDecimal(reader.GetOrdinal("Amount")),
                                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "" : reader.GetString("Description"),
                                PaymentDate = reader.IsDBNull(reader.GetOrdinal("PaymentDate")) ? DateTime.MinValue : reader.GetDateTime("PaymentDate"),
                                Status = (PaidStatus)Enum.Parse(typeof(PaidStatus), reader.GetString(reader.GetOrdinal("Status")))
                            };
                            list.Add(model);
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Lỗi GetPayments: " + ex.Message); }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public List<ViolationModel> GetViolationsByTransactionID(int transactionID)
        {
            List<ViolationModel> list = new List<ViolationModel>();
            string query = "SELECT * FROM Violation WHERE TransactionID = @TransactionID";
            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ViolationModel(
                                reader.GetInt32(reader.GetOrdinal("ViolationID")),
                                reader.GetInt32(reader.GetOrdinal("MemberID")),
                                reader.IsDBNull(reader.GetOrdinal("TransactionID")) ? null : (int?)reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                reader.GetInt32(reader.GetOrdinal("RuleID")),
                                reader.GetDecimal(reader.GetOrdinal("FineAmount")),
                                reader.GetString(reader.GetOrdinal("Reason")),
                                reader.GetDateTime(reader.GetOrdinal("ViolationDate")),
                                reader.GetBoolean(reader.GetOrdinal("IsCompensationRequired"))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Lỗi GetViolations: " + ex.Message); }
            finally
            {
                db.CloseConnection();
            }
            return list;
        }

        public bool ConfirmReturnAndCalculatePayment(int transactionID)
        {
            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand("ConfirmReturnAndCalculatePayment", db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_TransactionID", transactionID);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xác nhận trả sách và tính tiền thanh toán: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public bool ReturnSingleItem(int itemID)
        {
            try
            {
                db.OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand("ReturnSingleItem", db.Connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_ItemID", itemID);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi trả món đơn lẻ: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
        public bool UpdateDueDate(int transactionID, DateTime dueDate)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Transactions SET DueDate = @DueDate WHERE TransactionID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);
                    cmd.Parameters.AddWithValue("@ID", transactionID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi UpdateDueDate: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }


    }
}
