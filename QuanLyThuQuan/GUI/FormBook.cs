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
    public partial class FormBook: Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            listSach();
           
        }
        private void listSach()
        {
            List<string> danhSachSach = new List<string>() { "Sách 1", "Sách 2", "Sách 3", "Sách 4", "Sách 5" };

            foreach (var tenSach in danhSachSach)
            {

                BookItemControl bookItem = new BookItemControl();


                ListBook.Controls.Add(bookItem);
            }
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
            frmQuanLyTacGia formTacGia = new frmQuanLyTacGia();
            FadeForm(true); // Làm mờ form chính
            formTacGia.FormClosed += (s, args) => FadeForm(false); // Khi đóng thì trở lại bình thường
            formTacGia.ShowDialog();
        }

        private void pnQLSach_Click(object sender, EventArgs e)
        {
            frmQuanLySach formQuanLySach = new frmQuanLySach();
            FadeForm(true);
            formQuanLySach.FormClosed += (s, args) => FadeForm(false);
            formQuanLySach.ShowDialog();
        }

        private void pnTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach formTheLoaiSach = new frmTheLoaiSach();
            FadeForm(true);
            formTheLoaiSach.FormClosed += (s, args) => FadeForm(false);
            formTheLoaiSach.ShowDialog();
        }
    }
}
