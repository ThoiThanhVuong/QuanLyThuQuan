using QuanLyThuQuan.GUI.ProductItem;
using System;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmQuanLySach : Form
    {
        private FormMain mainForm;

        public frmQuanLySach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void FadeForm(bool fade)
        {
            if (fade)
                this.Opacity = 0.5; // Làm mờ Form chính
            else
                this.Opacity = 1; // Khôi phục độ sáng bình thường
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
            FadeForm(true);
            formAddBook.FormClosed += (s, args) => FadeForm(false);
            formAddBook.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmControlBook formEditBook = new frmControlBook();
            formEditBook.SetLabelAndButtonText("Chỉnh sửa", "Cập nhật");
            FadeForm(true);
            formEditBook.FormClosed += (s, args) => FadeForm(false);
            formEditBook.ShowDialog();
        }
    }
}
