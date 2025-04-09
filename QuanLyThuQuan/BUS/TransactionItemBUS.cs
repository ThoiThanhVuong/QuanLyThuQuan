<<<<<<< HEAD
﻿//using QuanLyThuQuan.Config;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;

using System;
=======
﻿using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
>>>>>>> e9e8c2668c9e6b62e77b330576d43285299ac177
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class TransactionItemBUS : BaseBUS<TransactionItemModel, int>
    {
        private static readonly TransactionItemBUS Instance = new TransactionItemBUS();

        // Prevent new TransactionItemBUS
        private TransactionItemBUS() { }

        // Getter
        public static TransactionItemBUS GetInstance()
        {
            return Instance;
        }

        public override List<TransactionItemModel> GetAll()
        {
            //return new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).GetAll();
            return new TransactionItemDAO(GetConnectDB()).GetAll();
        }

        public TransactionItemModel GetByID(string id)
        {
            return new TransactionItemDAO(GetConnectDB()).GetByID(id);
        }

        public void Add(TransactionItemModel transaction)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Insert(transaction);
            new TransactionItemDAO(GetConnectDB()).Insert(transaction);
        }

        public void Update(TransactionItemModel transaction)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Update(transaction);
            new TransactionItemDAO(GetConnectDB()).Update(transaction);
        }

        public void Delete(string id)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Delete(id);
            new TransactionItemDAO(GetConnectDB()).Delete(id);
        }
    }
}
