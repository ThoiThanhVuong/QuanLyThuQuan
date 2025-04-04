﻿using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
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

            TransactionBUS.GetInstance().LoadLocal();
            List<TransactionModel> list = TransactionBUS.GetInstance().GetAllLocal();
            System.Console.WriteLine(list.Count);
            foreach (TransactionModel item in list)
                System.Console.WriteLine(item.ReturnDate);
        }
    }
}
