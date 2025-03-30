using System;
using System.Windows.Forms;
using System.Data;
namespace QuanLyThuQuan.GUI
{
    public partial class FormReview : Form
    {
        public FormReview()
        {
            InitializeComponent();
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void gg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Mã đánh giá", typeof(int));
            table.Columns.Add("Mã người dùng", typeof(int));
            table.Columns.Add("Mã sách", typeof(int));
            table.Columns.Add("Mã vật dụng", typeof(int));
            table.Columns.Add("Điểm đánh giá", typeof(int));
            table.Columns.Add("Nội dung đánh giá", typeof(string));
            table.Columns.Add("Ngày đánh giá", typeof(DateTime));
            table.Rows.Add(1, "first A", "last A", 10);
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
