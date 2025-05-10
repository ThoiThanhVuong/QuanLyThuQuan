using Org.BouncyCastle.Asn1.Cmp;
using QuanLyThuQuan.BUS;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.GUI.SubViolationForm;
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
        private string lastSearchTerm = "";
        public FormViolation()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            comboBox1.DataSource = ruleBus.GetAllRules();
            comboBox1.DisplayMember = "RuleTitle";
            comboBox1.ValueMember = "RuleId";
            searchTimer = new Timer();
            searchTimer.Interval = 500;
            searchTimer.Tick += SearchTimer_Tick;

        }

        private void FormViolation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadTable();
            radioButton1.Checked = false; 
            radioButton2.Checked = true;  
            txtCompensationAmount.Visible = false; 
            label10.Visible = false;
           
           
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
                    row.Cells["Status"].Value = violation.Status.ToString();
                    row.Cells["action"].Value = "...";
                }
            }
            textBox1.Text = violationBus.maxViolationID().ToString();
            cbbHandlingOption.Items.AddRange(new string[] {
                    "Cảnh cáo",
                    "Khóa thẻ 1 tháng",
                    "Khóa thẻ 2 tháng",
                    "Khóa thẻ vĩnh viễn",
                    "Bồi thường",
                    "Khóa thẻ 1 tháng và bồi thường",
                    "Khóa thẻ 2 tháng và bồi thường"
                });
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
            //if (textBox3.Text == "")
            //{
            //    DialogResult result = MessageBox.Show("Vui lòng nhập Transaction ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return result.ToString();
            //}
            //if (textBox5.Text == "")
            //{
            //    DialogResult result = MessageBox.Show("Vui lòng nhập Reason", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return result.ToString();
            //}
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
            string validationMessage = validator();
            if (!string.IsNullOrEmpty(validationMessage))
                return;

            int violationId = int.Parse(textBox1.Text);
            int memberId = int.Parse(textBox2.Text);
            int? transactionId = string.IsNullOrEmpty(textBox3.Text) ? null : (int?)int.Parse(textBox3.Text);
            int ruleId = Convert.ToInt32(comboBox1.SelectedValue);
            decimal fineAmount = decimal.Parse(textBox5.Text);
            string reason = textBox6.Text;
            DateTime violationDate = dateTimePicker1.Value;
            bool isCompensationRequired = radioButton1.Checked;

            // Tạo Violation nếu chưa tồn tại
            ViolationModel existingViolation = violationBus.GetViolationByID(violationId);
            if (existingViolation == null)
            {
                var newViolation = new ViolationModel(
                    violationId,
                    memberId,
                    transactionId,
                    ruleId,
                    fineAmount,
                    reason,
                    violationDate,
                    isCompensationRequired,
                    null,
                    "Pending"
                );
                violationBus.AddViolation(newViolation);
            }

            // Nếu có chọn hình thức xử lý → xử lý hình phạt
            string selectedOption = cbbHandlingOption.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedOption))
            {
                DateTime startDate = DateTime.Now;
                DateTime? endDate = null;
                if (selectedOption.Contains("1 tháng"))
                    endDate = startDate.AddMonths(1);
                else if (selectedOption.Contains("2 tháng"))
                    endDate = startDate.AddMonths(2);

                // Thêm MemberPenalty
                new MemberPenaltyDAO().AddPenalty(new MemberPenaltyModel
                {
                    ViolationID = violationId,
                    StartDate = startDate,
                    EndDate = endDate,
                    Description = selectedOption
                });

                // Xử lý tiền phạt + bồi thường nếu có
                decimal compensationAmount = 0;
                if (isCompensationRequired)
                {
                    if (!decimal.TryParse(txtCompensationAmount.Text, out compensationAmount))
                    {
                        MessageBox.Show("Vui lòng nhập đúng số tiền bồi thường!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Thêm Payment: tổng tiền
                var payment = new PaymentModel(
                    memberId,
                    violationId,
                    transactionId,
                    fineAmount + compensationAmount,
                    "Xử lý vi phạm (bao gồm bồi thường nếu có)",
                    PaidStatus.Unpaid
                );
                new PaymentBUS().AddPayment(payment);

                
                ViolationModel violation = violationBus.GetViolationByID(violationId);
                violation.HandlingAction = selectedOption;
                violationBus.UpdateViolation(violation);
            }

            MessageBox.Show("Đã thêm và xử lý vi phạm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
            loadTable();
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtCompensationAmount.Visible = true;
                label10.Visible = true;
                txtCompensationAmount.Text = ""; 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                txtCompensationAmount.Visible = false;
                label10.Visible = false;
                txtCompensationAmount.Text = "0"; 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu click đúng cột "action"
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "action")
            {
                int violationID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ViolationID"].Value);

                // Gọi form xác nhận thanh toán
                FormPaymentConfirmation form = new FormPaymentConfirmation(violationID);
                form.ShowDialog();

                // Sau khi đóng form, load lại bảng
                loadTable();
            }
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
         
            string searchTerm = txtSeach.Text.Trim();
            
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
            string keyword = txtSeach.Text.Trim();
            if(keyword == "")
            {
                List<ViolationModel> violations = violationBus.GetViolations();
                dataGridView1.Rows.Clear();
                foreach (var violation in violations)
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
                    row.Cells["Status"].Value = violation.Status.ToString();
                    row.Cells["action"].Value = "...";
                }
            }
            else
            {
                List<ViolationModel> violations = violationBus.SearchViolationByMemberID(keyword);
                dataGridView1.Rows.Clear();
                if (violations.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thành viên  nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (var violation in violations)
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
                        row.Cells["Status"].Value = violation.Status.ToString();
                        row.Cells["action"].Value = "...";
                    }
                }
            }
              
        }
    }
}
