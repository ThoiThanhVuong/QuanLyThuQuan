namespace QuanLyThuQuan.GUI.SubStatisticForms
{
    partial class FormDeviceStatistic
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
            this.lblDeviceStatistic = new System.Windows.Forms.Label();
            this.grpDeviceFilter = new System.Windows.Forms.GroupBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.btnDeviceCurrentlyBorrowed = new System.Windows.Forms.Button();
            this.btnDeviceBorrowedCount = new System.Windows.Forms.Button();
            this.lblDeviceTo = new System.Windows.Forms.Label();
            this.lblDeviceFrom = new System.Windows.Forms.Label();
            this.dtpDeviceTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDeviceFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvDeviceStats = new System.Windows.Forms.DataGridView();
            this.grpDeviceFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviceStatistic
            // 
            this.lblDeviceStatistic.AutoSize = true;
            this.lblDeviceStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceStatistic.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceStatistic.Location = new System.Drawing.Point(0, 0);
            this.lblDeviceStatistic.Name = "lblDeviceStatistic";
            this.lblDeviceStatistic.Padding = new System.Windows.Forms.Padding(12, 9, 0, 0);
            this.lblDeviceStatistic.Size = new System.Drawing.Size(214, 40);
            this.lblDeviceStatistic.TabIndex = 0;
            this.lblDeviceStatistic.Text = "Thống kê Thiết bị";
            // 
            // grpDeviceFilter
            // 
            this.grpDeviceFilter.Controls.Add(this.txtDeviceName);
            this.grpDeviceFilter.Controls.Add(this.lblDeviceName);
            this.grpDeviceFilter.Controls.Add(this.btnDeviceCurrentlyBorrowed);
            this.grpDeviceFilter.Controls.Add(this.btnDeviceBorrowedCount);
            this.grpDeviceFilter.Controls.Add(this.lblDeviceTo);
            this.grpDeviceFilter.Controls.Add(this.lblDeviceFrom);
            this.grpDeviceFilter.Controls.Add(this.dtpDeviceTo);
            this.grpDeviceFilter.Controls.Add(this.dtpDeviceFrom);
            this.grpDeviceFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDeviceFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeviceFilter.Location = new System.Drawing.Point(0, 40);
            this.grpDeviceFilter.Name = "grpDeviceFilter";
            this.grpDeviceFilter.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.grpDeviceFilter.Size = new System.Drawing.Size(890, 140);
            this.grpDeviceFilter.TabIndex = 1;
            this.grpDeviceFilter.TabStop = false;
            this.grpDeviceFilter.Text = "Bộ lọc";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(144, 95);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(365, 30);
            this.txtDeviceName.TabIndex = 7;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(28, 98);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(102, 23);
            this.lblDeviceName.TabIndex = 6;
            this.lblDeviceName.Text = "Tên Thiết bị:";
            // 
            // btnDeviceCurrentlyBorrowed
            // 
            this.btnDeviceCurrentlyBorrowed.Location = new System.Drawing.Point(622, 87);
            this.btnDeviceCurrentlyBorrowed.Name = "btnDeviceCurrentlyBorrowed";
            this.btnDeviceCurrentlyBorrowed.Size = new System.Drawing.Size(213, 38);
            this.btnDeviceCurrentlyBorrowed.TabIndex = 5;
            this.btnDeviceCurrentlyBorrowed.Text = "Đang được mượn";
            this.btnDeviceCurrentlyBorrowed.UseVisualStyleBackColor = true;
            this.btnDeviceCurrentlyBorrowed.Click += new System.EventHandler(this.btnDeviceCurrentlyBorrowed_Click);
            // 
            // btnDeviceBorrowedCount
            // 
            this.btnDeviceBorrowedCount.Location = new System.Drawing.Point(622, 33);
            this.btnDeviceBorrowedCount.Name = "btnDeviceBorrowedCount";
            this.btnDeviceBorrowedCount.Size = new System.Drawing.Size(213, 38);
            this.btnDeviceBorrowedCount.TabIndex = 4;
            this.btnDeviceBorrowedCount.Text = "Lượt mượn";
            this.btnDeviceBorrowedCount.UseVisualStyleBackColor = true;
            this.btnDeviceBorrowedCount.Click += new System.EventHandler(this.btnDeviceBorrowedCount_Click);
            // 
            // lblDeviceTo
            // 
            this.lblDeviceTo.AutoSize = true;
            this.lblDeviceTo.Location = new System.Drawing.Point(28, 63);
            this.lblDeviceTo.Name = "lblDeviceTo";
            this.lblDeviceTo.Size = new System.Drawing.Size(87, 23);
            this.lblDeviceTo.TabIndex = 3;
            this.lblDeviceTo.Text = "Đến ngày:";
            // 
            // lblDeviceFrom
            // 
            this.lblDeviceFrom.AutoSize = true;
            this.lblDeviceFrom.Location = new System.Drawing.Point(28, 29);
            this.lblDeviceFrom.Name = "lblDeviceFrom";
            this.lblDeviceFrom.Size = new System.Drawing.Size(75, 23);
            this.lblDeviceFrom.TabIndex = 2;
            this.lblDeviceFrom.Text = "Từ ngày:";
            // 
            // dtpDeviceTo
            // 
            this.dtpDeviceTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeviceTo.Location = new System.Drawing.Point(144, 57);
            this.dtpDeviceTo.Name = "dtpDeviceTo";
            this.dtpDeviceTo.Size = new System.Drawing.Size(200, 30);
            this.dtpDeviceTo.TabIndex = 1;
            // 
            // dtpDeviceFrom
            // 
            this.dtpDeviceFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeviceFrom.Location = new System.Drawing.Point(144, 23);
            this.dtpDeviceFrom.Name = "dtpDeviceFrom";
            this.dtpDeviceFrom.Size = new System.Drawing.Size(200, 30);
            this.dtpDeviceFrom.TabIndex = 0;
            // 
            // dgvDeviceStats
            // 
            this.dgvDeviceStats.AllowUserToAddRows = false;
            this.dgvDeviceStats.AllowUserToDeleteRows = false;
            this.dgvDeviceStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceStats.Location = new System.Drawing.Point(0, 180);
            this.dgvDeviceStats.Name = "dgvDeviceStats";
            this.dgvDeviceStats.ReadOnly = true;
            this.dgvDeviceStats.RowHeadersWidth = 51;
            this.dgvDeviceStats.RowTemplate.Height = 24;
            this.dgvDeviceStats.Size = new System.Drawing.Size(890, 359);
            this.dgvDeviceStats.TabIndex = 2;
            // 
            // FormDeviceStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(890, 539);
            this.ControlBox = false;
            this.Controls.Add(this.dgvDeviceStats);
            this.Controls.Add(this.grpDeviceFilter);
            this.Controls.Add(this.lblDeviceStatistic);
            this.Name = "FormDeviceStatistic";
            this.grpDeviceFilter.ResumeLayout(false);
            this.grpDeviceFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceStatistic;
        private System.Windows.Forms.GroupBox grpDeviceFilter;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Button btnDeviceCurrentlyBorrowed;
        private System.Windows.Forms.Button btnDeviceBorrowedCount;
        private System.Windows.Forms.Label lblDeviceTo;
        private System.Windows.Forms.Label lblDeviceFrom;
        private System.Windows.Forms.DateTimePicker dtpDeviceTo;
        private System.Windows.Forms.DateTimePicker dtpDeviceFrom;
        private System.Windows.Forms.DataGridView dgvDeviceStats;
    }
}