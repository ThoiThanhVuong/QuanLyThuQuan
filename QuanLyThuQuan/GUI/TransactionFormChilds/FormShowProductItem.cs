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

namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    public partial class FormShowProductItem: Form
    {
        private string productImage = string.Empty;
        private int itemID;
        private TransactionItemStatus itemStatus;
        public FormShowProductItem()
        {
            InitializeComponent();
        }
        public void SetValueWithID(int itemID, TransactionItemStatus status, BookModel book, DeviceModel device)
        {
            this.itemID = itemID;
            this.itemStatus = status;
            setvalue(book, device);

            // Kiểm tra trạng thái để ẩn/hiện nút nếu item đã trả rồi thì ẩn nút
            if (itemStatus == TransactionItemStatus.Returned)
            {
                btnReturnItem.Visible = false; 
                btnReturnItem.Enabled = false;
            }
            else
            {
                btnReturnItem.Visible = true; 
                btnReturnItem.Enabled = true;
            }
        }
        public void setvalue(BookModel book,DeviceModel device)
        {
            if(book == null)
            {
                pnTacGia.Visible = false;
                pnPublisYear.Visible = false;
            }
            else
            {
                pnTacGia.Visible = true;
                pnPublisYear.Visible = true;
                txtProductID.Text = book.BookID + "";
                txtProductName.Text = book.BookTitle;
                txtAuthor.Text = book.Author.AuthorName;
                txtPublisYear.Text = book.PublisYear+"";
                string relativePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Books", book.BookImage);
                string fullPath = Path.GetFullPath(relativePath);

                if (File.Exists(fullPath))
                {
                    try
                    {
                        // Kiểm tra dung lượng file có hợp lệ không
                        FileInfo fileInfo = new FileInfo(fullPath);
                        if (fileInfo.Length == 0)
                        {
                            MessageBox.Show("File ảnh bị rỗng: " + fullPath);
                            return;
                        }

                        // Giải phóng bộ nhớ trước khi load ảnh mới
                        if (ptrProduct.Image != null)
                        {
                            ptrProduct.Image.Dispose();
                            ptrProduct.Image = null;
                        }

                        // Load ảnh bằng MemoryStream để tránh lỗi
                        byte[] imageBytes = File.ReadAllBytes(fullPath);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            ptrProduct.Image = Image.FromStream(ms);
                        }
                        ptrProduct.SizeMode = PictureBoxSizeMode.Zoom;
                        productImage = Path.GetFileName(relativePath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi load ảnh: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ảnh không tồn tại: " + fullPath);
                }
            }
            if (device != null)
            {
                txtProductID.Text = device.DeviceID+"";
                txtProductName.Text = device.DeviceName;
                string relativePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Devices", device.DeviceImage);
                string fullPath = Path.GetFullPath(relativePath);

                if (File.Exists(fullPath))
                {
                    try
                    {
                        // Kiểm tra dung lượng file có hợp lệ không
                        FileInfo fileInfo = new FileInfo(fullPath);
                        if (fileInfo.Length == 0)
                        {
                            MessageBox.Show("File ảnh bị rỗng: " + fullPath);
                            return;
                        }

                        // Giải phóng bộ nhớ trước khi load ảnh mới
                        if (ptrProduct.Image != null)
                        {
                            ptrProduct.Image.Dispose();
                            ptrProduct.Image = null;
                        }

                        // Load ảnh bằng MemoryStream để tránh lỗi
                        byte[] imageBytes = File.ReadAllBytes(fullPath);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            ptrProduct.Image = Image.FromStream(ms);
                        }
                        ptrProduct.SizeMode = PictureBoxSizeMode.Zoom;
                        productImage = Path.GetFileName(relativePath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi load ảnh: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ảnh không tồn tại: " + fullPath);
                }
            }

             panel3.Enabled = false;
            panel5.Enabled = false;
            pnTacGia.Enabled = false;
            pnPublisYear.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            var bus = new TransactionBUS();
            bool success = bus.ReturnSingleItem(itemID);
            if (success)
            {
                MessageBox.Show("Đã trả thành công món!");
                this.DialogResult = DialogResult.OK; // để bên FormInformation biết
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi trả món!");
            }
        }
    }
}
