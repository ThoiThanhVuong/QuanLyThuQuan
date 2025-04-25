using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormBorrowBook : Form
    {
        private string defaultMemberIDField = "Member ID";
        //private List<TransactionListItemTableModel> tables { get; set; }

        public FormBorrowBook()
        {
            InitializeComponent();
         
        }

        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
           
        }

    

   
 

        private bool CheckValidValueForTransaction(string memberID, DateTime dueDate)
        {
            if (ValidateParseToOtherType.GetInstance().CanParseToInt(memberID) == -1)
            {
                NotificationServices.GetInstance().ShowError("Member ID should be an integer!", "Error memberID");
                return false;
            }
            if (dueDate.CompareTo(DateTime.Today) < 0)
            {
                NotificationServices.GetInstance().ShowError("Due Date should be equal to or greater than today!", "Error DueDate");
                return false;
            }
            return true;
        }

        private bool IsValidProductType(string type)
        {
            if (!type.Equals(ProductType.Books.ToString()) && !type.Equals(ProductType.Devices.ToString()) && !type.Equals(ProductType.All.ToString()))
                return false;
            return true;
        }

        // NOTE: EVENT FOR COMPONENT
        private void txtGetBorrowMemberID_Click(object sender, EventArgs e)
        {
            if (txtGetBorrowMemberID.Text.Equals(defaultMemberIDField))
                txtGetBorrowMemberID.Clear();
        }

        private void btnSubmitFormBorrow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExitBorrowProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!IsValidProductType(cbxTypeProduct.Text))
            {
                NotificationServices.GetInstance().ShowError("Select type of product!", "Select type");
                return;
            }
            
        }

        private void btnResetFormBorrow_Click(object sender, EventArgs e)
        {
            txtGetBorrowMemberID.Text = "";
            dtpGetBorrowDueDate.Value = DateTime.Now;
            dgvListProducts.DataSource = null;
        }

        private void btnEditListProducts_Click(object sender, EventArgs e)
        {
            if (dgvListProducts == null || dgvListProducts.Columns["Amount"] == null)
            {
                NotificationServices.GetInstance().ShowError("Not found data!", "Not found");
                return;
            }

            dgvListProducts.ReadOnly = false;
            dgvListProducts.Columns["Product Name"].ReadOnly = true;
            dgvListProducts.Columns["ID"].ReadOnly = true;
            MessageBox.Show("You can now edit the 'Amount' column.");
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            //dgvListProducts.EndEdit();
            //dgvListProducts.Columns["Amount"].ReadOnly = true;
            //SetViewForTable(GetNewTable());
            //MessageBox.Show("Changes saved successfully.");
        }

        private void dgvListProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvListProducts.CurrentCell.ColumnIndex == dgvListProducts.Columns["Amount"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= onlyNumbers_KeyPress; // tránh trùng event nhiều lần
                    tb.KeyPress += onlyNumbers_KeyPress;
                }
            }
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ nhận số và phím điều khiển (backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
