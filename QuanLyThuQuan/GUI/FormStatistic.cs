using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;
using QuanLyThuQuan.GUI.SubStatisticForms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormStatistic : Form
    {
        private SessionStudyBUS sessionStudyBUS = new SessionStudyBUS();
        private MemberBUS memberBUS = new MemberBUS();
        private TransactionBUS transactionBUS = new TransactionBUS();
        private DeviceBUS deviceBUS = new DeviceBUS();
        private BookBUS bookBUS = new BookBUS();

        private FormMemberStatistic formMbs = new FormMemberStatistic();
        private FormDeviceStatistic formDev = new FormDeviceStatistic();
        private FormBookStatistic formBook = new FormBookStatistic();

        public FormStatistic()
        {
            InitializeComponent();
            InitTabPages();
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            // Form has been loaded
        }

        private void InitTabPages()
        {
            // Member Statistics Tab
            TabPage memberTabPage = new TabPage("Thống kê Thành viên");
            formMbs.TopLevel = false;
            formMbs.FormBorderStyle = FormBorderStyle.None;
            formMbs.Dock = DockStyle.Fill;
            memberTabPage.Controls.Add(formMbs);
            tabControl1.TabPages.Add(memberTabPage);
            formMbs.Show();

            // Device Statistics Tab
            TabPage deviceTabPage = new TabPage("Thống kê Thiết bị");
            formDev.TopLevel = false;
            formDev.FormBorderStyle = FormBorderStyle.None;
            formDev.Dock = DockStyle.Fill;
            deviceTabPage.Controls.Add(formDev);
            tabControl1.TabPages.Add(deviceTabPage);
            formDev.Show();

            // Book Statistics Tab
            TabPage bookTabPage = new TabPage("Thống kê Sách");
            formBook.TopLevel = false;
            formBook.FormBorderStyle = FormBorderStyle.None;
            formBook.Dock = DockStyle.Fill;
            bookTabPage.Controls.Add(formBook);
            tabControl1.TabPages.Add(bookTabPage);
            formBook.Show();
        }

        private void tabPageMember_Click(object sender, EventArgs e)
        { }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        { }
    }
}
