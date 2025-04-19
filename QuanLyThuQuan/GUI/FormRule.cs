using QuanLyThuQuan.BUS;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace QuanLyThuQuan.GUI
{
    
    public partial class FormRule : Form
    {
        RuleBUS ruleBus = new RuleBUS();
        public FormRule()
        {   
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void FormRule_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        public void loadDataTable()
        {
            
            List<RuleModel> rules = ruleBus.GetActiveRules();
            if (rules == null)
            {
                Console.WriteLine("Không có dữ liệu rules.");
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (RuleModel rule in rules)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["RuleID"].Value = rule.RuleID;
                    row.Cells["RuleTitle"].Value = rule.RuleTitle;
                    row.Cells["RuleDescription"].Value = rule.RuleDescription;
                    row.Cells["Penalty"].Value = rule.Penalty;
                    row.Cells["EffectiveDate"].Value = rule.EffectiveDate.ToString("yyyy-MM-dd");
                    row.Cells["Status"].Value = rule.RuleStatus.ToString();
                }
                textBox1.Text = ruleBus.getMaxRuleID().ToString();
            }
        }

        public String validator()
        {
            if (textBox2.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập tiêu đề quy định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox3.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            if (textBox4.Text == "")
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return result.ToString();
            }
            return "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Active")
            {
                radioButton1.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            textBox1.Text = ruleBus.getMaxRuleID().ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validationMessage = validator(); // Lấy thông báo từ validator
            if (!string.IsNullOrEmpty(validationMessage)) // Kiểm tra nếu có thông báo lỗi
            {
                return; // Nếu có lỗi, dừng việc lưu và không tiếp tục
            }
            button1.Enabled = true;
            ruleBus.AddRule(new RuleModel(
                int.Parse(textBox1.Text),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                dateTimePicker1.Value,
                radioButton1.Checked ? ActivityStatus.Active : ActivityStatus.Inactive
            ));     
            refresh();
            loadDataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string validationMessage = validator(); // Lấy thông báo từ validator
            if (!string.IsNullOrEmpty(validationMessage)) // Kiểm tra nếu có thông báo lỗi
            {
                return; // Nếu có lỗi, dừng việc lưu và không tiếp tục
            }
            button1.Enabled = true;
            ruleBus.UpdateRule(new RuleModel(
                int.Parse(textBox1.Text),
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                dateTimePicker1.Value,
                radioButton1.Checked ? ActivityStatus.Active : ActivityStatus.Inactive
            ));
            button2.Enabled = false;
            refresh();
            loadDataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruleBus.DeleteRule(int.Parse(textBox1.Text));
            loadDataTable();
            refresh();
        }
    }
}
