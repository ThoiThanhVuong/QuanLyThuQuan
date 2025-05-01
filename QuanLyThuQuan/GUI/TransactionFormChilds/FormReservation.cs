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
        private ResevationBUS resevationBUS = new ResevationBUS();
        private BookBUS bookBUS = new BookBUS();
        private DeviceBUS deviceBUS = new DeviceBUS();

        public FormReservation()
        {
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            LoadPendingReservations();
        }

        private void LoadPendingReservations()
        {
            dgvReservations.Rows.Clear();
            List<ReservationModel> reservations = resevationBUS.GetAllReservationsWithItems();

            int index = 1;
            foreach (var reservation in reservations)
            {
                dgvReservations.Rows.Add(index++, reservation.MemberID, reservation.StartTime, reservation.EndTime, reservation.Status.ToString(), "...", reservation.ReservationID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int reservationID = Convert.ToInt32(dgvReservations.Rows[e.RowIndex].Cells["ResevationID"].Value);
                var reservation = resevationBUS.GetReservationByID(reservationID);

                if (reservation == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu đặt trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị chi tiết item
                string message = $"Danh sách sản phẩm đã đặt:\n\n";
                foreach (var item in reservation.Items)
                {
                    if (item.BookID.HasValue)
                    {
                        var book = bookBUS.GetBookByID(item.BookID.Value);
                        message += $"- Sách: {book.BookTitle} (Số lượng: {item.Amount})\n";
                    }
                    else if (item.DeviceID.HasValue)
                    {
                        var device = deviceBUS.GetDeviceByID(item.DeviceID.Value);
                        message += $"- Thiết bị: {device.DeviceName} (Số lượng: {item.Amount})\n";
                    }
                }

                message += "\nBạn có muốn chuyển sang giao dịch mượn không?";

                DialogResult result = MessageBox.Show(message, "Chi tiết đặt trước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int transactionID = resevationBUS.ConfirmReservationAndTransfer(reservationID);
                    if (transactionID != -1)
                    {
                        MessageBox.Show("Chuyển sang giao dịch mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPendingReservations();

                        FormBorrowBook borrowForm = new FormBorrowBook();
                        borrowForm.SetFromReservation(reservation, transactionID);
                        borrowForm.ShowDialog();
                    }
                } else
                    {
                        MessageBox.Show("Lỗi khi chuyển giao dịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
