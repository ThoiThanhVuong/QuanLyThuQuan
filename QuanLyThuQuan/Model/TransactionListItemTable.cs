using System.Collections.Generic;
using System.Data;

namespace QuanLyThuQuan.Model
{
    // JUST TEMP DTO FOR GENE TABLE ON TRANSACTION INFORMATION
    internal class TransactionListItemTable
    {
        public string productName { get; set; }
        public int amount { get; set; }

        public TransactionListItemTable() { }

        public TransactionListItemTable(string productName, int amount)
        {
            this.productName = productName;
            this.amount = amount;
        }

        private DataTable GeneDataTable()
        {
            DataTable table = new DataTable("dtbListProductView");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            return table;
        }

        private DataTable SetDataForDataTable(List<TransactionListItemTable> listItem)
        {
            DataTable table = GeneDataTable();
            int autoId = 1;
            foreach (TransactionListItemTable item in listItem)
            {
                table.Rows.Add(autoId++, item.productName, item.amount);
            }
            return table;
        }

        public DataSet GetDataSet(List<TransactionListItemTable> list)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(SetDataForDataTable(list));
            return dataSet;
        }
    }
}
