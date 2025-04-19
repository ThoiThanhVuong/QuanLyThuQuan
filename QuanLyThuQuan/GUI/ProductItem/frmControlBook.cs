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

            }
            else
            {
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
                    bookImageName = Path.GetFileName(relativePath);

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
                    MessageBox.Show("Tên sách không được bỏ trống.");
                if (string.IsNullOrWhiteSpace(txtMaTacGia.Text))
                    MessageBox.Show("Tác giả không được bỏ trống.");
                if (string.IsNullOrWhiteSpace(txtGiaThue.Text))
                    MessageBox.Show("Giá thuê không được bỏ trống.");
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                    MessageBox.Show("Số lượng không được bỏ trống.");
                if (cbbBookType.SelectedItem == null)
                    MessageBox.Show("Thể loại không được bỏ trống.");
                if (string.IsNullOrWhiteSpace(bookImageName))
                    MessageBox.Show("Ảnh không được bỏ trống.");



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
                        ProductStatus.Available,
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
                       ProductStatus.Available,
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
