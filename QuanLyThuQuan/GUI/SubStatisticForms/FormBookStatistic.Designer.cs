namespace QuanLyThuQuan.GUI.SubStatisticForms
{
    partial class FormBookStatistic
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
            this.lblBookStatistic = new System.Windows.Forms.Label();
            this.grpBookFilter = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnBookCurrentlyBorrowed = new System.Windows.Forms.Button();
            this.btnBookBorrowedCount = new System.Windows.Forms.Button();
            this.lblBookTo = new System.Windows.Forms.Label();
            this.lblBookFrom = new System.Windows.Forms.Label();
            this.dtpBookTo = new System.Windows.Forms.DateTimePicker();
            this.dtpBookFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvBookStats = new System.Windows.Forms.DataGridView();
            this.grpBookFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookStatistic
            // 
            this.lblBookStatistic.AutoSize = true;
            this.lblBookStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookStatistic.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStatistic.Location = new System.Drawing.Point(0, 0);
            this.lblBookStatistic.Name = "lblBookStatistic";
            this.lblBookStatistic.Size = new System.Drawing.Size(170, 31);
            this.lblBookStatistic.TabIndex = 0;
            this.lblBookStatistic.Text = "Thống kê Sách";
            this.lblBookStatistic.Padding = new System.Windows.Forms.Padding(12, 9, 0, 0);
            // 
            // grpBookFilter
            // 
            this.grpBookFilter.Controls.Add(this.txtBookName);
            this.grpBookFilter.Controls.Add(this.lblBookName);
            this.grpBookFilter.Controls.Add(this.btnBookCurrentlyBorrowed);
            this.grpBookFilter.Controls.Add(this.btnBookBorrowedCount);
            this.grpBookFilter.Controls.Add(this.lblBookTo);
            this.grpBookFilter.Controls.Add(this.lblBookFrom);
            this.grpBookFilter.Controls.Add(this.dtpBookTo);
            this.grpBookFilter.Controls.Add(this.dtpBookFrom);
            this.grpBookFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBookFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookFilter.Location = new System.Drawing.Point(0, 31);
            this.grpBookFilter.Name = "grpBookFilter";
            this.grpBookFilter.Size = new System.Drawing.Size(870, 140);
            this.grpBookFilter.TabIndex = 1;
            this.grpBookFilter.TabStop = false;
            this.grpBookFilter.Text = "Bộ lọc";
            this.grpBookFilter.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(144, 95);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(365, 30);
            this.txtBookName.TabIndex = 7;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(28, 98);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(81, 23);
            this.lblBookName.TabIndex = 6;
            this.lblBookName.Text = "Tên Sách:";
            // 
            // btnBookCurrentlyBorrowed
            // 
            this.btnBookCurrentlyBorrowed.Location = new System.Drawing.Point(622, 87);
            this.btnBookCurrentlyBorrowed.Name = "btnBookCurrentlyBorrowed";
            this.btnBookCurrentlyBorrowed.Size = new System.Drawing.Size(213, 38);
            this.btnBookCurrentlyBorrowed.TabIndex = 5;
            this.btnBookCurrentlyBorrowed.Text = "Đang được mượn";
            this.btnBookCurrentlyBorrowed.UseVisualStyleBackColor = true;
            this.btnBookCurrentlyBorrowed.Click += new System.EventHandler(this.btnBookCurrentlyBorrowed_Click);
            // 
            // btnBookBorrowedCount
            // 
            this.btnBookBorrowedCount.Location = new System.Drawing.Point(622, 33);
            this.btnBookBorrowedCount.Name = "btnBookBorrowedCount";
            this.btnBookBorrowedCount.Size = new System.Drawing.Size(213, 38);
            this.btnBookBorrowedCount.TabIndex = 4;
            this.btnBookBorrowedCount.Text = "Lượt mượn";
            this.btnBookBorrowedCount.UseVisualStyleBackColor = true;
            this.btnBookBorrowedCount.Click += new System.EventHandler(this.btnBookBorrowedCount_Click);
            // 
            // lblBookTo
            // 
            this.lblBookTo.AutoSize = true;
            this.lblBookTo.Location = new System.Drawing.Point(28, 63);
            this.lblBookTo.Name = "lblBookTo";
            this.lblBookTo.Size = new System.Drawing.Size(87, 23);
            this.lblBookTo.TabIndex = 3;
            this.lblBookTo.Text = "Đến ngày:";
            // 
            // lblBookFrom
            // 
            this.lblBookFrom.AutoSize = true;
            this.lblBookFrom.Location = new System.Drawing.Point(28, 29);
            this.lblBookFrom.Name = "lblBookFrom";
            this.lblBookFrom.Size = new System.Drawing.Size(75, 23);
            this.lblBookFrom.TabIndex = 2;
            this.lblBookFrom.Text = "Từ ngày:";
            // 
            // dtpBookTo
            // 
            this.dtpBookTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookTo.Location = new System.Drawing.Point(144, 57);
            this.dtpBookTo.Name = "dtpBookTo";
            this.dtpBookTo.Size = new System.Drawing.Size(200, 30);
            this.dtpBookTo.TabIndex = 1;
            // 
            // dtpBookFrom
            // 
            this.dtpBookFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookFrom.Location = new System.Drawing.Point(144, 23);
            this.dtpBookFrom.Name = "dtpBookFrom";
            this.dtpBookFrom.Size = new System.Drawing.Size(200, 30);
            this.dtpBookFrom.TabIndex = 0;
            // 
            // dgvBookStats
            // 
            this.dgvBookStats.AllowUserToAddRows = false;
            this.dgvBookStats.AllowUserToDeleteRows = false;
            this.dgvBookStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStats.Location = new System.Drawing.Point(0, 171);
            this.dgvBookStats.Name = "dgvBookStats";
            this.dgvBookStats.ReadOnly = true;
            this.dgvBookStats.RowHeadersWidth = 51;
            this.dgvBookStats.RowTemplate.Height = 24;
            this.dgvBookStats.Size = new System.Drawing.Size(870, 421);
            this.dgvBookStats.TabIndex = 2;
            // 
            // FormBookStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(870, 592);
            this.ControlBox = false;
            this.Controls.Add(this.dgvBookStats);
            this.Controls.Add(this.grpBookFilter);
            this.Controls.Add(this.lblBookStatistic);
            this.Name = "FormBookStatistic";
            this.grpBookFilter.ResumeLayout(false);
            this.grpBookFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookStatistic;
        private System.Windows.Forms.GroupBox grpBookFilter;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnBookCurrentlyBorrowed;
        private System.Windows.Forms.Button btnBookBorrowedCount;
        private System.Windows.Forms.Label lblBookTo;
        private System.Windows.Forms.Label lblBookFrom;
        private System.Windows.Forms.DateTimePicker dtpBookTo;
        private System.Windows.Forms.DateTimePicker dtpBookFrom;
        private System.Windows.Forms.DataGridView dgvBookStats;
    }
}