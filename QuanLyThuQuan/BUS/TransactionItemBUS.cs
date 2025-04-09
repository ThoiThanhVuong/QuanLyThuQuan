//using QuanLyThuQuan.Config;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Interfaces;
using QuanLyThuQuan.Model;

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
            //return new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).GetAll();
            return new TransactionItemDAO(GetConnectDB()).GetAll();
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
