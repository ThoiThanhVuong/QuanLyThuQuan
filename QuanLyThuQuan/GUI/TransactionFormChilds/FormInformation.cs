using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    
    public partial class FormInformation : Form
    {
       
        private TransactionModel currentTransaction;
        private bool isReturned = false;
        public FormInformation()
        {
            InitializeComponent();
        }

        public FormInformation(string id)
        {
            
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }
        public void SetValue(TransactionModel trans)
        {
            currentTransaction = trans;
            var bus = new TransactionBUS();
            bus.LoadExtraDetails(trans);

            // Load thông tin giao dịch
            txtTransactionID.Text = trans.TransactionID.ToString();
            txtTransType.Text = trans.TransactionType.ToString();
            txtDate.Text = trans.TransactionDate.ToString("g");
            txtDueDate.Text = trans.DueDate?.ToString("g") ?? "";
            txtReturnDate.Text = trans.ReturnDate?.ToString("g") ?? "";
            txtMemberID.Text = trans.Member?.MemberID.ToString() ?? "";
            txtFullName.Text = trans.Member?.FullName ?? "";
            txtEmail.Text = trans.Member?.Email ?? "";
            txtPhoneNumber.Text = trans.Member?.PhoneNumber ?? "";

            dgvTransactionItem.Rows.Clear();
            dgvTransactionItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactionItem.Columns[5].DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            int index = 1;
            foreach (var item in trans.TransactionItems)
            {
                dgvTransactionItem.Rows.Add(
                    index++,
                    item.BookID?.ToString() ?? "",
                    item.DeviceID?.ToString() ?? "",
                    item.Amount,
                    item.Status.ToString(),
                    "..."
                );
            }

            LoadPayments(trans);

            

        // Ẩn nút xác nhận nếu giao dịch đã hoàn thành
            btnConfirmReturn.Enabled = (trans.Status == TransactionStatus.Active);
            btnConfirmReturn.Visible = (trans.Status == TransactionStatus.Active);
        }


        private void LoadPayments(TransactionModel trans)
        {
            txtTotalPayment.Text = trans.TotalPaymentAmount.ToString("N0") + " VND";
            if (trans.Payments.Count == 0)
            {
                txtStatusPayment.Text = "Không có giao dịch thanh toán";
                btnThanhToan.Visible = false;
            }
            else if (trans.Payments.All(p => p.Status == PaidStatus.Paid))
            {
                txtStatusPayment.Text = "Đã thanh toán";
                btnThanhToan.Visible = false;
            }
            else
            {
                txtStatusPayment.Text = "Chưa thanh toán";
                btnThanhToan.Visible = true;
            }


            dgvPayments.Rows.Clear();
            foreach (var pay in trans.Payments)
            {
                dgvPayments.Rows.Add(
                    pay.ViolationID.HasValue ? "Vi phạm" : "Mượn",
                    pay.Amount.ToString("N0") + " VND",
                    pay.Description
                );
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTransactionID.Text, out int transactionID))
            {
                MessageBox.Show("Không tìm thấy mã giao dịch.");
                return;
            }

            var bus = new TransactionBUS();
            var transaction = bus.GetTransactionByID(transactionID);
            bus.LoadExtraDetails(transaction);

            if (transaction.Status != TransactionStatus.Active)
            {
                MessageBox.Show("Giao dịch này đã hoàn tất.");
                return;
            }

            if (!isReturned)
            {
                bool success = bus.ConfirmReturnAndCalculatePayment(transactionID);
                if (success)
                {
                    isReturned = true;
                   

                    transaction = bus.GetTransactionByID(transactionID);
                    bus.LoadExtraDetails(transaction);
                    SetValue(transaction);
                    MessageBox.Show("Đã tính toán thanh toán cho các món còn Borrowed. Bấm xác nhận lần nữa để lưu trạng thái hoàn tất.");
                    //isReturned = false;
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xử lý trả.");
                }
            }
            else
            {
                transaction.Status = TransactionStatus.Completed;
                transaction.ReturnDate = DateTime.Now;
                bool updated = bus.UpdateTransactionWithItems(transaction);
                if (updated)
                {
                    MessageBox.Show("Trả thành công & đã cập nhật.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật trạng thái trả.");
                }

            }

        }

        private void dgvTransactionItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var item = currentTransaction.TransactionItems[e.RowIndex];
                int itemID = item.ItemID;
                int? bookID = item.BookID;
                int? deviceID = item.DeviceID;

                var form = new FormShowProductItem();

                if (bookID.HasValue)
                {
                    var book = new BookBUS().GetBookByID(bookID.Value);
                    form.SetValueWithID(itemID, item.Status, book, null);
                }
                else if (deviceID.HasValue)
                {
                    var device = new DeviceBUS().GetDeviceByID(deviceID.Value);
                    form.SetValueWithID(itemID, item.Status, null, device);
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // reload lại nếu thành công
                    var bus = new TransactionBUS();
                    var updatedTransaction = bus.GetTransactionByID(currentTransaction.TransactionID);
                    bus.LoadExtraDetails(updatedTransaction);
                    SetValue(updatedTransaction);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTransactionID.Text, out int transactionID))
            {
                MessageBox.Show("Không hợp lệ");
                return;
            }

            var paymentBUS = new PaymentBUS();
            var violationBUS = new ViolationBUS();
            var transactionBUS = new TransactionBUS();

            // Đánh dấu toàn bộ payment là đã thanh toán
            bool paidSuccess = paymentBUS.MarkAllPaymentsAsPaid(transactionID);

            // Cập nhật trạng thái violation thành Handled
            var violations = transactionBUS.GetViolationsByTransactionID(transactionID);
            foreach (var v in violations)
            {
                if (v.Status == "Pending")
                {
                    violationBUS.MarkViolationAsHandled(v.ViolationID);
                }
            }

            if (paidSuccess)
            {
                MessageBox.Show("Thanh toán thành công!");

                // Bắt buộc reload lại transaction để load các bản ghi Payment mới từ database
                var updatedTransaction = transactionBUS.GetTransactionByID(transactionID);
                transactionBUS.LoadExtraDetails(updatedTransaction);
                SetValue(updatedTransaction);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại.");
            }
        }
    }
}
