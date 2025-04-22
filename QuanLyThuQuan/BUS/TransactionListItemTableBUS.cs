using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThuQuan.BUS
{
    internal class TransactionListItemTableBUS
    {
        private static TransactionListItemTableBUS _INSTANCE = new TransactionListItemTableBUS();
        private TransactionListItemTableBUS() { }

        public static TransactionListItemTableBUS GetInstance()
        {
            if (_INSTANCE == null)
                return new TransactionListItemTableBUS();
            return _INSTANCE;
        }
        private DataTable GeneDataTable()
        {
            DataTable table = new DataTable("dtbListProductView");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            return table;
        }

        private DataTable SetDataForDataTable(List<TransactionListItemTableModel> listItem)
        {
            DataTable table = GeneDataTable();
            int autoId = 1;
            foreach (TransactionListItemTableModel item in listItem)
            {
                table.Rows.Add(autoId++, item.productName, item.amount);
            }
            return table;
        }

        public DataSet GetDataSet(List<TransactionListItemTableModel> list)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(SetDataForDataTable(list));
            return dataSet;
        }
    }
}
