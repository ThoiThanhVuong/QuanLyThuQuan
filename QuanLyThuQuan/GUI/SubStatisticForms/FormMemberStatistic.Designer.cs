namespace QuanLyThuQuan.GUI.SubStatisticForms
{
    partial class FormMemberStatistic
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
            this.labelMemberTitle = new System.Windows.Forms.Label();
            this.panelMemberType = new System.Windows.Forms.Panel();
            this.btnMemberStatistic = new System.Windows.Forms.Button();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.panelMemberTo = new System.Windows.Forms.Panel();
            this.dtpMemberTo = new System.Windows.Forms.DateTimePicker();
            this.labelMemberTo = new System.Windows.Forms.Label();
            this.panelMemberFrom = new System.Windows.Forms.Panel();
            this.dtpMemberFrom = new System.Windows.Forms.DateTimePicker();
            this.labelMemberFrom = new System.Windows.Forms.Label();
            this.tableLayoutPanelMemberFilters = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMemberStats = new System.Windows.Forms.DataGridView();
            this.panelMemberType.SuspendLayout();
            this.panelMemberTo.SuspendLayout();
            this.panelMemberFrom.SuspendLayout();
            this.tableLayoutPanelMemberFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberStats)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMemberTitle
            // 
            this.labelMemberTitle.AutoSize = true;
            this.labelMemberTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMemberTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMemberTitle.Name = "labelMemberTitle";
            this.labelMemberTitle.Size = new System.Drawing.Size(240, 31);
            this.labelMemberTitle.TabIndex = 2;
            this.labelMemberTitle.Text = "Thống kê thành viên ";
            // 
            // panelMemberType
            // 
            this.panelMemberType.Controls.Add(this.btnMemberStatistic);
            this.panelMemberType.Controls.Add(this.cmbMemberType);
            this.panelMemberType.Controls.Add(this.labelMemberType);
            this.panelMemberType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberType.Location = new System.Drawing.Point(699, 3);
            this.panelMemberType.Name = "panelMemberType";
            this.panelMemberType.Size = new System.Drawing.Size(343, 130);
            this.panelMemberType.TabIndex = 2;
            // 
            // btnMemberStatistic
            // 
            this.btnMemberStatistic.Location = new System.Drawing.Point(158, 77);
            this.btnMemberStatistic.Name = "btnMemberStatistic";
            this.btnMemberStatistic.Size = new System.Drawing.Size(120, 42);
            this.btnMemberStatistic.TabIndex = 2;
            this.btnMemberStatistic.Text = "Thống kê";
            this.btnMemberStatistic.UseVisualStyleBackColor = true;
            this.btnMemberStatistic.Click += new System.EventHandler(this.btnMemberStatistic_Click);
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Location = new System.Drawing.Point(28, 40);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(250, 24);
            this.cmbMemberType.TabIndex = 1;
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberType.Location = new System.Drawing.Point(24, 14);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(135, 23);
            this.labelMemberType.TabIndex = 0;
            this.labelMemberType.Text = "Loại người dùng";
            // 
            // panelMemberTo
            // 
            this.panelMemberTo.Controls.Add(this.dtpMemberTo);
            this.panelMemberTo.Controls.Add(this.labelMemberTo);
            this.panelMemberTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberTo.Location = new System.Drawing.Point(351, 3);
            this.panelMemberTo.Name = "panelMemberTo";
            this.panelMemberTo.Size = new System.Drawing.Size(342, 130);
            this.panelMemberTo.TabIndex = 1;
            // 
            // dtpMemberTo
            // 
            this.dtpMemberTo.Location = new System.Drawing.Point(27, 52);
            this.dtpMemberTo.Name = "dtpMemberTo";
            this.dtpMemberTo.Size = new System.Drawing.Size(297, 22);
            this.dtpMemberTo.TabIndex = 1;
            // 
            // labelMemberTo
            // 
            this.labelMemberTo.AutoSize = true;
            this.labelMemberTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberTo.Location = new System.Drawing.Point(23, 14);
            this.labelMemberTo.Name = "labelMemberTo";
            this.labelMemberTo.Size = new System.Drawing.Size(87, 23);
            this.labelMemberTo.TabIndex = 0;
            this.labelMemberTo.Text = "Đến ngày:";
            // 
            // panelMemberFrom
            // 
            this.panelMemberFrom.Controls.Add(this.dtpMemberFrom);
            this.panelMemberFrom.Controls.Add(this.labelMemberFrom);
            this.panelMemberFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMemberFrom.Location = new System.Drawing.Point(3, 3);
            this.panelMemberFrom.Name = "panelMemberFrom";
            this.panelMemberFrom.Size = new System.Drawing.Size(342, 130);
            this.panelMemberFrom.TabIndex = 0;
            // 
            // dtpMemberFrom
            // 
            this.dtpMemberFrom.Location = new System.Drawing.Point(31, 52);
            this.dtpMemberFrom.Name = "dtpMemberFrom";
            this.dtpMemberFrom.Size = new System.Drawing.Size(294, 22);
            this.dtpMemberFrom.TabIndex = 1;
            // 
            // labelMemberFrom
            // 
            this.labelMemberFrom.AutoSize = true;
            this.labelMemberFrom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMemberFrom.Location = new System.Drawing.Point(27, 14);
            this.labelMemberFrom.Name = "labelMemberFrom";
            this.labelMemberFrom.Size = new System.Drawing.Size(75, 23);
            this.labelMemberFrom.TabIndex = 0;
            this.labelMemberFrom.Text = "Từ ngày:";
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
            this.tableLayoutPanelMemberFilters.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanelMemberFilters.Name = "tableLayoutPanelMemberFilters";
            this.tableLayoutPanelMemberFilters.RowCount = 1;
            this.tableLayoutPanelMemberFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMemberFilters.Size = new System.Drawing.Size(1045, 136);
            this.tableLayoutPanelMemberFilters.TabIndex = 3;
            // 
            // dgvMemberStats
            // 
            this.dgvMemberStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberStats.Location = new System.Drawing.Point(0, 167);
            this.dgvMemberStats.Name = "dgvMemberStats";
            this.dgvMemberStats.RowHeadersWidth = 51;
            this.dgvMemberStats.RowTemplate.Height = 24;
            this.dgvMemberStats.Size = new System.Drawing.Size(1045, 394);
            this.dgvMemberStats.TabIndex = 4;
            // 
            // FormMemberStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1045, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMemberStats);
            this.Controls.Add(this.tableLayoutPanelMemberFilters);
            this.Controls.Add(this.labelMemberTitle);
            this.Name = "FormMemberStatistic";
            this.panelMemberType.ResumeLayout(false);
            this.panelMemberType.PerformLayout();
            this.panelMemberTo.ResumeLayout(false);
            this.panelMemberTo.PerformLayout();
            this.panelMemberFrom.ResumeLayout(false);
            this.panelMemberFrom.PerformLayout();
            this.tableLayoutPanelMemberFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberTitle;
        private System.Windows.Forms.Panel panelMemberType;
        private System.Windows.Forms.Button btnMemberStatistic;
        private System.Windows.Forms.ComboBox cmbMemberType;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Panel panelMemberTo;
        private System.Windows.Forms.DateTimePicker dtpMemberTo;
        private System.Windows.Forms.Label labelMemberTo;
        private System.Windows.Forms.Panel panelMemberFrom;
        private System.Windows.Forms.DateTimePicker dtpMemberFrom;
        private System.Windows.Forms.Label labelMemberFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMemberFilters;
        private System.Windows.Forms.DataGridView dgvMemberStats;
    }
}