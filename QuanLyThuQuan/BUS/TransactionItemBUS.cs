
﻿using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;

using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class TransactionItemBUS : BaseBUS<TransactionItemModel, int>
    {
        private static readonly TransactionItemBUS Instance = new TransactionItemBUS();

        // Prevent new TransactionItemBUS
        public TransactionItemBUS() { }

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

        public List<TransactionItemModel> getByTransactionID(string id)
        {
            return new TransactionItemDAO(GetConnectDB()).GetByTransactionID(id);
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
