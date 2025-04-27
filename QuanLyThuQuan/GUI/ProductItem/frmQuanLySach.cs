using QuanLyThuQuan.BUS;
using QuanLyThuQuan.GUI.ProductItem;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmQuanLySach : Form
    {
        private FormMain mainForm;
        private BookBUS bookBUS = new BookBUS();
        private CategoryBUS categoryBUS = new CategoryBUS();
        private string lastSearchTerm = "";
        public frmQuanLySach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            LoadData();
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
        }
        private void LoadData()
        {
            try
            {
                List<BookModel> books = bookBUS.GetAllBooks();
                if (books == null || books.Count == 0)
                {
                    Console.WriteLine("Không có dữ liệu !");
                }
                else
                {
                    dgvQuanLySach.Rows.Clear();
                    foreach (var book in books)
                    {
                        dgvQuanLySach.Rows.Add(
                            book.BookID,
                            book.BookTitle,
                            book.AuthorID,
                            book.CategoryID,
                            book.PublisYear,
                            book.BookQuantity,
                            book.FeePerDay,
                            book.BookStatus
                            );
                    }
                }
                List<CategoriesModel> categories = categoryBUS.GetAllCategories();
                cbbTypeBook.Items.Clear();
                cbbTypeBook.Items.Add("Thể loại");
                foreach (var category in categories)
                {
                    cbbTypeBook.Items.Add(category.CategoryName);
                }
                cbbTypeBook.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmControlBook formAddBook = new frmControlBook();
        
            formAddBook.SetLabelAndButtonText("Thêm Mới", "Thêm");
           
            formAddBook.ShowDialog();
            LoadData();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvQuanLySach.Rows[selectedRowIndex];
            frmControlBook formEditBook = new frmControlBook();
            BookModel book = bookBUS.GetBookByName(row.Cells[1].Value?.ToString());
            formEditBook.SetLabelAndButtonText("Chỉnh sửa", "Cập nhật");
            formEditBook.SetValue(book);
            formEditBook.Height = 450;
            formEditBook.ShowDialog();
            LoadData();
           

        }
        private int selectedRowIndex = -1;
        private void dgvQuanLySach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLySach.Rows[selectedRowIndex];
                BookModel book = bookBUS.GetBookByName(row.Cells[1].Value?.ToString());
                frmControlBook formDetailBook = new frmControlBook();
                formDetailBook.SetValue(book);
                formDetailBook.SetLabelAndButtonText("Xem chi tiết", "");
                formDetailBook.Height = 400;
                formDetailBook.ShowDialog();
            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBook.Text.Trim();

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
            string keyword = txtSearchBook.Text.Trim();
            List<BookModel> books = bookBUS.SearchBooks(keyword);
            dgvQuanLySach.Rows.Clear();
            if (books.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sách nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var book in books)
                {
                    dgvQuanLySach.Rows.Add(
                            book.BookID,
                            book.BookTitle,
                            book.AuthorID,
                            book.CategoryID,
                            book.PublisYear,
                            book.BookQuantity,
                            book.FeePerDay,
                            book.BookStatus
                    );
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dgvQuanLySach.Rows[selectedRowIndex];
                int bookID = Convert.ToInt32(row.Cells[0].Value); 

  
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = bookBUS.DeleteBook(bookID);
                    if (success)
                    {
                        MessageBox.Show("Sách đã được xóa thành công.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa sách.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sách để xóa.");
            }
        }

        private void cbbTypeBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTypeBook.SelectedItem != null)
            {
                string selectedCategory = cbbTypeBook.SelectedItem.ToString();

                if (selectedCategory == "Thể loại")
                {
                    List<BookModel> books = bookBUS.GetAllBooks(); 
                    dgvQuanLySach.Rows.Clear();
                    foreach (var book in books)
                    {
                        dgvQuanLySach.Rows.Add(
                            book.BookID,
                            book.BookTitle,
                            book.AuthorID,
                            book.CategoryID,
                            book.PublisYear,
                            book.BookQuantity,
                            book.FeePerDay,
                            book.BookStatus
                        );
                    }
                }
                else
                {
                    List<BookModel> books = bookBUS.GetBooksByCategory(selectedCategory);
                    dgvQuanLySach.Rows.Clear();
                    if (books.Count > 0)
                    {
                        foreach (var book in books)
                        {
                            dgvQuanLySach.Rows.Add(
                                book.BookID,
                                book.BookTitle,
                                book.AuthorID,
                                book.CategoryID,
                                book.PublisYear,
                                book.BookQuantity,
                                book.FeePerDay,
                                book.BookStatus
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách trong thể loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thể loại để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
