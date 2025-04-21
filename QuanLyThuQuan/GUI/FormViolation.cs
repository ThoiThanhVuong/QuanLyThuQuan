using Org.BouncyCastle.Asn1.Cmp;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyThuQuan.GUI
{
    public partial class FormViolation : Form
    {
        ViolationBUS violationBus = new ViolationBUS();
        RuleBUS ruleBus = new RuleBUS();

        public FormViolation()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            comboBox1.DataSource = ruleBus.GetAllRules();
            comboBox1.DisplayMember = "RuleTitle";
            comboBox1.ValueMember = "RuleId";

        }

        private void FormViolation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadTable();
        }
        public void loadTable()
        {
            List<ViolationModel> violations = violationBus.GetViolations(); // Giả sử GetActiveViolations lấy danh sách vi phạm
            if (violations == null)
            {
                Console.WriteLine("Không có dữ liệu vi phạm.");
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (ViolationModel violation in violations)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["ViolationID"].Value = violation.ViolationID;
                    row.Cells["MemberID"].Value = violation.MemberID;
                    row.Cells["TransactionID"].Value = violation.TransactionID;
                    row.Cells["RuleID"].Value = violation.RuleID;
                    row.Cells["FineAmount"].Value = violation.FineAmount;
                    row.Cells["Reason"].Value = violation.Reason;
                    row.Cells["ViolationDate"].Value = violation.ViolationDate.ToString("yyyy-MM-dd");
                    row.Cells["IsCompensationRequired"].Value = violation.IsCompensationRequired;
                }
            }
            textBox1.Text = violationBus.maxViolationID().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public String validator()
        {
            if (textBox1.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Violation ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox2.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Member ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox3.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Transaction ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox5.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Reason", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox6.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập Paid Status", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            return "";
        }
        private void refresh()
        {
            textBox1.Text = violationBus.maxViolationID().ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            textBox1.Text = dataGridView1.CurrentRow.Cells["ViolationID"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["TransactionID"].Value?.ToString() ?? "";
            comboBox1.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RuleID"].Value);
            textBox5.Text = dataGridView1.CurrentRow.Cells["FineAmount"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Reason"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["ViolationDate"].Value.ToString());
            // CheckBox status
            radioButton1.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsCompensationRequired"].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validationMessage = validator(); // Kiểm tra dữ liệu hợp lệ
            if (!string.IsNullOrEmpty(validationMessage)) // Nếu có lỗi, dừng việc lưu
            {
                return;
            }


            violationBus.AddViolation(new ViolationModel(
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text),
                Convert.ToInt32(comboBox1.SelectedValue), 
                decimal.Parse(textBox5.Text),
                textBox6.Text, 
                dateTimePicker1.Value, 
                radioButton1.Checked 
             ));
            refresh();
            loadTable();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string validationMessage = validator(); // Kiểm tra dữ liệu hợp lệ
            if (!string.IsNullOrEmpty(validationMessage)) // Nếu có lỗi, dừng việc sửa
            {
                return;
            }


            violationBus.UpdateViolation(new ViolationModel(
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text),
                Convert.ToInt32(comboBox1.SelectedValue),
                decimal.Parse(textBox5.Text),
                textBox6.Text,
                dateTimePicker1.Value,
                radioButton1.Checked
             ));

            button2.Enabled = false;
            refresh();
            loadTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            violationBus.DeleteViolation(int.Parse(textBox1.Text));
            refresh();
            loadTable();
        }
    }
}
