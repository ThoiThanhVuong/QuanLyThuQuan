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

        public FormShowProductItem()
        {
            InitializeComponent();
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
    }
}
