namespace QuanLyThuQuan.GUI
{
    partial class FormStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMember = new System.Windows.Forms.TabPage();
            this.dgvMemberStats = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMemberFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelMemberFrom = new System.Windows.Forms.Panel();
            this.dtpMemberFrom = new System.Windows.Forms.DateTimePicker();
            this.labelMemberFrom = new System.Windows.Forms.Label();
            this.panelMemberTo = new System.Windows.Forms.Panel();
            this.dtpMemberTo = new System.Windows.Forms.DateTimePicker();
            this.labelMemberTo = new System.Windows.Forms.Label();
            this.panelMemberType = new System.Windows.Forms.Panel();
            this.btnMemberStatistic = new System.Windows.Forms.Button();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.labelMemberTitle = new System.Windows.Forms.Label();
            this.tabPageDevice = new System.Windows.Forms.TabPage();
            this.dgvDeviceStats = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelDeviceFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelDeviceFrom = new System.Windows.Forms.Panel();
            this.dtpDeviceFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDeviceFrom = new System.Windows.Forms.Label();
            this.panelDeviceTo = new System.Windows.Forms.Panel();
            this.dtpDeviceTo = new System.Windows.Forms.DateTimePicker();
            this.labelDeviceTo = new System.Windows.Forms.Label();
            this.panelDeviceName = new System.Windows.Forms.Panel();
            this.btnDeviceCurrentlyBorrowed = new System.Windows.Forms.Button();
            this.btnDeviceBorrowedCount = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.labelDeviceTitle = new System.Windows.Forms.Label();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.dgvBookStats = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelBookFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelBookFrom = new System.Windows.Forms.Panel();
            this.dtpBookFrom = new System.Windows.Forms.DateTimePicker();
            this.labelBookFrom = new System.Windows.Forms.Label();
            this.panelBookTo = new System.Windows.Forms.Panel();
            this.dtpBookTo = new System.Windows.Forms.DateTimePicker();
            this.labelBookTo = new System.Windows.Forms.Label();
            this.panelBookName = new System.Windows.Forms.Panel();
            this.btnBookCurrentlyBorrowed = new System.Windows.Forms.Button();
            this.btnBookBorrowedCount = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberStats)).BeginInit();
            this.tableLayoutPanelMemberFilters.SuspendLayout();
            this.panelMemberFrom.SuspendLayout();
            this.panelMemberTo.SuspendLayout();
            this.panelMemberType.SuspendLayout();
            this.tabPageDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceStats)).BeginInit();
            this.tableLayoutPanelDeviceFilters.SuspendLayout();
            this.panelDeviceFrom.SuspendLayout();
            this.panelDeviceTo.SuspendLayout();
            this.panelDeviceName.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStats)).BeginInit();
            this.tableLayoutPanelBookFilters.SuspendLayout();
            this.panelBookFrom.SuspendLayout();
            this.panelBookTo.SuspendLayout();
            this.panelBookName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMember);
            this.tabControl1.Controls.Add(this.tabPageDevice);
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1333, 874);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMember
            // 
            this.tabPageMember.Controls.Add(this.dgvMemberStats);
            this.tabPageMember.Controls.Add(this.tableLayoutPanelMemberFilters);
            this.tabPageMember.Controls.Add(this.labelMemberTitle);
            this.tabPageMember.Location = new System.Drawing.Point(4, 37);
            this.tabPageMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMember.Name = "tabPageMember";
            this.tabPageMember.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMember.Size = new System.Drawing.Size(1325, 833);
            this.tabPageMember.TabIndex = 0;
            this.tabPageMember.Text = "Thống kê thành viên";
            this.tabPageMember.UseVisualStyleBackColor = true;
            // 
            // dgvMemberStats
            // 
            this.dgvMemberStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberStats.Location = new System.Drawing.Point(3, 212);
            this.dgvMemberStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMemberStats.Name = "dgvMemberStats";
            this.dgvMemberStats.RowHeadersWidth = 51;
            this.dgvMemberStats.RowTemplate.Height = 24;
            this.dgvMemberStats.Size = new System.Drawing.Size(1319, 617);
            this.dgvMemberStats.TabIndex = 2;
            // 
            // tableLayoutPanelMemberFilters
            // 
            this.tableLayoutPanelMemberFilters.AutoSize = true;
            this.tableLayoutPanelMemberFilters.ColumnCount = 3;
            this.tableLayoutPanelMemberFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMemberFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMemberFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMemberFilters.Controls.Add(this.panelMemberFrom, 0, 0);
            this.tableLayoutPanelMemberFilters.Controls.Add(this.panelMemberTo, 1, 0);
            this.tableLayoutPanelMemberFilters.Controls.Add(this.panelMemberType, 2, 0);
            this.tableLayoutPanelMemberFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMemberFilters.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanelMemberFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelMemberFilters.Name = "tableLayoutPanelMemberFilters";
            this.tableLayoutPanelMemberFilters.RowCount = 1;
            this.tableLayoutPanelMemberFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMemberFilters.Size = new System.Drawing.Size(1319, 170);
            this.tableLayoutPanelMemberFilters.TabIndex = 0;
            // 
            // panelMemberFrom
            // 
            this.panelMemberFrom.Controls.Add(this.dtpMemberFrom);
            this.panelMemberFrom.Controls.Add(this.labelMemberFrom);
            this.panelMemberFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberFrom.Location = new System.Drawing.Point(3, 4);
            this.panelMemberFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMemberFrom.Name = "panelMemberFrom";
            this.panelMemberFrom.Size = new System.Drawing.Size(433, 162);
            this.panelMemberFrom.TabIndex = 0;
            // 
            // dtpMemberFrom
            // 
            this.dtpMemberFrom.Location = new System.Drawing.Point(35, 65);
            this.dtpMemberFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpMemberFrom.Name = "dtpMemberFrom";
            this.dtpMemberFrom.Size = new System.Drawing.Size(330, 35);
            this.dtpMemberFrom.TabIndex = 1;
            // 
            // labelMemberFrom
            // 
            this.labelMemberFrom.AutoSize = true;
            this.labelMemberFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberFrom.Location = new System.Drawing.Point(30, 18);
            this.labelMemberFrom.Name = "labelMemberFrom";
            this.labelMemberFrom.Size = new System.Drawing.Size(92, 30);
            this.labelMemberFrom.TabIndex = 0;
            this.labelMemberFrom.Text = "Từ ngày:";
            // 
            // panelMemberTo
            // 
            this.panelMemberTo.Controls.Add(this.dtpMemberTo);
            this.panelMemberTo.Controls.Add(this.labelMemberTo);
            this.panelMemberTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberTo.Location = new System.Drawing.Point(442, 4);
            this.panelMemberTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMemberTo.Name = "panelMemberTo";
            this.panelMemberTo.Size = new System.Drawing.Size(433, 162);
            this.panelMemberTo.TabIndex = 1;
            // 
            // dtpMemberTo
            // 
            this.dtpMemberTo.Location = new System.Drawing.Point(30, 65);
            this.dtpMemberTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpMemberTo.Name = "dtpMemberTo";
            this.dtpMemberTo.Size = new System.Drawing.Size(334, 35);
            this.dtpMemberTo.TabIndex = 1;
            // 
            // labelMemberTo
            // 
            this.labelMemberTo.AutoSize = true;
            this.labelMemberTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberTo.Location = new System.Drawing.Point(26, 18);
            this.labelMemberTo.Name = "labelMemberTo";
            this.labelMemberTo.Size = new System.Drawing.Size(107, 30);
            this.labelMemberTo.TabIndex = 0;
            this.labelMemberTo.Text = "Đến ngày:";
            // 
            // panelMemberType
            // 
            this.panelMemberType.Controls.Add(this.btnMemberStatistic);
            this.panelMemberType.Controls.Add(this.cmbMemberType);
            this.panelMemberType.Controls.Add(this.labelMemberType);
            this.panelMemberType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberType.Location = new System.Drawing.Point(881, 4);
            this.panelMemberType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMemberType.Name = "panelMemberType";
            this.panelMemberType.Size = new System.Drawing.Size(435, 162);
            this.panelMemberType.TabIndex = 2;
            // 
            // btnMemberStatistic
            // 
            this.btnMemberStatistic.Location = new System.Drawing.Point(178, 96);
            this.btnMemberStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMemberStatistic.Name = "btnMemberStatistic";
            this.btnMemberStatistic.Size = new System.Drawing.Size(135, 52);
            this.btnMemberStatistic.TabIndex = 2;
            this.btnMemberStatistic.Text = "Thống kê";
            this.btnMemberStatistic.UseVisualStyleBackColor = true;
            this.btnMemberStatistic.Click += new System.EventHandler(this.btnMemberStatistic_Click);
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Location = new System.Drawing.Point(32, 50);
            this.cmbMemberType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(281, 36);
            this.cmbMemberType.TabIndex = 1;
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberType.Location = new System.Drawing.Point(27, 18);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(165, 30);
            this.labelMemberType.TabIndex = 0;
            this.labelMemberType.Text = "Loại người dùng";
            // 
            // labelMemberTitle
            // 
            this.labelMemberTitle.AutoSize = true;
            this.labelMemberTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMemberTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberTitle.Location = new System.Drawing.Point(3, 4);
            this.labelMemberTitle.Name = "labelMemberTitle";
            this.labelMemberTitle.Size = new System.Drawing.Size(296, 38);
            this.labelMemberTitle.TabIndex = 1;
            this.labelMemberTitle.Text = "Thống kê thành viên ";
            // 
            // tabPageDevice
            // 
            this.tabPageDevice.Controls.Add(this.dgvDeviceStats);
            this.tabPageDevice.Controls.Add(this.tableLayoutPanelDeviceFilters);
            this.tabPageDevice.Controls.Add(this.labelDeviceTitle);
            this.tabPageDevice.Location = new System.Drawing.Point(4, 37);
            this.tabPageDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDevice.Name = "tabPageDevice";
            this.tabPageDevice.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageDevice.Size = new System.Drawing.Size(1325, 833);
            this.tabPageDevice.TabIndex = 1;
            this.tabPageDevice.Text = "Thống kê thiết bị";
            this.tabPageDevice.UseVisualStyleBackColor = true;
            // 
            // dgvDeviceStats
            // 
            this.dgvDeviceStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceStats.Location = new System.Drawing.Point(3, 212);
            this.dgvDeviceStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDeviceStats.Name = "dgvDeviceStats";
            this.dgvDeviceStats.RowHeadersWidth = 51;
            this.dgvDeviceStats.RowTemplate.Height = 24;
            this.dgvDeviceStats.Size = new System.Drawing.Size(1319, 617);
            this.dgvDeviceStats.TabIndex = 2;
            // 
            // tableLayoutPanelDeviceFilters
            // 
            this.tableLayoutPanelDeviceFilters.AutoSize = true;
            this.tableLayoutPanelDeviceFilters.ColumnCount = 3;
            this.tableLayoutPanelDeviceFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelDeviceFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47658F));
            this.tableLayoutPanelDeviceFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.28191F));
            this.tableLayoutPanelDeviceFilters.Controls.Add(this.panelDeviceFrom, 0, 0);
            this.tableLayoutPanelDeviceFilters.Controls.Add(this.panelDeviceTo, 1, 0);
            this.tableLayoutPanelDeviceFilters.Controls.Add(this.panelDeviceName, 2, 0);
            this.tableLayoutPanelDeviceFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDeviceFilters.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanelDeviceFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelDeviceFilters.Name = "tableLayoutPanelDeviceFilters";
            this.tableLayoutPanelDeviceFilters.RowCount = 1;
            this.tableLayoutPanelDeviceFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDeviceFilters.Size = new System.Drawing.Size(1319, 170);
            this.tableLayoutPanelDeviceFilters.TabIndex = 1;
            // 
            // panelDeviceFrom
            // 
            this.panelDeviceFrom.Controls.Add(this.dtpDeviceFrom);
            this.panelDeviceFrom.Controls.Add(this.labelDeviceFrom);
            this.panelDeviceFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeviceFrom.Location = new System.Drawing.Point(3, 4);
            this.panelDeviceFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDeviceFrom.Name = "panelDeviceFrom";
            this.panelDeviceFrom.Size = new System.Drawing.Size(433, 162);
            this.panelDeviceFrom.TabIndex = 0;
            // 
            // dtpDeviceFrom
            // 
            this.dtpDeviceFrom.Location = new System.Drawing.Point(35, 65);
            this.dtpDeviceFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDeviceFrom.Name = "dtpDeviceFrom";
            this.dtpDeviceFrom.Size = new System.Drawing.Size(308, 35);
            this.dtpDeviceFrom.TabIndex = 1;
            // 
            // labelDeviceFrom
            // 
            this.labelDeviceFrom.AutoSize = true;
            this.labelDeviceFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDeviceFrom.Location = new System.Drawing.Point(30, 18);
            this.labelDeviceFrom.Name = "labelDeviceFrom";
            this.labelDeviceFrom.Size = new System.Drawing.Size(92, 30);
            this.labelDeviceFrom.TabIndex = 0;
            this.labelDeviceFrom.Text = "Từ ngày:";
            // 
            // panelDeviceTo
            // 
            this.panelDeviceTo.Controls.Add(this.dtpDeviceTo);
            this.panelDeviceTo.Controls.Add(this.labelDeviceTo);
            this.panelDeviceTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeviceTo.Location = new System.Drawing.Point(442, 4);
            this.panelDeviceTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDeviceTo.Name = "panelDeviceTo";
            this.panelDeviceTo.Size = new System.Drawing.Size(382, 162);
            this.panelDeviceTo.TabIndex = 1;
            // 
            // dtpDeviceTo
            // 
            this.dtpDeviceTo.Location = new System.Drawing.Point(30, 65);
            this.dtpDeviceTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDeviceTo.Name = "dtpDeviceTo";
            this.dtpDeviceTo.Size = new System.Drawing.Size(308, 35);
            this.dtpDeviceTo.TabIndex = 1;
            // 
            // labelDeviceTo
            // 
            this.labelDeviceTo.AutoSize = true;
            this.labelDeviceTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDeviceTo.Location = new System.Drawing.Point(26, 18);
            this.labelDeviceTo.Name = "labelDeviceTo";
            this.labelDeviceTo.Size = new System.Drawing.Size(107, 30);
            this.labelDeviceTo.TabIndex = 0;
            this.labelDeviceTo.Text = "Đến ngày:";
            // 
            // panelDeviceName
            // 
            this.panelDeviceName.Controls.Add(this.btnDeviceCurrentlyBorrowed);
            this.panelDeviceName.Controls.Add(this.btnDeviceBorrowedCount);
            this.panelDeviceName.Controls.Add(this.txtDeviceName);
            this.panelDeviceName.Controls.Add(this.labelDeviceName);
            this.panelDeviceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeviceName.Location = new System.Drawing.Point(830, 4);
            this.panelDeviceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDeviceName.Name = "panelDeviceName";
            this.panelDeviceName.Size = new System.Drawing.Size(486, 162);
            this.panelDeviceName.TabIndex = 2;
            // 
            // btnDeviceCurrentlyBorrowed
            // 
            this.btnDeviceCurrentlyBorrowed.Location = new System.Drawing.Point(266, 95);
            this.btnDeviceCurrentlyBorrowed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeviceCurrentlyBorrowed.Name = "btnDeviceCurrentlyBorrowed";
            this.btnDeviceCurrentlyBorrowed.Size = new System.Drawing.Size(210, 52);
            this.btnDeviceCurrentlyBorrowed.TabIndex = 3;
            this.btnDeviceCurrentlyBorrowed.Text = "Đang được mượn";
            this.btnDeviceCurrentlyBorrowed.UseVisualStyleBackColor = true;
            this.btnDeviceCurrentlyBorrowed.Click += new System.EventHandler(this.btnDeviceCurrentlyBorrowed_Click);
            // 
            // btnDeviceBorrowedCount
            // 
            this.btnDeviceBorrowedCount.Location = new System.Drawing.Point(17, 95);
            this.btnDeviceBorrowedCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeviceBorrowedCount.Name = "btnDeviceBorrowedCount";
            this.btnDeviceBorrowedCount.Size = new System.Drawing.Size(242, 52);
            this.btnDeviceBorrowedCount.TabIndex = 2;
            this.btnDeviceBorrowedCount.Text = "Thống kê lượt mượn";
            this.btnDeviceBorrowedCount.UseVisualStyleBackColor = true;
            this.btnDeviceBorrowedCount.Click += new System.EventHandler(this.btnDeviceBorrowedCount_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(32, 50);
            this.txtDeviceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(348, 35);
            this.txtDeviceName.TabIndex = 1;
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDeviceName.Location = new System.Drawing.Point(27, 18);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(279, 30);
            this.labelDeviceName.TabIndex = 0;
            this.labelDeviceName.Text = "Tên thiết bị (để trống=tất cả)";
            // 
            // labelDeviceTitle
            // 
            this.labelDeviceTitle.AutoSize = true;
            this.labelDeviceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeviceTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDeviceTitle.Location = new System.Drawing.Point(3, 4);
            this.labelDeviceTitle.Name = "labelDeviceTitle";
            this.labelDeviceTitle.Size = new System.Drawing.Size(243, 38);
            this.labelDeviceTitle.TabIndex = 0;
            this.labelDeviceTitle.Text = "Thống kê thiết bị";
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.dgvBookStats);
            this.tabPageBook.Controls.Add(this.tableLayoutPanelBookFilters);
            this.tabPageBook.Controls.Add(this.labelBookTitle);
            this.tabPageBook.Location = new System.Drawing.Point(4, 37);
            this.tabPageBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBook.Size = new System.Drawing.Size(1325, 833);
            this.tabPageBook.TabIndex = 2;
            this.tabPageBook.Text = "Thống kê sách";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // dgvBookStats
            // 
            this.dgvBookStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookStats.Location = new System.Drawing.Point(3, 212);
            this.dgvBookStats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBookStats.Name = "dgvBookStats";
            this.dgvBookStats.RowHeadersWidth = 51;
            this.dgvBookStats.RowTemplate.Height = 24;
            this.dgvBookStats.Size = new System.Drawing.Size(1319, 617);
            this.dgvBookStats.TabIndex = 2;
            // 
            // tableLayoutPanelBookFilters
            // 
            this.tableLayoutPanelBookFilters.AutoSize = true;
            this.tableLayoutPanelBookFilters.ColumnCount = 3;
            this.tableLayoutPanelBookFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBookFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBookFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBookFilters.Controls.Add(this.panelBookFrom, 0, 0);
            this.tableLayoutPanelBookFilters.Controls.Add(this.panelBookTo, 1, 0);
            this.tableLayoutPanelBookFilters.Controls.Add(this.panelBookName, 2, 0);
            this.tableLayoutPanelBookFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBookFilters.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanelBookFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelBookFilters.Name = "tableLayoutPanelBookFilters";
            this.tableLayoutPanelBookFilters.RowCount = 1;
            this.tableLayoutPanelBookFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBookFilters.Size = new System.Drawing.Size(1319, 170);
            this.tableLayoutPanelBookFilters.TabIndex = 1;
            // 
            // panelBookFrom
            // 
            this.panelBookFrom.Controls.Add(this.dtpBookFrom);
            this.panelBookFrom.Controls.Add(this.labelBookFrom);
            this.panelBookFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookFrom.Location = new System.Drawing.Point(3, 4);
            this.panelBookFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookFrom.Name = "panelBookFrom";
            this.panelBookFrom.Size = new System.Drawing.Size(433, 162);
            this.panelBookFrom.TabIndex = 0;
            // 
            // dtpBookFrom
            // 
            this.dtpBookFrom.Location = new System.Drawing.Point(35, 65);
            this.dtpBookFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBookFrom.Name = "dtpBookFrom";
            this.dtpBookFrom.Size = new System.Drawing.Size(308, 35);
            this.dtpBookFrom.TabIndex = 1;
            // 
            // labelBookFrom
            // 
            this.labelBookFrom.AutoSize = true;
            this.labelBookFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBookFrom.Location = new System.Drawing.Point(30, 18);
            this.labelBookFrom.Name = "labelBookFrom";
            this.labelBookFrom.Size = new System.Drawing.Size(92, 30);
            this.labelBookFrom.TabIndex = 0;
            this.labelBookFrom.Text = "Từ ngày:";
            // 
            // panelBookTo
            // 
            this.panelBookTo.Controls.Add(this.dtpBookTo);
            this.panelBookTo.Controls.Add(this.labelBookTo);
            this.panelBookTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookTo.Location = new System.Drawing.Point(442, 4);
            this.panelBookTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookTo.Name = "panelBookTo";
            this.panelBookTo.Size = new System.Drawing.Size(433, 162);
            this.panelBookTo.TabIndex = 1;
            // 
            // dtpBookTo
            // 
            this.dtpBookTo.Location = new System.Drawing.Point(30, 65);
            this.dtpBookTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBookTo.Name = "dtpBookTo";
            this.dtpBookTo.Size = new System.Drawing.Size(308, 35);
            this.dtpBookTo.TabIndex = 1;
            // 
            // labelBookTo
            // 
            this.labelBookTo.AutoSize = true;
            this.labelBookTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBookTo.Location = new System.Drawing.Point(26, 18);
            this.labelBookTo.Name = "labelBookTo";
            this.labelBookTo.Size = new System.Drawing.Size(107, 30);
            this.labelBookTo.TabIndex = 0;
            this.labelBookTo.Text = "Đến ngày:";
            // 
            // panelBookName
            // 
            this.panelBookName.Controls.Add(this.btnBookCurrentlyBorrowed);
            this.panelBookName.Controls.Add(this.btnBookBorrowedCount);
            this.panelBookName.Controls.Add(this.txtBookName);
            this.panelBookName.Controls.Add(this.labelBookName);
            this.panelBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookName.Location = new System.Drawing.Point(881, 4);
            this.panelBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBookName.Name = "panelBookName";
            this.panelBookName.Size = new System.Drawing.Size(435, 162);
            this.panelBookName.TabIndex = 2;
            // 
            // btnBookCurrentlyBorrowed
            // 
            this.btnBookCurrentlyBorrowed.Location = new System.Drawing.Point(230, 96);
            this.btnBookCurrentlyBorrowed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookCurrentlyBorrowed.Name = "btnBookCurrentlyBorrowed";
            this.btnBookCurrentlyBorrowed.Size = new System.Drawing.Size(200, 52);
            this.btnBookCurrentlyBorrowed.TabIndex = 3;
            this.btnBookCurrentlyBorrowed.Text = "Đang được mượn";
            this.btnBookCurrentlyBorrowed.UseVisualStyleBackColor = true;
            this.btnBookCurrentlyBorrowed.Click += new System.EventHandler(this.btnBookCurrentlyBorrowed_Click);
            // 
            // btnBookBorrowedCount
            // 
            this.btnBookBorrowedCount.Location = new System.Drawing.Point(3, 96);
            this.btnBookBorrowedCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookBorrowedCount.Name = "btnBookBorrowedCount";
            this.btnBookBorrowedCount.Size = new System.Drawing.Size(219, 52);
            this.btnBookBorrowedCount.TabIndex = 2;
            this.btnBookBorrowedCount.Text = "Thống kê lượt mượn";
            this.btnBookBorrowedCount.UseVisualStyleBackColor = true;
            this.btnBookBorrowedCount.Click += new System.EventHandler(this.btnBookBorrowedCount_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(32, 50);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(348, 35);
            this.txtBookName.TabIndex = 1;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBookName.Location = new System.Drawing.Point(27, 18);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(256, 30);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Tên sách (để trống=tất cả)";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBookTitle.Location = new System.Drawing.Point(3, 4);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(205, 38);
            this.labelBookTitle.TabIndex = 0;
            this.labelBookTitle.Text = "Thống kê sách";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 874);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStatistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMember.ResumeLayout(false);
            this.tabPageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberStats)).EndInit();
            this.tableLayoutPanelMemberFilters.ResumeLayout(false);
            this.panelMemberFrom.ResumeLayout(false);
            this.panelMemberFrom.PerformLayout();
            this.panelMemberTo.ResumeLayout(false);
            this.panelMemberTo.PerformLayout();
            this.panelMemberType.ResumeLayout(false);
            this.panelMemberType.PerformLayout();
            this.tabPageDevice.ResumeLayout(false);
            this.tabPageDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceStats)).EndInit();
            this.tableLayoutPanelDeviceFilters.ResumeLayout(false);
            this.panelDeviceFrom.ResumeLayout(false);
            this.panelDeviceFrom.PerformLayout();
            this.panelDeviceTo.ResumeLayout(false);
            this.panelDeviceTo.PerformLayout();
            this.panelDeviceName.ResumeLayout(false);
            this.panelDeviceName.PerformLayout();
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStats)).EndInit();
            this.tableLayoutPanelBookFilters.ResumeLayout(false);
            this.panelBookFrom.ResumeLayout(false);
            this.panelBookFrom.PerformLayout();
            this.panelBookTo.ResumeLayout(false);
            this.panelBookTo.PerformLayout();
            this.panelBookName.ResumeLayout(false);
            this.panelBookName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMember;
        private System.Windows.Forms.TabPage tabPageDevice;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Label labelMemberTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMemberFilters;
        private System.Windows.Forms.Panel panelMemberFrom;
        private System.Windows.Forms.DateTimePicker dtpMemberFrom;
        private System.Windows.Forms.Label labelMemberFrom;
        private System.Windows.Forms.Panel panelMemberTo;
        private System.Windows.Forms.DateTimePicker dtpMemberTo;
        private System.Windows.Forms.Label labelMemberTo;
        private System.Windows.Forms.Panel panelMemberType;
        private System.Windows.Forms.ComboBox cmbMemberType;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Button btnMemberStatistic;
        private System.Windows.Forms.DataGridView dgvMemberStats;
        private System.Windows.Forms.DataGridView dgvDeviceStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDeviceFilters;
        private System.Windows.Forms.Panel panelDeviceFrom;
        private System.Windows.Forms.DateTimePicker dtpDeviceFrom;
        private System.Windows.Forms.Label labelDeviceFrom;
        private System.Windows.Forms.Panel panelDeviceTo;
        private System.Windows.Forms.DateTimePicker dtpDeviceTo;
        private System.Windows.Forms.Label labelDeviceTo;
        private System.Windows.Forms.Panel panelDeviceName;
        private System.Windows.Forms.Button btnDeviceCurrentlyBorrowed;
        private System.Windows.Forms.Button btnDeviceBorrowedCount;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelDeviceTitle;
        private System.Windows.Forms.DataGridView dgvBookStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBookFilters;
        private System.Windows.Forms.Panel panelBookFrom;
        private System.Windows.Forms.DateTimePicker dtpBookFrom;
        private System.Windows.Forms.Label labelBookFrom;
        private System.Windows.Forms.Panel panelBookTo;
        private System.Windows.Forms.DateTimePicker dtpBookTo;
        private System.Windows.Forms.Label labelBookTo;
        private System.Windows.Forms.Panel panelBookName;
        private System.Windows.Forms.Button btnBookCurrentlyBorrowed;
        private System.Windows.Forms.Button btnBookBorrowedCount;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookTitle;
    }
}