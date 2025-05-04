using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.ProductItem
{
    public partial class frmControlBook : Form
    {
        private CategoryBUS categoryBUS = new CategoryBUS();
        private BookBUS bookBUS = new BookBUS();
        private AuthorBUS authorBUS = new AuthorBUS();
        private string bookImageName = string.Empty;

        public frmControlBook()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCategories()
        {
            var categories = categoryBUS.GetAllCategories(); 
            cbbBookType.Items.Clear();
            foreach (var category in categories)
            {
                cbbBookType.Items.Add(category.CategoryName);
            }
            cbbStatus.Items.Clear();
            cbbStatus.DataSource = Enum.GetValues(typeof(ProductStatus));
            cbbStatus.SelectedIndex = 0;
        }
        public void SetLabelAndButtonText(string labelText, string buttonText)
        {
            txtBookControl.Text = labelText;
            if (string.IsNullOrWhiteSpace(buttonText))
            {
                btnBookControl.Visible = false;
                btnUpLoadImg.Visible = false;
                txtMaSach.ReadOnly = true;
                txtTenSach.ReadOnly = true;
                txtMaTacGia.ReadOnly = true;
                txtGiaThue.ReadOnly = true;
                txtPublishYear.ReadOnly = true;
                txtTheLoai.ReadOnly = true;
                txtSoLuong.ReadOnly = true;
                cbbBookType.Visible = false;
                txtTheLoai.Visible = true;
                pnStatus.Visible = false;

            }
            else
            {
                if(labelText.Equals("Thêm Mới"))
                {
                    txtMaSach.Text = bookBUS.GenerateNewBookCode()+"";
                }
                btnBookControl.Visible = true;
                btnBookControl.Text = buttonText;
                txtMaSach.ReadOnly = true;
                txtTenSach.ReadOnly = false;
                txtMaTacGia.ReadOnly = false;
                txtGiaThue.ReadOnly = false;
                txtPublishYear.ReadOnly = false;
                txtTheLoai.ReadOnly = false;
                txtSoLuong.ReadOnly = false;
                cbbBookType.Visible = true;
                txtTheLoai.Visible = false;
                LoadCategories();
                pnStatus.Visible = true;
            }

        }
        public void SetValue(BookModel book)
        {
            txtMaSach.Text = book.BookID + "";
            txtTenSach.Text = book.BookTitle;
            txtMaTacGia.Text = book.Author.AuthorName;
            txtTheLoai.Text = book.Category.CategoryName;
            cbbBookType.Text = book.Category.CategoryName;
            txtPublishYear.Text = book.PublisYear + "";
            txtGiaThue.Text = book.FeePerDay + "";
            txtSoLuong.Text = book.BookQuantity + "";
            cbbStatus.Text = book.BookStatus.ToString();
            string relativePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Books", book.BookImage);
            string fullPath = Path.GetFullPath(relativePath);

            string defaultImagePath = Path.Combine("..", "..", "..", "QuanLyThuQuan", "Public", "Img", "Books", "noimage.jpg");
            defaultImagePath = Path.GetFullPath(defaultImagePath);

            string imagePathToUse = File.Exists(fullPath) ? fullPath : defaultImagePath;

            if (!File.Exists(imagePathToUse))
            {
                ptrBook.Image = null;
                ptrBook.BackColor = Color.LightGray;
                ptrBook.BorderStyle = BorderStyle.FixedSingle;

                using (Bitmap bmp = new Bitmap(ptrBook.Width, ptrBook.Height))
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.LightGray);
                    using (Font font = new Font("Arial", 14))
                    {
                        g.DrawString("No Image", font, Brushes.Black, new PointF(10, ptrBook.Height / 2 - 10));
                    }
                    ptrBook.Image = (Image)bmp.Clone();
                }
            }
            else
            {
                if (ptrBook.Image != null)
                {
                    ptrBook.Image.Dispose();
                    ptrBook.Image = null;
                }

                byte[] imageBytes = File.ReadAllBytes(imagePathToUse);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    ptrBook.Image = Image.FromStream(ms);
                }
                ptrBook.SizeMode = PictureBoxSizeMode.Zoom;
            }

            bookImageName = Path.GetFileName(book.BookImage);

            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = false;
            txtMaTacGia.ReadOnly = false;
            txtGiaThue.ReadOnly = false;
            txtPublishYear.ReadOnly = false;
            txtTheLoai.ReadOnly = false;
            txtSoLuong.ReadOnly = false;

        }

        private void btnBookControl_Click(object sender, EventArgs e)
        {
            try
            {
              
                string txtButton = btnBookControl.Text;
                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Tên sách không được bỏ trống.");
                    txtTenSach.Focus();
                    return;
                } 
                if (string.IsNullOrWhiteSpace(txtMaTacGia.Text))
                {
                    MessageBox.Show("Tác giả không được bỏ trống.");
                    txtMaTacGia.Focus();
                    return;
                }      
                if (string.IsNullOrWhiteSpace(txtGiaThue.Text))
                {
                    MessageBox.Show("Giá thuê không được bỏ trống.");
                    txtGiaThue.Focus();
                    return;
                }       
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng không được bỏ trống.");
                    txtSoLuong.Focus();
                    return;
                }   
                if (cbbBookType.SelectedItem == null)
                {
                    MessageBox.Show("Thể loại không được bỏ trống.");
                    cbbBookType.Focus();
                    return;
                }      
                if (string.IsNullOrWhiteSpace(bookImageName))
                {
                    MessageBox.Show("Ảnh không được bỏ trống.");
                    return;
                }
                   



                if (!int.TryParse(txtPublishYear.Text, out int publishYear) || !int.TryParse(txtGiaThue.Text, out int feePerDay) || !int.TryParse(txtSoLuong.Text, out int quantity))
                {
                    MessageBox.Show("Năm xuất bản, giá thuê và số lượng phải là số.");
                    return;
                }
               
                // Lấy các giá trị từ form
                string bookTitle = txtTenSach.Text;
                string authorName = txtMaTacGia.Text;
                string categoryName = cbbBookType.SelectedItem.ToString();
                int authorID = authorBUS.GetAuthorByName(authorName);
                if (authorID == -1)
                {
                    bool addAuthor = authorBUS.AddAuthor(new AuthorModel(authorName, ActivityStatus.Active));
                    if (!addAuthor)
                    {
                        MessageBox.Show("có lỗi khi thêm tác giả");
                        return;
                    }
                    authorID = authorBUS.GetAuthorByName(authorName);
                }
                int categoryID = categoryBUS.GetCategoryIDByName(categoryName);
                if (categoryID == -1)
                {
                    bool addCategory = categoryBUS.AddCategory(new CategoriesModel(categoryName, ActivityStatus.Active));
                    if (!addCategory)
                    {
                        MessageBox.Show("Có lỗi khi thêm thể loại mới");
                        return;
                    }
                    categoryID = categoryBUS.GetCategoryIDByName(categoryName);
                }
               
                // Kiểm tra nếu là nút "Thêm"
                if (txtButton.Equals("Thêm"))
                {
                  
                    BookModel newBook = new BookModel(
                        bookTitle,
                        authorID,
                        bookImageName,
                        categoryID,
                        publishYear,
                        quantity,
                       (ProductStatus)Enum.Parse(typeof(ProductStatus), cbbStatus.SelectedItem.ToString()),
                        feePerDay
                       );
                    
                    bool result = bookBUS.AddBook(newBook); 
                    if (result)
                    {
                        MessageBox.Show("Sách đã được thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm sách.");
                    }
                }
          
                else if (txtButton.Equals("Cập nhật"))
                {
                    
                    int bookID = int.Parse(txtMaSach.Text);
                    bool result = bookBUS.UpdateBook(new BookModel(
                        bookID,
                        bookTitle,
                         authorID,
                        bookImageName,
                        categoryID,
                       publishYear,
                       quantity,
                       (ProductStatus)Enum.Parse(typeof(ProductStatus), cbbStatus.SelectedItem.ToString()),
                        feePerDay
                     ));
                    if(result)
                    {
                        MessageBox.Show("Sửa dữ liệu! thành công!");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa sách.");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực hiện thao tác: " + ex.Message);
            }
        }

        private void btnUpLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";
            openFileDialog.Title = "Chọn ảnh sách";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

         
                    FileInfo fileInfo = new FileInfo(filePath);
                    if (fileInfo.Length > 10 * 1024 * 1024) // 10 MB
                    {
                        MessageBox.Show("File quá lớn. Vui lòng chọn file khác.");
                        return;
                    }

                    
                    string fileName = Path.GetFileName(filePath);

                    // Hiển thị ảnh lên PictureBox
                    ptrBook.Image = Image.FromFile(filePath);  
                    ptrBook.SizeMode = PictureBoxSizeMode.Zoom;  

                        
                    bookImageName = fileName;

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
