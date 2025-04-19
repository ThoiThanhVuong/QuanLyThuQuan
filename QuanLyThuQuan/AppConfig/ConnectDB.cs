using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.AppConfig
{
    class ConnectDB
    {
        private string connectionString = "server=localhost;port=3306;database=quanlythuquan;user=root;password=;";
        private MySqlConnection connection;

        public ConnectDB()
        {
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection Connection
        {
            get { return connection; }
        }
        // Mở kết nối MySQL
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Kết nối MySQL thành công!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
        }

        // Đóng kết nối MySQL
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Đã đóng kết nối MySQL!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đóng kết nối: " + ex.Message);
            }
        }

        public System.Data.DataTable ExecuteSelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        public bool ExecuteInsertQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ExecuteUpdateQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ExecuteDeleteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
