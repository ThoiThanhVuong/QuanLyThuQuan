using QuanLyThuQuan.Config;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Service;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class TransactionBUS : BaseBUS<TransactionModel, int>
    {
        private static readonly TransactionBUS _Instance = new TransactionBUS();

        //prevent new TransactionBUS
        private TransactionBUS() { }

        // getter
        public static TransactionBUS GetInstance()
        {
            return _Instance;
        }

        public override List<TransactionModel> GetAll()
        {
            //return new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).GetAll();
            return new TransactionDAO(GetConnectDB()).GetAll();
        }

        public TransactionModel GetByID(string id)
        {
            return new TransactionDAO(GetConnectDB()).GetByID(id);
        }

        public void Add(TransactionModel transaction)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Insert(transaction);
            new TransactionDAO(GetConnectDB()).Insert(transaction);
        }

        public void Update(TransactionModel transaction)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Update(transaction);
            new TransactionDAO(GetConnectDB()).Update(transaction);
        }

        public void Delete(string id)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Delete(id);
            new TransactionDAO(GetConnectDB()).Delete(id);
        }

        
    }
}
