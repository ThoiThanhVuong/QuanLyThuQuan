using QuanLyThuQuan.BUS;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace QuanLyThuQuan.GUI
{
    public partial class FormReview : Form
    {
        ReviewBUS reviewBus = new ReviewBUS();
        public FormReview()
        {
            InitializeComponent();
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadDataTable();
        }

        private void gg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchText = textBox1.Text.Trim();
            List<ReviewModel> allReviews = reviewBus.GetAllReviews();
            List<ReviewModel> filteredReviews = new List<ReviewModel>();

            switch (gg.SelectedItem?.ToString())
            {
                case "mã đánh giá":
                    filteredReviews = allReviews.Where(r => r.ReviewID.ToString().Contains(searchText)).ToList();
                    break;
                case "mã người dùng":
                    filteredReviews = allReviews.Where(r => r.MemberID.ToString().Contains(searchText)).ToList();
                    break;
                case "mã sách":
                    filteredReviews = allReviews.Where(r => r.BookID?.ToString().Contains(searchText) ?? false).ToList();
                    break;
                case "mã vật dụng":
                    filteredReviews = allReviews.Where(r => r.DeviceID?.ToString().Contains(searchText) ?? false).ToList();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            dataGridView1.Rows.Clear();
            if (filteredReviews.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var review in filteredReviews)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["ReviewID"].Value = review.ReviewID;
                    row.Cells["MemberID"].Value = review.MemberID;
                    row.Cells["BookID"].Value = review.BookID?.ToString();
                    row.Cells["DeviceID"].Value = review.DeviceID?.ToString();
                    row.Cells["Rating"].Value = review.Rating;
                    row.Cells["ReviewText"].Value = review.ReviewText;
                    row.Cells["ReviewDate"].Value = review.ReviewDate.ToString("dd/MM/yyyy");
                }
            }
            dataGridView1.Refresh();
        }

        private bool IsValidInteger(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out _);
        }

        public void LoadDataTable()
        {
            List<ReviewModel> reviews = reviewBus.GetAllReviews();
            if (reviews == null)
            {
                Console.WriteLine("khong co du lieu");
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                foreach (var review in reviews)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["ReviewID"].Value = review.ReviewID;
                    row.Cells["MemberID"].Value = review.MemberID;
                    row.Cells["BookID"].Value = review.BookID?.ToString();
                    row.Cells["DeviceID"].Value = review.DeviceID?.ToString();
                    row.Cells["Rating"].Value = review.Rating;
                    row.Cells["ReviewText"].Value = review.ReviewText;
                    row.Cells["ReviewDate"].Value = review.ReviewDate.ToString("dd/MM/yyyy");
                }
                dataGridView1.Refresh();
                review_ID.Text = reviewBus.GetMaxReviewID().ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string validationMessage = validator();
            if (!string.IsNullOrEmpty(validationMessage))
            {
                return;
            }
            button2.Enabled = true;
            reviewBus.AddReview(new ReviewModel(
                int.Parse(review_ID.Text),
                int.Parse(Member_ID.Text),
                !string.IsNullOrEmpty(Book_ID.Text) ? int.Parse(Book_ID.Text) : (int?)null,
                !string.IsNullOrEmpty(Device_ID.Text) ? int.Parse(Device_ID.Text) : (int?)null,
                int.Parse(Rating_text.Text),
                Review_text.Text,
                Date_text.Value
            ));
            button2.Enabled = false;
            LoadDataTable();
            Clear_textbox();
        }

        public String validator()
        {
            if (Book_ID.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập tiêu đề quy định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (Device_ID.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập ID thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (Member_ID.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập ID người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (Rating_text.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập điểm đánh giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (Review_text.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập nội dung đánh giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            return "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes in textBox1
            // This event handler can be empty if you don't need specific functionality
            // when the text changes
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                button2.Enabled = false;
                review_ID.Text = dataGridView1.CurrentRow.Cells["ReviewID"].Value.ToString();
                Book_ID.Text = dataGridView1.CurrentRow.Cells["BookID"].Value?.ToString();
                Device_ID.Text = dataGridView1.CurrentRow.Cells["DeviceID"].Value?.ToString();
                Member_ID.Text = dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString();
                Rating_text.Text = dataGridView1.CurrentRow.Cells["Rating"].Value.ToString();

                string dateStr = dataGridView1.CurrentRow.Cells["ReviewDate"].Value.ToString();
                if (DateTime.TryParse(dateStr, out DateTime dateValue))
                {
                    Date_text.Value = dateValue;
                }
                else
                {
                    MessageBox.Show("Invalid date format detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Date_text.Value = DateTime.Now;
                }

                Review_text.Text = dataGridView1.CurrentRow.Cells["ReviewText"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading row data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Since we already have MouseClick event handler that handles the selection
            // and loading of data, we can leave this empty or remove the event subscription
        }

        public void Clear_textbox()
        {
            review_ID.Text = string.Empty;
            Book_ID.Text = string.Empty;
            Device_ID.Text = string.Empty;
            Member_ID.Text = string.Empty;
            Rating_text.Text = string.Empty;
            Date_text.Value = DateTime.Now;
            Review_text.Text = string.Empty;
            review_ID.Text = reviewBus.GetMaxReviewID().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear_textbox();
            button2.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(review_ID.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đánh giá này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    reviewBus.DeleteReview(int.Parse(review_ID.Text));
                    LoadDataTable();
                    Clear_textbox();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đánh giá để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string validationMessage = validator();
            if (!string.IsNullOrEmpty(validationMessage))
            {
                return;
            }

            if (!string.IsNullOrEmpty(review_ID.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật đánh giá này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ReviewModel updatedReview = new ReviewModel(
                        int.Parse(review_ID.Text),
                        int.Parse(Member_ID.Text),
                        !string.IsNullOrEmpty(Book_ID.Text) ? int.Parse(Book_ID.Text) : (int?)null,
                        !string.IsNullOrEmpty(Device_ID.Text) ? int.Parse(Device_ID.Text) : (int?)null,
                        int.Parse(Rating_text.Text),
                        Review_text.Text,
                        Date_text.Value
                    );

                    reviewBus.UpdateReview(updatedReview);
                    LoadDataTable();
                    Clear_textbox();
                    MessageBox.Show("Cập nhật đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đánh giá để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Reset textbox tìm kiếm
            textBox1.Text = string.Empty;
            gg.SelectedIndex = -1;

            // Hiển thị lại toàn bộ dữ liệu
            LoadDataTable();

            // Kích hoạt lại nút tìm kiếm
            button1.Enabled = true;
        }
    }
}