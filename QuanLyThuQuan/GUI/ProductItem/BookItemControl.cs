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

            string defaultImagePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Books", "noimage.jpg");
            defaultImagePath = Path.GetFullPath(defaultImagePath);

            string imagePathToUse = File.Exists(fullPath) ? fullPath : defaultImagePath;

            if (!File.Exists(imagePathToUse))
            {
                pbBookCover.Image = null;
                pbBookCover.BackColor = Color.LightGray;
                pbBookCover.BorderStyle = BorderStyle.FixedSingle;

                using (Bitmap bmp = new Bitmap(pbBookCover.Width, pbBookCover.Height))
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.LightGray);
                    using (Font font = new Font("Arial", 14))
                    {
                        g.DrawString("No Image", font, Brushes.Black, new PointF(10, pbBookCover.Height / 2 - 10));
                    }
                    pbBookCover.Image = (Image)bmp.Clone();
                }
            }
            else
            {
                if (pbBookCover.Image != null)
                {
                    pbBookCover.Image.Dispose();
                    pbBookCover.Image = null;
                }

                byte[] imageBytes = File.ReadAllBytes(imagePathToUse);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pbBookCover.Image = Image.FromStream(ms);
                }
                pbBookCover.SizeMode = PictureBoxSizeMode.Zoom;
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
