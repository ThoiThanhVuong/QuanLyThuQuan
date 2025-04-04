using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Service;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class TransactionBUS : BaseBUS<TransactionModel, int>
    {
        private static readonly TransactionBUS Instance = new TransactionBUS();

        //prevent new TransactionBUS
        private TransactionBUS() { }

        // getter
        public static TransactionBUS GetInstance()
        {
            return Instance;
        }

        public override List<TransactionModel> GetAll()
        {
            IDBConnection dbConnection = new DBConnection("localhost", "quanlythuquan", "root", "");
            return new TransactionDAO(dbConnection).GetAll();
        }
    }
}
