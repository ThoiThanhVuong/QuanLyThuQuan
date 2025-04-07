using QuanLyThuQuan.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.ProductItem
{
    public partial class frmControlBook : Form
    {
        public frmControlBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetLabelAndButtonText(string labelText, string buttonText)
        {
            txtBookControl.Text = labelText;
            if (string.IsNullOrWhiteSpace(buttonText))
            {
                btnBookControl.Visible = false;
                btnUpLoadImg.Visible = false;

            }
            else
            {
                btnBookControl.Visible = true;
                btnBookControl.Text = buttonText;
            }

        }
        public void SetValue(BookModel book)
        {
            txtMaSach.Text = book.BookID + "";
            txtTenSach.Text = book.BookTitle;
            txtMaTacGia.Text = book.Author.AuthorName;
            txtTheLoai.Text = book.Category.CategoryName;
            txtPublishYear.Text = book.PublisYear + "";
            txtGiaThue.Text = book.FeePerDay + "";
            txtSoLuong.Text = book.BookQuantity + "";
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
                    if (ptrBook.Image != null)
                    {
                        ptrBook.Image.Dispose();
                        ptrBook.Image = null;
                    }

                    // Load ảnh bằng MemoryStream để tránh lỗi
                    byte[] imageBytes = File.ReadAllBytes(fullPath);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptrBook.Image = Image.FromStream(ms);
                    }
                    ptrBook.SizeMode = PictureBoxSizeMode.Zoom;
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
            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtMaTacGia.ReadOnly = true;
            txtGiaThue.ReadOnly = true;
            txtPublishYear.ReadOnly = true;
            txtTheLoai.ReadOnly = true;
            txtSoLuong.ReadOnly = true;


        }
    }
}
