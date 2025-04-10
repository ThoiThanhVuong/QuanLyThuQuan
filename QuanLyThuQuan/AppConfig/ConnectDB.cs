using MySql.Data.MySqlClient;
using System;
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


    }
}
