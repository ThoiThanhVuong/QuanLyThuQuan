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
        private string lastSearchTerm = "";
        private int selectedCategoryID = -1;
        public frmTheLoaiSach(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;
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
                    dgvCategories.Rows.Clear();
                    foreach (var category in categories)
                    {
                        dgvCategories.Rows.Add(
                            category.CategoryID,
                            category.CategoryName,
                            category.CategoryStatus
                            );
                    }
                }
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
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
        public void ResetForm()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            txtMaTheLoai.Enabled = false;
            txtTenTheLoai.Enabled = false;
            btnAdd.Enabled = false;
            btnCreateNew.Enabled = true;
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

            string searchTerm = textSearch.Text.Trim();
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
            string keyword = textSearch.Text.Trim();
            List<CategoriesModel> categories = categoryBUS.SearchCategories(keyword);
            dgvCategories.Rows.Clear();
            if (categories.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tác giả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var category in categories)
                {
                    dgvCategories.Rows.Add(
                        category.CategoryID,
                        category.CategoryName,
                        category.CategoryStatus
                    );
                }
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            int newcode = categoryBUS.GenerateNewCategoryCode();
            txtMaTheLoai.Text = newcode + "";
            txtTenTheLoai.Enabled = true;
            btnAdd.Enabled = true;
            btnCreateNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                string categoryName = txtTenTheLoai.Text.Trim();
                if (string.IsNullOrEmpty(categoryName))
                {
                    MessageBox.Show("Tên thể loại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTheLoai.Focus();
                    return;
                }
                bool isAuthorExists = categoryBUS.CheckAuthorExists(categoryName);
                if (isAuthorExists)
                {
                    MessageBox.Show("Tên thể loại này đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTheLoai.Focus();
                    return;
                }
                CategoriesModel category = new CategoriesModel(
                    int.Parse(txtMaTheLoai.Text),
                    categoryName,
                    ActivityStatus.Active
                    );
                categoryBUS.AddCategory(category);
                LoadData();
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                selectedCategoryID = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                selectedCategoryID = -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedCategoryID == -1)
                {
                    MessageBox.Show("Vui lòng chọn tác giả để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (btnEdit.Text == "Sửa")
                {

                    int CategoryID = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
                    string CategoryName = dgvCategories.SelectedRows[0].Cells["CategoryName"].Value.ToString();

                    txtMaTheLoai.Text = CategoryID.ToString();
                    txtTenTheLoai.Text = CategoryName;

                    txtTenTheLoai.Enabled = true;
                    btnAdd.Enabled = false;
                    btnCreateNew.Enabled = false;
                    btnEdit.Text = "Cập nhật";
                }
                else if (btnEdit.Text == "Cập nhật")
                {
                    string categoryName = txtTenTheLoai.Text.Trim();

                    if (string.IsNullOrEmpty(categoryName))
                    {
                        MessageBox.Show("Tên thể loại không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenTheLoai.Focus();
                        return;
                    }

                    CategoriesModel category = new CategoriesModel(
                    int.Parse(txtMaTheLoai.Text),
                    categoryName,
                    ActivityStatus.Active
                    );

                    bool result = categoryBUS.UpdateCategory(category);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thể loại thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnEdit.Text = "Sửa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategoryID == -1)
                {
                    MessageBox.Show("Vui lòng chọn thể loại để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = categoryBUS.DeleteCategory(selectedCategoryID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thể loại thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
