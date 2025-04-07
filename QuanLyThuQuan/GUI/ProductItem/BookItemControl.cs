using QuanLyThuQuan.BUS;
using QuanLyThuQuan.GUI.ProductItem;
using QuanLyThuQuan.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class BookItemControl : UserControl
    {
        BookBUS bookBUS = new BookBUS();
        public BookItemControl()
        {
            InitializeComponent();
        }

        public void SetData(BookModel book)
        {
            string relativePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Books", book.BookImage);
            string fullPath = Path.GetFullPath(relativePath);

            lblBookTitle.Text = book.BookTitle;

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
                    if (pbBookCover.Image != null)
                    {
                        pbBookCover.Image.Dispose();
                        pbBookCover.Image = null;
                    }

                    // Load ảnh bằng MemoryStream để tránh lỗi
                    byte[] imageBytes = File.ReadAllBytes(fullPath);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbBookCover.Image = Image.FromStream(ms);
                    }
                    pbBookCover.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmControlBook formDetailBook = new frmControlBook();
            // Gọi phương thức để đặt text cho label và button
            formDetailBook.SetLabelAndButtonText("Xem chi tiết", "");
            BookModel book = bookBUS.GetBookByName(lblBookTitle.Text);
            formDetailBook.SetValue(book);
            formDetailBook.Height = 400;
            formDetailBook.ShowDialog();


        }
    }
}
