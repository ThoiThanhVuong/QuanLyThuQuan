using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmQuanLyTacGia : Form
    {
        private FormMain mainForm;
        private AuthorBUS authorBUS = new AuthorBUS();
        public frmQuanLyTacGia(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            LoadData();
        }
        public void LoadData()
        {
            List<AuthorModel> authors = authorBUS.GetAllAuthor();
            foreach (var author in authors)
            {
                dgvTacGia.Rows.Add(
                    author.AuthorID,
                    author.AuthorName,
                    author.AuthorStatus
                    );
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }
    }
}
