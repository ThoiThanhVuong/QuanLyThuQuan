using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyThuQuan.Model
{
    // JUST TEMP DTO FOR GENE TABLE ON VIOLATION INFORMATION
    internal class ViolationsListItemTable
    {
        public string rule { get; set; }
        public decimal Penalty { get; set; }
        public DateTime ViolationDate { get; set; }
        public string Status { get; set; }

        public ViolationsListItemTable() { }

        public ViolationsListItemTable(string rule, decimal penalty, DateTime violationDate, string status)
        {
            this.rule = rule;
            this.Penalty = penalty;
            this.ViolationDate = violationDate;
            this.Status = status;
        }

        private DataTable GeneDataTable()
        {
            DataTable table = new DataTable("dtbViolationsListView");
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Rule ID", typeof(string));
            table.Columns.Add("Penalty", typeof(decimal));
            table.Columns.Add("Violation Date", typeof(DateTime));
            table.Columns.Add("Status", typeof(string));
            return table;
        }

        private DataTable SetDataForDataTable(List<ViolationsListItemTable> listItem)
        {
            DataTable table = GeneDataTable();
            int autoId = 1;
            foreach (var item in listItem)
            {
                table.Rows.Add(autoId++, item.rule, item.Penalty, item.ViolationDate, item.Status);
            }
            return table;
        }

        public DataSet GetDataSet(List<ViolationsListItemTable> list)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(SetDataForDataTable(list));
            return dataSet;
        }
    }
}
