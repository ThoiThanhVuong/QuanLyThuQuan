using QuanLyThuQuan.BUS;
using QuanLyThuQuan.GUI.ProductItem;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmQuanLySach: Form
    {
        private FormMain mainForm;
        private BookBUS bookBUS = new BookBUS();
        public frmQuanLySach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            LoadData();
        }
        private void LoadData()
        {
            try {
                List<BookModel> books = bookBUS.GetAllBooks();
                if (books == null || books.Count == 0)
                {
                    Console.WriteLine("Không có dữ liệu thiết bị!");
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
            }
            catch(Exception ex)
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
            // Gọi phương thức để đặt text cho label và button
            formAddBook.SetLabelAndButtonText("Thêm Mới", "Thêm");
           
            formAddBook.ShowDialog();  
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
                formDetailBook.SetLabelAndButtonText("Xem chi tiết", "");
                formDetailBook.SetValue(book);
                formDetailBook.Height = 400;
                formDetailBook.ShowDialog();
            }
        }
    }
}
