using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormDevice : Form
    {
        private DeviceBUS deviceBUS = new DeviceBUS();
        public FormDevice()
        {
            InitializeComponent();
        }

        private void FormDevice_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<DeviceModel> devices = deviceBUS.GetAllDevices();
                if (devices == null || devices.Count == 0)
                {
                    Console.WriteLine("Không có dữ liệu thiết bị!");
                }
                else
                {
                    dgvDevices.Rows.Clear();

                    foreach (var device in devices)
                    {
                        dgvDevices.Rows.Add(
                            device.DeviceID,
                            device.DeviceName,
                            device.DeviceType,
                            device.FeePerHour,
                            device.DeviceQuantity,
                            device.DeviceStatus
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
            }



        }
        private int selectedRowIndex = -1;
        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                string deviceID = dgvDevices.Rows[selectedRowIndex].Cells["DeviceID"].Value.ToString();
                string deviceName = dgvDevices.Rows[selectedRowIndex].Cells["DeviceName"].Value.ToString();
                string deviceType = dgvDevices.Rows[selectedRowIndex].Cells["DeviceType"].Value.ToString();
                string feePerHour = dgvDevices.Rows[selectedRowIndex].Cells["FeePerHour"].Value.ToString();
                string deviceQuantity = dgvDevices.Rows[selectedRowIndex].Cells["DeviceQuantity"].Value.ToString();
                string status = dgvDevices.Rows[selectedRowIndex].Cells["Status"].Value.ToString();
                DeviceModel device = deviceBUS.GetDeviceByID(int.Parse(deviceID));
                Console.WriteLine(device);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị trước khi xem!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
