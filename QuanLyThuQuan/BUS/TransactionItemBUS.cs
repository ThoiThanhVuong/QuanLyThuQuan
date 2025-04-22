
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;

using System.Collections.Generic;
using System.Linq;

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
            return new TransactionItemDAO(GetConnectDB()).GetAll().ToList();
        }

        public TransactionItemModel GetByID(string id)
        {
            TransactionItemModel item = new TransactionItemDAO(GetConnectDB()).GetByID(id);
            if (item == null)
                return null;
            return new TransactionItemModel(item.ItemID, item.TransactionID, item?.BookID, item?.DeviceID, item.Amount);
        }

        public List<TransactionItemModel> GetByTransactionID(string id)
        {
            return new TransactionItemDAO(GetConnectDB()).GetByTransactionID(id).ToList();
        }


        public void Add(TransactionItemModel transaction)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Insert(transaction);
            new TransactionItemDAO(GetConnectDB()).Insert(transaction);
        }

        public void AddList(List<TransactionItemModel> transactions)
        {
            new TransactionItemDAO(GetConnectDB()).Insert(transactions);
        }

        public void Update(TransactionItemModel transaction)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Update(transaction);
            new TransactionItemDAO(GetConnectDB()).Update(transaction);
        }

        public void UpdateList(List<TransactionItemModel> transactions)
        {
            new TransactionItemDAO(GetConnectDB()).Update(transactions);
        }

        public void Delete(string transactionID, string itemID)
        {
            //new TransactionItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Delete(id);
            new TransactionItemDAO(GetConnectDB()).Delete(transactionID, itemID);
        }

        public void DeleteList(Dictionary<string, string>KeyTransIDWithValueItemID)
        {
            new TransactionItemDAO(GetConnectDB()).Delete(KeyTransIDWithValueItemID);
        }
    }
}
