
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
        private FormMain mainForm;
       
        //UC_TacGia ucTacGia = new UC_TacGia();
        //UC_TheLoai ucTheLoai = new UC_TheLoai();

        public FormBook(FormMain main)
        {
            InitializeComponent();
            this.mainForm = main;
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
            mainForm.ShowFormInPanel(new frmTheLoaiSach(mainForm));        }
    }
}
