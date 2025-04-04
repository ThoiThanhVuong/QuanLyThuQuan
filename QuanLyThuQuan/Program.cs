using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Service;
using System;
using System.Collections.Generic;
namespace QuanLyThuQuan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMain());
            IDBConnection connection = new DBConnection("localhost", "quanlythuquan", "root", "");
            TransactionDAO transaction = new TransactionDAO(connection);
            List<TransactionModel> list = transaction.GetAll();
            foreach (TransactionModel trans in list)
                Console.WriteLine(trans.TransactionID);
            Console.WriteLine(transaction.GetByID("1"));
        }
    }
}
