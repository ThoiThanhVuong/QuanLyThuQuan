using MySql.Data.MySqlClient;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.ProductItem
{
    public partial class frmControlDevice: Form
    {
        private string ControlImageName = string.Empty;
        private DeviceBUS deviceBUS = new DeviceBUS();
        public frmControlDevice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        public void SetLabelAndButtonText(string labelText, string buttonText)
        {
            txtDeviceControl.Text = labelText;
            if (string.IsNullOrWhiteSpace(buttonText))
            {
                btnDeviceControl.Visible = false;
                btnUpLoadImg.Visible = false;
                txtDeviceID.ReadOnly = true;
                txtDeviceName.ReadOnly = true;
                txtGiaThue.ReadOnly = true;
                txtTheLoai.ReadOnly = true;
                txtSoLuong.ReadOnly = true;
                txtTheLoai.Visible = true;
                cbbDeviceType.Visible = false;
                

            }
            else
            {
                btnDeviceControl.Visible = true;
                btnDeviceControl.Text = buttonText;
                txtDeviceID.ReadOnly = true;
                txtDeviceName.ReadOnly = false;           
                txtGiaThue.ReadOnly = false;
                txtTheLoai.ReadOnly = false;
                txtSoLuong.ReadOnly = false;
                cbbDeviceType.Visible = true;
                txtTheLoai.Visible = false;
                LoadDeviceTypes();

            }

        }
        public void LoadDeviceTypes()
        {
            try
            {
                List<string> deviceTypes = deviceBUS.GetDeviceType(); 
                
                cbbDeviceType.Items.Clear();  
             
                foreach (string deviceType in deviceTypes)
                {
                    cbbDeviceType.Items.Add(deviceType);  
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thể loại thiết bị: " + ex.Message);
            }
        }

        public void SetValue(DeviceModel device)
        {
            txtDeviceID.Text = device.DeviceID + "";
            txtDeviceName.Text = device.DeviceName;
            txtTheLoai.Text = device.DeviceType;
            cbbDeviceType.Text = device.DeviceType;
            txtGiaThue.Text = device.FeePerHour + "";
            txtSoLuong.Text = device.DeviceQuantity + "";

            // xử lý hiển thị ảnh
           string relativePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Devices", device.DeviceImage);
            string fullPath = Path.GetFullPath(relativePath);

            string defaultImagePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Devices", "noimage.jpg");
            defaultImagePath = Path.GetFullPath(defaultImagePath);
            try
            {
                // Nếu file không tồn tại thì dùng ảnh mặc định
                string imagePathToUse = File.Exists(fullPath) ? fullPath : defaultImagePath;

                // Kiểm tra lần nữa nếu cả ảnh mặc định cũng không có
                if (!File.Exists(imagePathToUse))
                {
                    ptrDevice.Image = null;
                    ptrDevice.BackColor = Color.LightGray;


                    // Hiển thị chữ "No Image"
                    using (Bitmap bmp = new Bitmap(ptrDevice.Width, ptrDevice.Height))
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.LightGray);
                        using (Font font = new Font("Arial", 14))
                        {
                            g.DrawString("No Image", font, Brushes.Black, new PointF(10, ptrDevice.Height / 2 - 10));
                        }
                        ptrDevice.Image = (Image)bmp.Clone();
                    }
                }
                else
                {
                    if (ptrDevice.Image != null)
                    {
                        ptrDevice.Image.Dispose();
                        ptrDevice.Image = null;
                    }

                    byte[] imageBytes = File.ReadAllBytes(imagePathToUse);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptrDevice.Image = Image.FromStream(ms);
                    }
                    ptrDevice.SizeMode = PictureBoxSizeMode.Zoom;
                }

                ControlImageName = Path.GetFileName(device.DeviceImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load ảnh: " + ex.Message);
            }

            txtDeviceID.ReadOnly = true;
            txtDeviceName.ReadOnly = false;
            txtGiaThue.ReadOnly = false;
            txtTheLoai.ReadOnly = false;
            txtSoLuong.ReadOnly = false;

        }

        private void btnDeviceControl_Click(object sender, EventArgs e)
        {
            try {
                string txtButton = btnDeviceControl.Text;
                string deviceName = txtDeviceName.Text.Trim();
                string deviceType = cbbDeviceType.Text.Trim();
                int feePerHour = int.Parse(txtGiaThue.Text.Trim());
                int quantity = int.Parse(txtSoLuong.Text.Trim());
                if (string.IsNullOrWhiteSpace(deviceName) || string.IsNullOrWhiteSpace(deviceType) || feePerHour <= 0 || quantity <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin thiết bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtButton.Equals("Thêm"))
                {
                    DeviceModel device = new DeviceModel(
                            deviceName,
                            ControlImageName,
                            deviceType,
                            quantity,
                            ProductStatus.Available,
                            feePerHour
                     );
                    bool result = deviceBUS.AddDevice(device);
                    if (result)
                    {
                        MessageBox.Show("Thiết bị đã được thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thiết bị.");
                    }

                } 
                else if(txtButton.Equals("Cập nhật"))
                {
                    int DeviceID = int.Parse(txtDeviceID.Text);
                    bool result = deviceBUS.UpdateDevice(new DeviceModel(
                        DeviceID,
                        deviceName,
                        ControlImageName,
                        deviceType,
                        quantity,
                        ProductStatus.Available,
                        feePerHour

                     ));
                    if (result)
                    {
                        MessageBox.Show("Sửa dữ liệu! thành công!");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thiết bị.");
                    }
                }
               

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thao tác: " + ex.Message);
            }
        }

        private void btnUpLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";
            openFileDialog.Title = "Chọn ảnh thiết bị";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;


                    FileInfo fileInfo = new FileInfo(filePath);
                    if (fileInfo.Length > 10 * 1024 * 1024) 
                    {
                        MessageBox.Show("File quá lớn. Vui lòng chọn file khác.");
                        return;
                    }


                    string fileName = Path.GetFileName(filePath);

                    // Hiển thị ảnh lên PictureBox
                    ptrDevice.Image = Image.FromFile(filePath);
                    ptrDevice.SizeMode = PictureBoxSizeMode.Zoom;


                    ControlImageName = fileName;

                    MessageBox.Show("Ảnh đã được tải lên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                }
            }
        }
    }
}
