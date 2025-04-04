using MySql.Data.MySqlClient;
using QuanLyThuQuan.Interfaces;
using System;

namespace QuanLyThuQuan.Service
{
    class DBConnection : IDBConnection
    {
        private MySqlConnection connection;
        //private static DBConnection _instance = null;
        private readonly string connectionString;


        private DBConnection()
        {
        }

        public DBConnection(string server, string database, string user, string password)
        {
            connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
        }

        //singleton
        //public static DBConnection Instance(string server, string serverName, string userID, string password)
        //{
        //    if (_instance == null)
        //        _instance = new DBConnection(server, serverName, userID, password);
        //    return _instance;
        //}

        public MySqlConnection GetConnection()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine("Error when connect to database!");
                    System.Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
            return connection;
        }

        public void Close()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
