using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormReservation : Form
    {
        public FormReservation()
        {
            InitializeComponent();
           
        }

      
        

        // Resize columns
        
        // NOTE: SUBMIT RESERVATION AND CHANGE IT TO TRANSACTION
        




        private void btnExitChildPanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        // NOTE: CREATE COL MORE FOR TABLES
        private void CreateColumn(DataGridView dgv, string colName, string colContentText, string colHeaderText)
        {
            if (!dgv.Columns.Contains(colName))
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "col" + colName + "Options";
                column.HeaderText = colHeaderText;
                column.Text = colContentText;
                column.UseColumnTextForButtonValue = true;
                column.Width = 10;
                dgv.Columns.Add(column);
            }
        }
    }
}
