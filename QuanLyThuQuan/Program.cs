<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyThuQuan.GUI;
=======
﻿using QuanLyThuQuan.GUI;
using System;
using System.Windows.Forms;
>>>>>>> e9e8c2668c9e6b62e77b330576d43285299ac177
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormMain() );

       
=======
            Application.Run(new FormMain());

            //TransactionBUS.GetInstance().LoadLocal();
            //List<TransactionModel> list = TransactionBUS.GetInstance().GetAllLocal();
            //System.Console.WriteLine(list.Count);
            //foreach (TransactionModel item in list)
            //    System.Console.WriteLine(item.ReturnDate);
>>>>>>> e9e8c2668c9e6b62e77b330576d43285299ac177
        }
    }
}
