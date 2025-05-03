using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Transactions;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormBorrowBook : Form
    {
        private TransactionBUS trans = new TransactionBUS();
        private BookBUS bookBUS = new BookBUS();
        private DeviceBUS deviceBUS = new DeviceBUS();
        private bool isFromReservation = false;
        private int transferredTransactionID = -1;
        public FormBorrowBook()
        {
            InitializeComponent();
         
        }

        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.DoubleBuffered = true;
            LoadValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // hàm load dữ liệu từ database lên và đưa vào combobox
        public void LoadDataForTextProductName()
        {
            if (cbbProductType.Text.Equals("Sách"))
            {
                List<BookModel> books = bookBUS.GetAllBooks();
                cbbProductName.Items.Clear();
                foreach(var book in books)
                {
                    cbbProductName.Items.Add(book.BookTitle);
                }

            }
            else if (cbbProductType.Text.Equals("Thiết bị"))
            {
                List<DeviceModel> devices = deviceBUS.GetAllDevices();
                cbbProductName.Items.Clear();
                foreach(var device in devices)
                {
                    cbbProductName.Items.Add(device.DeviceName);
                }
            }
            dgvBorrowItems.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBorrowItems.Columns[6].DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            dgvBorrowItems.Columns[6].DefaultCellStyle.ForeColor = Color.Red;
        }

        public void LoadValue()
        {
            cbbProductType.Items.Clear();
            cbbProductType.Items.Add("Sách");
            cbbProductType.Items.Add("Thiết bị");
            cbbProductType.SelectedIndex = 0;
            LoadDataForTextProductName();
            DTDueDate.Format = DateTimePickerFormat.Custom;
            DTDueDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";  
            DTDueDate.ShowUpDown = true;
        }

        private void cbbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProductType.SelectedItem != null)
            {
                LoadDataForTextProductName();
            }
        }
        // hàm kiểm tra xem thành viên có lỗi vi phạm nào không
        private void btnCheckViolation_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMemberID.Text, out int memberID))
            {
                int violationCount = new ViolationBUS().checkCountViolationByID(memberID);

                if (violationCount > 3)
                {
                    MessageBox.Show($"Thành viên đã vi phạm {violationCount} lần! Vui lòng xem xét cảnh báo.",
                                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Thành viên chỉ vi phạm {violationCount} lần. Không vượt quá giới hạn.",
                                    "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã thành viên không hợp lệ. Vui lòng nhập số nguyên!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberID.Focus();
            }

        }
        // hàm sự kiện thêm 1 chi tiết sản phẩm vào datagridview
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbProductName.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.");
                return;
            }

            if (!int.TryParse(txtAmount.Text, out int addAmount) || addAmount <= 0)
            {
                MessageBox.Show("Số lượng phải là số dương.");
                return;
            }

            string productType = cbbProductType.Text;
            string productName = cbbProductName.Text;
            int availableStock = 0;
            int currentBorrowedAmount = 0;
           
            if (productType == "Sách")
            {
                BookModel book = bookBUS.GetBookByName(productName);
                availableStock = book.BookQuantity;

                foreach (DataGridViewRow row in dgvBorrowItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[1].Value?.ToString() == book.BookID.ToString())
                    {
                        currentBorrowedAmount += Convert.ToInt32(row.Cells[5].Value);
                    }
                }

                if (currentBorrowedAmount + addAmount > availableStock)
                {
                    MessageBox.Show("Số lượng sách không đủ để mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool updated = false;
                foreach (DataGridViewRow row in dgvBorrowItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[1].Value?.ToString() == book.BookID.ToString())
                    {
                        row.Cells[5].Value = Convert.ToInt32(row.Cells[5].Value) + addAmount;
                        updated = true;
                        break;
                    }
                }
                if (!updated)
                {
                    dgvBorrowItems.Rows.Add(dgvBorrowItems.Rows.Count + 1, book.BookID, book.BookTitle, "", "", addAmount,"X");
                }
            }
            else if (productType == "Thiết bị")
            {
                DeviceModel device = deviceBUS.GetDeviceByName(productName);
                availableStock = device.DeviceQuantity;

                foreach (DataGridViewRow row in dgvBorrowItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[3].Value?.ToString() == device.DeviceID.ToString())
                    {
                        currentBorrowedAmount += Convert.ToInt32(row.Cells[5].Value);
                    }
                }

                if (currentBorrowedAmount + addAmount > availableStock)
                {
                    MessageBox.Show("Số lượng thiết bị không đủ để mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool updated = false;
                foreach (DataGridViewRow row in dgvBorrowItems.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[3].Value?.ToString() == device.DeviceID.ToString())
                    {
                        row.Cells[5].Value = Convert.ToInt32(row.Cells[5].Value) + addAmount;
                        updated = true;
                        break;
                    }
                }
                if (!updated)
                {
                    dgvBorrowItems.Rows.Add(dgvBorrowItems.Rows.Count + 1, "", "", device.DeviceID, device.DeviceName, addAmount,"X");
                }
            }

            cbbProductName.SelectedIndex = -1;
            txtAmount.Clear();
        }

        // hàm sự kiện cho button xác nhận mượn
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID thành viên
            if (!int.TryParse(txtMemberID.Text, out int memberID))
            {
                MessageBox.Show("ID thành viên không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra có sản phẩm nào được mượn chưa
            if (dgvBorrowItems.Rows.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm cần mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số lượng từng sản phẩm so với tồn kho
            foreach (DataGridViewRow row in dgvBorrowItems.Rows)
            {
                if (row.IsNewRow) continue;

                int? bookID = string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()) ? null : (int?)Convert.ToInt32(row.Cells[1].Value);
                int? deviceID = string.IsNullOrWhiteSpace(row.Cells[3].Value?.ToString()) ? null : (int?)Convert.ToInt32(row.Cells[3].Value);
                int amount = Convert.ToInt32(row.Cells[5].Value);

                if (amount <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (bookID.HasValue)
                {
                    BookModel book = bookBUS.GetBookByID(bookID.Value);
                    if (amount > book.BookQuantity)
                    {
                        MessageBox.Show($"Sách \"{book.BookTitle}\" chỉ còn {book.BookQuantity} cuốn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (deviceID.HasValue)
                {
                    DeviceModel device = deviceBUS.GetDeviceByID(deviceID.Value);
                    if (amount > device.DeviceQuantity)
                    {
                        MessageBox.Show($"Thiết bị \"{device.DeviceName}\" chỉ còn {device.DeviceQuantity} cái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Nếu tất cả kiểm tra OK thì mới bắt đầu tạo transaction
            TransactionModel transaction = new TransactionModel
            {
                MemberID = memberID,
                TransactionDate = DateTime.Now,
                DueDate = DTDueDate.Value,
                Status = Model.TransactionStatus.Active,
                TransactionType = TransactionType.Borrow,
                TransactionItems = new List<TransactionItemModel>()
            };

            foreach (DataGridViewRow row in dgvBorrowItems.Rows)
            {
                if (row.IsNewRow) continue;

                int? bookID = string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()) ? null : (int?)Convert.ToInt32(row.Cells[1].Value);
                int? deviceID = string.IsNullOrWhiteSpace(row.Cells[3].Value?.ToString()) ? null : (int?)Convert.ToInt32(row.Cells[3].Value);
                int amount = Convert.ToInt32(row.Cells[5].Value);

                var item = new TransactionItemModel
                {
                    BookID = bookID,
                    DeviceID = deviceID,
                    Amount = amount,
                   
                };

                transaction.TransactionItems.Add(item);
            }
            if (isFromReservation && transferredTransactionID != -1)
            {
                bool updated = trans.UpdateDueDate(transferredTransactionID, DTDueDate.Value);
                if (updated)
                {
                    MessageBox.Show("Đã cập nhật hạn trả cho giao dịch đã chuyển từ đặt trước.", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật hạn trả.", "Lỗi");
                }
                return;
            }
            else
            {
                var success = trans.AddTransactionWithItems(transaction);
                if (success)
                {
                    MessageBox.Show("Giao dịch mượn đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm giao dịch.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // hàm sự kiện xóa 1 chi tiết giao dịch
        private void dgvBorrowItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) 
            {
                dgvBorrowItems.Rows.RemoveAt(e.RowIndex);
            }
        }
        // hàm sự kiện cho chỉnh sửa value cột amount
        private void dgvBorrowItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) // Cột Amount
            {
                var row = dgvBorrowItems.Rows[e.RowIndex];

                int maxAvailable = 0;
                int currentTotal = 0;
                string productType = "";

                if (!string.IsNullOrEmpty(row.Cells[1].Value?.ToString())) 
                {
                    int bookID = Convert.ToInt32(row.Cells[1].Value);
                    BookModel book = bookBUS.GetBookByID(bookID);
                    maxAvailable = book.BookQuantity;
                    productType = "Sách";
                }
                else if (!string.IsNullOrEmpty(row.Cells[3].Value?.ToString())) 
                {
                    int deviceID = Convert.ToInt32(row.Cells[3].Value);
                    DeviceModel device = deviceBUS.GetDeviceByID(deviceID);
                    maxAvailable = device.DeviceQuantity;
                    productType = "Thiết bị";
                }

                if (!int.TryParse(row.Cells[5].Value?.ToString(), out int editedAmount) || editedAmount <= 0)
                {
                    MessageBox.Show("Số lượng phải là số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[5].Value = 1;
                    return;
                }

                // Tính tổng số lượng hiện tại sau khi chỉnh
                foreach (DataGridViewRow r in dgvBorrowItems.Rows)
                {
                    if (r.IsNewRow) continue;

                    if (productType == "Sách" && r.Cells[1].Value?.ToString() == row.Cells[1].Value?.ToString())
                        currentTotal += Convert.ToInt32(r.Cells[5].Value);
                    else if (productType == "Thiết bị" && r.Cells[3].Value?.ToString() == row.Cells[3].Value?.ToString())
                        currentTotal += Convert.ToInt32(r.Cells[5].Value);
                }

                if (currentTotal > maxAvailable)
                {
                    MessageBox.Show($"{productType} không đủ số lượng tồn kho.\nTồn kho còn: {maxAvailable}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    row.Cells[5].Value = 1;
                }
            }
        }
        public void SetFromReservation(ReservationModel reservation, int transactionID)
        {
            isFromReservation = true;
            transferredTransactionID = transactionID;

            txtMemberID.Text = reservation.MemberID.ToString();
            dgvBorrowItems.Rows.Clear();

            foreach (var item in reservation.Items)
            {
                string bookTitle = item.BookID.HasValue ? bookBUS.GetBookByID(item.BookID.Value).BookTitle : "";
                string deviceName = item.DeviceID.HasValue ? deviceBUS.GetDeviceByID(item.DeviceID.Value).DeviceName : "";

                dgvBorrowItems.Rows.Add(
                    dgvBorrowItems.Rows.Count + 1,
                    item.BookID?.ToString() ?? "",
                    bookTitle,
                    item.DeviceID?.ToString() ?? "",
                    deviceName,
                    item.Amount,
                    "X"
                );
            }


        }

    }
}
