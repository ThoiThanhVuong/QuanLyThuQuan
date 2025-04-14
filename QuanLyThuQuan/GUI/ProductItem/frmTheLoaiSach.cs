using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class frmTheLoaiSach : Form
    {
        private FormMain mainForm;
        private CategoryBUS categoryBUS = new CategoryBUS();
        public frmTheLoaiSach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                List<CategoriesModel> categories = categoryBUS.GetAllCategories();
                if (categories == null || categories.Count == 0)
                {
                    Console.WriteLine("Không có dữ liệu thiết bị!");
                }
                else
                {
                    dgvTheLoai.Rows.Clear();
                    foreach (var category in categories)
                    {
                        dgvTheLoai.Rows.Add(
                            category.CategoryID,
                            category.CategoryName,
                            category.CategoryStatus
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }
    }
}
