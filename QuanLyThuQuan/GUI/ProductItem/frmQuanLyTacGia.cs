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
        private string lastSearchTerm = "";
        private int selectedAuthorID = -1;

        public frmQuanLyTacGia(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;

        }
        public void LoadData()
        {
            List<AuthorModel> authors = authorBUS.GetAllAuthor();
            if(authors == null || authors.Count == 0)

            {
                Console.WriteLine("Không có dữ liệu!");
            }
            else
            {
                dgvTacGia.Rows.Clear();
                foreach (var author in authors)
                {
                    dgvTacGia.Rows.Add(
                        author.AuthorID,
                        author.AuthorName,
                        author.AuthorStatus
                        );
                }
            }
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;

        }

        private void ResetForm()
        {
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            btnAdd.Enabled = false;
            txtTenTacGia.Enabled = false;
            txtMaTacGia.Enabled = false;
            btnCreateNew.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainForm.ShowFormInPanel(new FormBook(mainForm));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string authorName = txtTenTacGia.Text.Trim();
                if (string.IsNullOrEmpty(authorName))
                {
                    MessageBox.Show("Tên tác giả không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTacGia.Focus();
                    return;
                }
                bool isAuthorExists = authorBUS.CheckAuthorExists(authorName);

                if (isAuthorExists)
                {
                    MessageBox.Show("Tên tác giả này đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTacGia.Focus();
                    return;
                }

                AuthorModel author = new AuthorModel(
                    int.Parse(txtMaTacGia.Text),
                    authorName,
                    (ActivityStatus)Enum.Parse(typeof(ActivityStatus), "Active")
                );

                authorBUS.AddAuthor(author);
                LoadData();
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void frmQuanLyTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
                  
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            int newCode = authorBUS.GenerateNewAuthorCode();
            txtMaTacGia.Text = newCode+"";
            txtTenTacGia.Enabled = true;
            btnAdd.Enabled = true;
            btnCreateNew.Enabled = false;
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
            List<AuthorModel> authors = authorBUS.SearchAuthor(keyword);
            dgvTacGia.Rows.Clear();
            if (authors.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tác giả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var author in authors)
                {
                    dgvTacGia.Rows.Add(
                        author.AuthorID,
                        author.AuthorName,
                        author.AuthorStatus
                    );
                }
            }
        }

        private void dgvTacGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count > 0)
            {
                selectedAuthorID = Convert.ToInt32(dgvTacGia.SelectedRows[0].Cells["AuthorID"].Value);
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                selectedAuthorID = -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
         
                if (selectedAuthorID == -1)
                {
                    MessageBox.Show("Vui lòng chọn tác giả để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            
                if (btnEdit.Text == "Sửa")
                {
                  
                    int authorID = Convert.ToInt32(dgvTacGia.SelectedRows[0].Cells["AuthorID"].Value);
                    string authorName = dgvTacGia.SelectedRows[0].Cells["AuthorName"].Value.ToString();

                    txtMaTacGia.Text = authorID.ToString();
                    txtTenTacGia.Text = authorName;

                    txtTenTacGia.Enabled = true;
                    btnAdd.Enabled = false;
                    btnCreateNew.Enabled = false;
                    btnEdit.Text = "Cập nhật"; 
                }
                else if (btnEdit.Text == "Cập nhật") 
                {
                    string authorName = txtTenTacGia.Text.Trim();

                    if (string.IsNullOrEmpty(authorName))
                    {
                        MessageBox.Show("Tên tác giả không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenTacGia.Focus();
                        return;
                    }
          
                    AuthorModel updatedAuthor = new AuthorModel(
                        selectedAuthorID, 
                        authorName,
                        ActivityStatus.Active 
                    );

                    bool result = authorBUS.UpdateAuthor(updatedAuthor);

                    if (result)
                    {
                        MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); 
                        ResetForm(); 
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tác giả thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (selectedAuthorID == -1)
                {
                    MessageBox.Show("Vui lòng chọn tác giả để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = authorBUS.DeleteAuthor(selectedAuthorID);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
