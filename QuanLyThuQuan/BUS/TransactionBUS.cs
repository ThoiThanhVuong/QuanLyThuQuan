using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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

        public TransactionModel GetByID(string id, string condition)
        {
            return new TransactionDAO(GetConnectDB()).GetByID(id, condition);
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

        // check if this transaction is overdue
        public bool CheckOverdue(string id)
        {
            List<int> borrowItemID = new List<int>();
            List<TransactionItemModel> transactionItems = new TransactionItemDAO(GetConnectDB()).GetByTransactionID(id);
            if (transactionItems == null)
                return false;
            //  Get list Product here and loop it
            IEnumerator<TransactionItemModel> listEnum = transactionItems.GetEnumerator();
            while (listEnum.MoveNext())
                borrowItemID.Add((int)(listEnum.Current.DeviceID.Equals(null) ? listEnum.Current.BookID : listEnum.Current.DeviceID));
            //Loop list products
            IEnumerator<int> listID = borrowItemID.GetEnumerator();
            while (listID.MoveNext())
            {
                //  Compare Return Date or DueDate with Borrow Date
                
            }


            return false;
        }

        // check late fee if overdue
        private Decimal CalculateLateFee(string transactionID)
        {
            return 0;
        }

        // change status to overdue
        private bool ChangeStatus(string transactionID)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                return false;
            }
        }

        // check quantity product
        private bool IsQuantityValiable(int quantity)
        {
            return false;
        }

        // check member
        private bool CheckMember(string memberID)
        {
            return false;
        }

        //check member status account 
        private bool checkAccountMember(string memberID)
        {
            return false;
        }

        // check overdue 
        private bool checkMemberHistoryBorrow(string memberID)
        {
            return false;
        }
    }
}
