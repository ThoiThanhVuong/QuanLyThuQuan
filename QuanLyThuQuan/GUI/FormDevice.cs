using QuanLyThuQuan.BUS;
using QuanLyThuQuan.GUI.ProductItem;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using QuanLyThuQuan.DAO;
namespace QuanLyThuQuan.GUI
{
    public partial class FormDevice : Form
    {
        private DeviceBUS deviceBUS = new DeviceBUS();
        private string lastSearchTerm = "";
        public FormDevice()
        {
            InitializeComponent();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
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
                List<string> deviceTypes = deviceBUS.GetDeviceType();

                cbbTypeDevice.Items.Clear();
                cbbTypeDevice.Items.Add("Thể Loại");
                foreach (string deviceType in deviceTypes)
                {
                    cbbTypeDevice.Items.Add(deviceType);
                }
                cbbTypeDevice.SelectedIndex = 0;
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
                DataGridViewRow row = dgvDevices.Rows[selectedRowIndex];
                DeviceModel device = deviceBUS.GetDeviceByID(int.Parse(row.Cells[0].Value?.ToString()));
                frmControlDevice controlDevice = new frmControlDevice();
                controlDevice.SetValue(device);
                controlDevice.SetLabelAndButtonText("Xem chi tiết", "");
                controlDevice.Height = 400;
                controlDevice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị trước khi xem!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmControlDevice controlDevice = new frmControlDevice();
            controlDevice.SetLabelAndButtonText("Thêm mới", "Thêm");
            controlDevice.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dgvDevices.Rows[selectedRowIndex];
                DeviceModel device = deviceBUS.GetDeviceByID(int.Parse(row.Cells[0].Value?.ToString()));

                frmControlDevice controlDevice = new frmControlDevice();
                controlDevice.SetValue(device);
                controlDevice.SetLabelAndButtonText("Chỉnh sửa", "Cập nhật");
                controlDevice.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dgvDevices.Rows[selectedRowIndex];
                int deviceID = Convert.ToInt32(row.Cells[0].Value);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xóa thiết bị", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = deviceBUS.DeleteDevice(deviceID);
                    if (success)
                    {
                        MessageBox.Show("Thiết bị đã được xóa thành công.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa thiết bị.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị để xóa.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (searchTerm != lastSearchTerm)
            {
                lastSearchTerm = searchTerm;
                searchTimer.Stop();
                searchTimer.Start();
            }
        }
        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            string keyword = txtSearch.Text.Trim();
            List<DeviceModel> devices = deviceBUS.SearchDevices(keyword);
            dgvDevices.Rows.Clear();
            if (devices.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thiết bị nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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

        private void cbbTypeDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeDevice.SelectedItem != null)
            {
                string selectedCategory = cbbTypeDevice.SelectedItem.ToString();
                Console.WriteLine(selectedCategory);

                if (selectedCategory == "Thể Loại")
                {
                    List<DeviceModel> devices = deviceBUS.GetAllDevices();
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
                else
                {
                    List<DeviceModel> devices = deviceBUS.GetDeviceByType(selectedCategory);
                    dgvDevices.Rows.Clear();
                    if (devices.Count > 0)
                    {
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
                    else
                    {
                        MessageBox.Show("Không tìm thấy thiết bị trong thể loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DeviceModel> ImportDevicesFromExcel(string filePath)
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            FileInfo fileInfo = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) 
                {
                    string deviceName = worksheet.Cells[row, 1].Text;
                    string deviceImage = worksheet.Cells[row, 2].Text;
                    string deviceType = worksheet.Cells[row, 3].Text;
                    int quantity = int.Parse(worksheet.Cells[row, 4].Text);
                    string statusStr = worksheet.Cells[row, 5].Text;
                    int feePerHour = int.Parse(worksheet.Cells[row, 6].Text);

                    ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), statusStr);

                    DeviceModel device = new DeviceModel(deviceName, deviceImage, deviceType, quantity, status, feePerHour);
                    devices.Add(device);
                }
            }
            return devices;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    List<DeviceModel> devices = ImportDevicesFromExcel(filePath);
                    int successCount = 0;

                    foreach (var device in devices)
                    {
                        if (deviceBUS.AddDevice(device))
                            successCount++;
                    }

                    MessageBox.Show($"Nhập thành công {successCount}/{devices.Count} thiết bị!", "Thông báo");
                    // Load lại bảng DataGridView nếu muốn
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi nhập Excel: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnRemoveByCondition_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa tất cả thiết bị có trạng thái 'Unavailable'?",
            "Xác nhận xóa theo điều kiện",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                int deletedCount = deviceBUS.DeleteDevicesByCondition();
                MessageBox.Show($"Đã xóa {deletedCount} thiết bị không còn sử dụng.", "Thông báo");
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteDeviceConditions deleteDeviceConditions = new DeleteDeviceConditions();
            deleteDeviceConditions.StartPosition = FormStartPosition.CenterParent;
            deleteDeviceConditions.ShowDialog();
        }
    }
}
