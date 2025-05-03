namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    partial class FormBorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckViolation = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbProductType = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbProductName = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.DTDueDate = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvBorrowItems = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 50);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(750, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(194, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BORROW TRANSACTION PRODUCT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 65);
            this.panel2.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.btnConfirm.Location = new System.Drawing.Point(293, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 57);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Xác Nhận Mượn";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtMemberID);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(26, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 38);
            this.panel3.TabIndex = 16;
            // 
            // txtMemberID
            // 
            this.txtMemberID.BackColor = System.Drawing.Color.White;
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberID.Location = new System.Drawing.Point(90, 10);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(0);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(96, 21);
            this.txtMemberID.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(6, 29);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 1);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thành viên :";
            // 
            // btnCheckViolation
            // 
            this.btnCheckViolation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.btnCheckViolation.FlatAppearance.BorderSize = 0;
            this.btnCheckViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckViolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckViolation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.btnCheckViolation.Location = new System.Drawing.Point(218, 3);
            this.btnCheckViolation.Name = "btnCheckViolation";
            this.btnCheckViolation.Size = new System.Drawing.Size(108, 57);
            this.btnCheckViolation.TabIndex = 17;
            this.btnCheckViolation.Text = "Check Violation";
            this.btnCheckViolation.UseVisualStyleBackColor = false;
            this.btnCheckViolation.Click += new System.EventHandler(this.btnCheckViolation_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cbbProductType);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(26, 78);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 38);
            this.panel5.TabIndex = 17;
            // 
            // cbbProductType
            // 
            this.cbbProductType.FormattingEnabled = true;
            this.cbbProductType.Location = new System.Drawing.Point(98, 4);
            this.cbbProductType.Name = "cbbProductType";
            this.cbbProductType.Size = new System.Drawing.Size(99, 30);
            this.cbbProductType.TabIndex = 18;
            this.cbbProductType.SelectedIndexChanged += new System.EventHandler(this.cbbProductType_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(6, 29);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 1);
            this.panel6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(1, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại sản phẩm :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.cbbProductName);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(379, 70);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 38);
            this.panel7.TabIndex = 17;
            // 
            // cbbProductName
            // 
            this.cbbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbProductName.FormattingEnabled = true;
            this.cbbProductName.Location = new System.Drawing.Point(93, 5);
            this.cbbProductName.MaxDropDownItems = 5;
            this.cbbProductName.Name = "cbbProductName";
            this.cbbProductName.Size = new System.Drawing.Size(282, 30);
            this.cbbProductName.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(6, 29);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(370, 1);
            this.panel8.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Sản Phẩm :";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnThem);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.btnCheckViolation);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(798, 204);
            this.panel9.TabIndex = 18;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.btnThem.Location = new System.Drawing.Point(543, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 38);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.txtAmount);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.ForeColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(379, 126);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(161, 38);
            this.panel13.TabIndex = 20;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(61, 9);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(96, 21);
            this.txtAmount.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(6, 29);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(295, 1);
            this.panel14.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(1, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.DTDueDate);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.ForeColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(379, 10);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(324, 38);
            this.panel11.TabIndex = 19;
            // 
            // DTDueDate
            // 
            this.DTDueDate.Location = new System.Drawing.Point(93, 5);
            this.DTDueDate.Name = "DTDueDate";
            this.DTDueDate.Size = new System.Drawing.Size(232, 28);
            this.DTDueDate.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(6, 29);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(319, 1);
            this.panel12.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(1, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày hẹn trả :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(0, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(798, 3);
            this.label5.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvBorrowItems);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 254);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.panel10.Size = new System.Drawing.Size(798, 279);
            this.panel10.TabIndex = 19;
            // 
            // dgvBorrowItems
            // 
            this.dgvBorrowItems.AllowUserToAddRows = false;
            this.dgvBorrowItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.BookID,
            this.BookTitle,
            this.DeviceID,
            this.DeviceName,
            this.Amount,
            this.remove});
            this.dgvBorrowItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowItems.Location = new System.Drawing.Point(0, 10);
            this.dgvBorrowItems.Name = "dgvBorrowItems";
            this.dgvBorrowItems.RowHeadersVisible = false;
            this.dgvBorrowItems.RowHeadersWidth = 62;
            this.dgvBorrowItems.RowTemplate.Height = 28;
            this.dgvBorrowItems.Size = new System.Drawing.Size(798, 264);
            this.dgvBorrowItems.TabIndex = 0;
            this.dgvBorrowItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowItems_CellClick);
            this.dgvBorrowItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowItems_CellEndEdit);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.Width = 80;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.MinimumWidth = 8;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Width = 240;
            // 
            // DeviceID
            // 
            this.DeviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceID.HeaderText = "DeviceID";
            this.DeviceID.MinimumWidth = 8;
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Width = 80;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.MinimumWidth = 8;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 210;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
            // 
            // remove
            // 
            this.remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remove.HeaderText = "";
            this.remove.MinimumWidth = 8;
            this.remove.Name = "remove";
            this.remove.Width = 55;
            // 
            // FormBorrowBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.ControlBox = false;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormBorrowBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBorrowBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckViolation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbProductType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbProductName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvBorrowItems;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn remove;
        private System.Windows.Forms.DateTimePicker DTDueDate;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnThem;
    }
}