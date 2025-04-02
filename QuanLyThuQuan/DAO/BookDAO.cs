using System;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
namespace QuanLyThuQuan.DAO
{
    class BookDAO
    {
        private ConnectDB connectDB;
        public BookDAO()
        {
            connectDB = new ConnectDB(); 
        }

    }
}
