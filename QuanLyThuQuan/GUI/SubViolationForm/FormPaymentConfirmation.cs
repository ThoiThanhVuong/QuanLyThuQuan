using QuanLyThuQuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.SubViolationForm
{
    public partial class FormPaymentConfirmation: Form
    {
        public FormPaymentConfirmation()
        {
            InitializeComponent();
        }
        public FormPaymentConfirmation(int violationID)
        {
            InitializeComponent();
            var payment = new PaymentBUS().GetPaymentByViolationID(violationID);
            if (payment != null)
            {
                txtViolation.Text = payment.ViolationID.ToString();
                txtMemberID.Text = payment.MemberID.ToString();
                txtTransactionID.Text = payment.TransactionID?.ToString() ?? "";
                txtTotalPayment.Text = payment.Amount.ToString("N0");
                txtDesc.Text = payment.Description;
                txtStatus.Text = payment.Status.ToString();
            }
            txtViolation.ReadOnly = true;
            txtMemberID.ReadOnly = true;
            txtTransactionID.ReadOnly = true;
            txtTotalPayment.ReadOnly = true;
            txtDesc.ReadOnly = true;
            txtStatus.ReadOnly = true;
            if (txtStatus.Text == "Paid")
            {
                btnConfirmPayment.Enabled = false;
                btnConfirmPayment.Text = "Đã thanh toán";
                btnConfirmPayment.BackColor = Color.Gray;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            int violationID = int.Parse(txtViolation.Text);

            var paymentSuccess = new PaymentBUS().MarkAsPaidByViolationID(violationID);

            if (paymentSuccess)
            {
                // Sau khi thanh toán thành công thì cập nhật trạng thái vi phạm
                new ViolationBUS().MarkViolationAsHandled(violationID);

                MessageBox.Show("Đã xác nhận thanh toán và cập nhật trạng thái xử lý!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi xác nhận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
