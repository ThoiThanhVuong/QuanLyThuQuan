

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
        private TransactionBUS transactionBUS = new TransactionBUS();

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
