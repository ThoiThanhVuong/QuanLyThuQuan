using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IDBConnection dbConnection = new DBConnection("localhost", "quanlythuquan", "root", "");
            return new TransactionItemDAO(dbConnection).GetAll();
        }
    }
}
