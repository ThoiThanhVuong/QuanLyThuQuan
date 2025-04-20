

using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormBook : Form
    {
        private BookBUS bookBUS = new BookBUS();
        private FormMain mainForm;


        public FormBook(FormMain main)
        {
            InitializeComponent();
            this.mainForm = main;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            listSach();
            LoadData();

        }
        private void LoadData()
        {
            List<BookModel> books = bookBUS.GetAllBooks();

        }

        private void listSach()
        {
            List<BookModel> books = bookBUS.GetAllBooks();

            foreach (var book in books)
            {

                BookItemControl bookItem = new BookItemControl();
                bookItem.SetData(book);

                ListBook.Controls.Add(bookItem);
            }
        }

        private void ShowUserControl(UserControl uc)
        {
            ListBook.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            ListBook.Controls.Add(uc);
        }
        private void FadeForm(bool fade)
        {
            if (fade)
                this.Opacity = 0.5; // Làm mờ Form chính
            else
                this.Opacity = 1; // Khôi phục độ sáng bình thường
        }
        // sự kiện cho nút quản lý thông tin tác giả
        private void pnTacGia_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new frmQuanLyTacGia(mainForm));
        }

        private void pnQLSach_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new frmQuanLySach(mainForm));
        }

        private void pnTheLoai_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new frmTheLoaiSach(mainForm));
        }
    }
}
