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
            this.pnlFormBorrowBook = new System.Windows.Forms.Panel();
            this.pnlBorrowBookFooter = new System.Windows.Forms.Panel();
            this.tbBorrowBookButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetFormBorrow = new System.Windows.Forms.Button();
            this.btnCancelFormBorrow = new System.Windows.Forms.Button();
            this.btnSubmitFormBorrow = new System.Windows.Forms.Button();
            this.pnlBorrowBookBody = new System.Windows.Forms.Panel();
            this.tbGetBorrowInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbGetProduct = new System.Windows.Forms.Label();
            this.lbGetBorrowMemberID = new System.Windows.Forms.Label();
            this.lbGetBorrowTransDate = new System.Windows.Forms.Label();
            this.lbGetBorrowDueDate = new System.Windows.Forms.Label();
            this.dtpGetGBorrowTransDate = new System.Windows.Forms.DateTimePicker();
            this.txtGetBorrowMemberID = new System.Windows.Forms.TextBox();
            this.dtpGetBorrowDueDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoneEdit = new System.Windows.Forms.Button();
            this.btnEditListProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbxTypeProduct = new System.Windows.Forms.ComboBox();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.pnlHeaderGetBorrowInfo = new System.Windows.Forms.Panel();
            this.btnExitBorrowProduct = new System.Windows.Forms.Button();
            this.lbBorrowProduct = new System.Windows.Forms.Label();
            this.pnlFormBorrowBook.SuspendLayout();
            this.pnlBorrowBookFooter.SuspendLayout();
            this.tbBorrowBookButtons.SuspendLayout();
            this.pnlBorrowBookBody.SuspendLayout();
            this.tbGetBorrowInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            this.pnlHeaderGetBorrowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBorrowBook
            // 
            this.pnlFormBorrowBook.BackColor = System.Drawing.Color.Azure;
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookFooter);
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookBody);
            this.pnlFormBorrowBook.Controls.Add(this.pnlHeaderGetBorrowInfo);
            this.pnlFormBorrowBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormBorrowBook.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorrowBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlFormBorrowBook.Name = "pnlFormBorrowBook";
            this.pnlFormBorrowBook.Size = new System.Drawing.Size(398, 592);
            this.pnlFormBorrowBook.TabIndex = 13;
            // 
            // pnlBorrowBookFooter
            // 
            this.pnlBorrowBookFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorrowBookFooter.Controls.Add(this.tbBorrowBookButtons);
            this.pnlBorrowBookFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorrowBookFooter.Location = new System.Drawing.Point(0, 553);
            this.pnlBorrowBookFooter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBorrowBookFooter.Name = "pnlBorrowBookFooter";
            this.pnlBorrowBookFooter.Size = new System.Drawing.Size(398, 39);
            this.pnlBorrowBookFooter.TabIndex = 0;
            // 
            // tbBorrowBookButtons
            // 
            this.tbBorrowBookButtons.BackColor = System.Drawing.Color.Transparent;
            this.tbBorrowBookButtons.ColumnCount = 3;
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.Controls.Add(this.btnResetFormBorrow, 1, 0);
            this.tbBorrowBookButtons.Controls.Add(this.btnCancelFormBorrow, 0, 0);
            this.tbBorrowBookButtons.Controls.Add(this.btnSubmitFormBorrow, 2, 0);
            this.tbBorrowBookButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBorrowBookButtons.Location = new System.Drawing.Point(0, 0);
            this.tbBorrowBookButtons.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBorrowBookButtons.Name = "tbBorrowBookButtons";
            this.tbBorrowBookButtons.RowCount = 1;
            this.tbBorrowBookButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBorrowBookButtons.Size = new System.Drawing.Size(398, 39);
            this.tbBorrowBookButtons.TabIndex = 0;
            // 
            // btnResetFormBorrow
            // 
            this.btnResetFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetFormBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnResetFormBorrow.Location = new System.Drawing.Point(161, 5);
            this.btnResetFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetFormBorrow.Name = "btnResetFormBorrow";
            this.btnResetFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnResetFormBorrow.TabIndex = 1;
            this.btnResetFormBorrow.Text = "Reset";
            this.btnResetFormBorrow.UseVisualStyleBackColor = true;
            this.btnResetFormBorrow.Click += new System.EventHandler(this.btnResetFormBorrow_Click);
            // 
            // btnCancelFormBorrow
            // 
            this.btnCancelFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFormBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormBorrow.Location = new System.Drawing.Point(29, 5);
            this.btnCancelFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelFormBorrow.Name = "btnCancelFormBorrow";
            this.btnCancelFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnCancelFormBorrow.TabIndex = 2;
            this.btnCancelFormBorrow.Text = "Cancel";
            this.btnCancelFormBorrow.UseVisualStyleBackColor = true;
            this.btnCancelFormBorrow.Click += new System.EventHandler(this.btnExitBorrowProduct_Click);
            // 
            // btnSubmitFormBorrow
            // 
            this.btnSubmitFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitFormBorrow.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitFormBorrow.Location = new System.Drawing.Point(294, 5);
            this.btnSubmitFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmitFormBorrow.Name = "btnSubmitFormBorrow";
            this.btnSubmitFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnSubmitFormBorrow.TabIndex = 0;
            this.btnSubmitFormBorrow.Text = "Submit";
            this.btnSubmitFormBorrow.UseVisualStyleBackColor = true;
            this.btnSubmitFormBorrow.Click += new System.EventHandler(this.btnSubmitFormBorrow_Click);
            // 
            // pnlBorrowBookBody
            // 
            this.pnlBorrowBookBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorrowBookBody.Controls.Add(this.tbGetBorrowInfo);
            this.pnlBorrowBookBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorrowBookBody.Location = new System.Drawing.Point(0, 54);
            this.pnlBorrowBookBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBorrowBookBody.Name = "pnlBorrowBookBody";
            this.pnlBorrowBookBody.Size = new System.Drawing.Size(398, 538);
            this.pnlBorrowBookBody.TabIndex = 1;
            // 
            // tbGetBorrowInfo
            // 
            this.tbGetBorrowInfo.BackColor = System.Drawing.Color.Transparent;
            this.tbGetBorrowInfo.ColumnCount = 2;
            this.tbGetBorrowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.88442F));
            this.tbGetBorrowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.11558F));
            this.tbGetBorrowInfo.Controls.Add(this.lbGetProduct, 0, 3);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowMemberID, 0, 0);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowTransDate, 0, 1);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowDueDate, 0, 2);
            this.tbGetBorrowInfo.Controls.Add(this.dtpGetGBorrowTransDate, 1, 1);
            this.tbGetBorrowInfo.Controls.Add(this.txtGetBorrowMemberID, 1, 0);
            this.tbGetBorrowInfo.Controls.Add(this.dtpGetBorrowDueDate, 1, 2);
            this.tbGetBorrowInfo.Controls.Add(this.panel1, 1, 3);
            this.tbGetBorrowInfo.Controls.Add(this.dgvListProducts, 1, 4);
            this.tbGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.tbGetBorrowInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGetBorrowInfo.Name = "tbGetBorrowInfo";
            this.tbGetBorrowInfo.RowCount = 5;
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.773646F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.773646F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.773646F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.773646F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.90541F));
            this.tbGetBorrowInfo.Size = new System.Drawing.Size(398, 538);
            this.tbGetBorrowInfo.TabIndex = 1;
            // 
            // lbGetProduct
            // 
            this.lbGetProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetProduct.AutoSize = true;
            this.lbGetProduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetProduct.Location = new System.Drawing.Point(2, 158);
            this.lbGetProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetProduct.Name = "lbGetProduct";
            this.lbGetProduct.Size = new System.Drawing.Size(94, 13);
            this.lbGetProduct.TabIndex = 13;
            this.lbGetProduct.Text = "Type of Products :";
            this.lbGetProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowMemberID
            // 
            this.lbGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowMemberID.AutoSize = true;
            this.lbGetBorrowMemberID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowMemberID.Location = new System.Drawing.Point(2, 17);
            this.lbGetBorrowMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowMemberID.Name = "lbGetBorrowMemberID";
            this.lbGetBorrowMemberID.Size = new System.Drawing.Size(65, 13);
            this.lbGetBorrowMemberID.TabIndex = 0;
            this.lbGetBorrowMemberID.Text = "Member ID :";
            this.lbGetBorrowMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowTransDate
            // 
            this.lbGetBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowTransDate.AutoSize = true;
            this.lbGetBorrowTransDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowTransDate.Location = new System.Drawing.Point(2, 64);
            this.lbGetBorrowTransDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowTransDate.Name = "lbGetBorrowTransDate";
            this.lbGetBorrowTransDate.Size = new System.Drawing.Size(95, 13);
            this.lbGetBorrowTransDate.TabIndex = 2;
            this.lbGetBorrowTransDate.Text = "Transaction Date :";
            this.lbGetBorrowTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowDueDate
            // 
            this.lbGetBorrowDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowDueDate.AutoSize = true;
            this.lbGetBorrowDueDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowDueDate.Location = new System.Drawing.Point(2, 111);
            this.lbGetBorrowDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowDueDate.Name = "lbGetBorrowDueDate";
            this.lbGetBorrowDueDate.Size = new System.Drawing.Size(59, 13);
            this.lbGetBorrowDueDate.TabIndex = 3;
            this.lbGetBorrowDueDate.Text = "Due Date :";
            this.lbGetBorrowDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpGetGBorrowTransDate
            // 
            this.dtpGetGBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpGetGBorrowTransDate.Enabled = false;
            this.dtpGetGBorrowTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetGBorrowTransDate.Location = new System.Drawing.Point(108, 60);
            this.dtpGetGBorrowTransDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpGetGBorrowTransDate.Name = "dtpGetGBorrowTransDate";
            this.dtpGetGBorrowTransDate.Size = new System.Drawing.Size(121, 20);
            this.dtpGetGBorrowTransDate.TabIndex = 12;
            // 
            // txtGetBorrowMemberID
            // 
            this.txtGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGetBorrowMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetBorrowMemberID.Location = new System.Drawing.Point(108, 13);
            this.txtGetBorrowMemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGetBorrowMemberID.Name = "txtGetBorrowMemberID";
            this.txtGetBorrowMemberID.Size = new System.Drawing.Size(121, 20);
            this.txtGetBorrowMemberID.TabIndex = 6;
            this.txtGetBorrowMemberID.Text = "Member ID";
            this.txtGetBorrowMemberID.Click += new System.EventHandler(this.txtGetBorrowMemberID_Click);
            // 
            // dtpGetBorrowDueDate
            // 
            this.dtpGetBorrowDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpGetBorrowDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetBorrowDueDate.Location = new System.Drawing.Point(108, 107);
            this.dtpGetBorrowDueDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpGetBorrowDueDate.Name = "dtpGetBorrowDueDate";
            this.dtpGetBorrowDueDate.Size = new System.Drawing.Size(121, 20);
            this.dtpGetBorrowDueDate.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDoneEdit);
            this.panel1.Controls.Add(this.btnEditListProducts);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.cbxTypeProduct);
            this.panel1.Location = new System.Drawing.Point(109, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 41);
            this.panel1.TabIndex = 14;
            // 
            // btnDoneEdit
            // 
            this.btnDoneEdit.Location = new System.Drawing.Point(220, 11);
            this.btnDoneEdit.Name = "btnDoneEdit";
            this.btnDoneEdit.Size = new System.Drawing.Size(46, 23);
            this.btnDoneEdit.TabIndex = 18;
            this.btnDoneEdit.Text = "save";
            this.btnDoneEdit.UseVisualStyleBackColor = true;
            this.btnDoneEdit.Click += new System.EventHandler(this.btnDoneEdit_Click);
            // 
            // btnEditListProducts
            // 
            this.btnEditListProducts.Location = new System.Drawing.Point(168, 10);
            this.btnEditListProducts.Name = "btnEditListProducts";
            this.btnEditListProducts.Size = new System.Drawing.Size(46, 23);
            this.btnEditListProducts.TabIndex = 17;
            this.btnEditListProducts.Text = "Edit";
            this.btnEditListProducts.UseVisualStyleBackColor = true;
            this.btnEditListProducts.Click += new System.EventHandler(this.btnEditListProducts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(130, 10);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(23, 23);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "+";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbxTypeProduct
            // 
            this.cbxTypeProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxTypeProduct.FormattingEnabled = true;
            this.cbxTypeProduct.Location = new System.Drawing.Point(3, 11);
            this.cbxTypeProduct.Name = "cbxTypeProduct";
            this.cbxTypeProduct.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeProduct.TabIndex = 15;
            this.cbxTypeProduct.Text = "All";
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListProducts.Location = new System.Drawing.Point(109, 191);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.Size = new System.Drawing.Size(286, 307);
            this.dgvListProducts.TabIndex = 15;
            this.dgvListProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListProducts_EditingControlShowing);
            // 
            // pnlHeaderGetBorrowInfo
            // 
            this.pnlHeaderGetBorrowInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.btnExitBorrowProduct);
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.lbBorrowProduct);
            this.pnlHeaderGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetBorrowInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeaderGetBorrowInfo.Name = "pnlHeaderGetBorrowInfo";
            this.pnlHeaderGetBorrowInfo.Size = new System.Drawing.Size(398, 54);
            this.pnlHeaderGetBorrowInfo.TabIndex = 0;
            // 
            // btnExitBorrowProduct
            // 
            this.btnExitBorrowProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitBorrowProduct.ForeColor = System.Drawing.Color.Red;
            this.btnExitBorrowProduct.Location = new System.Drawing.Point(365, 3);
            this.btnExitBorrowProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitBorrowProduct.Name = "btnExitBorrowProduct";
            this.btnExitBorrowProduct.Size = new System.Drawing.Size(30, 30);
            this.btnExitBorrowProduct.TabIndex = 1;
            this.btnExitBorrowProduct.Text = "X";
            this.btnExitBorrowProduct.UseVisualStyleBackColor = true;
            this.btnExitBorrowProduct.Click += new System.EventHandler(this.btnExitBorrowProduct_Click);
            // 
            // lbBorrowProduct
            // 
            this.lbBorrowProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBorrowProduct.AutoSize = true;
            this.lbBorrowProduct.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbBorrowProduct.Location = new System.Drawing.Point(149, 19);
            this.lbBorrowProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorrowProduct.Name = "lbBorrowProduct";
            this.lbBorrowProduct.Size = new System.Drawing.Size(136, 23);
            this.lbBorrowProduct.TabIndex = 0;
            this.lbBorrowProduct.Text = "Borrow Product";
            this.lbBorrowProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 592);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFormBorrowBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormBorrowBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBorrowBook_Load);
            this.pnlFormBorrowBook.ResumeLayout(false);
            this.pnlBorrowBookFooter.ResumeLayout(false);
            this.tbBorrowBookButtons.ResumeLayout(false);
            this.pnlBorrowBookBody.ResumeLayout(false);
            this.tbGetBorrowInfo.ResumeLayout(false);
            this.tbGetBorrowInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            this.pnlHeaderGetBorrowInfo.ResumeLayout(false);
            this.pnlHeaderGetBorrowInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorrowBook;
        private System.Windows.Forms.Panel pnlBorrowBookFooter;
        private System.Windows.Forms.TableLayoutPanel tbBorrowBookButtons;
        private System.Windows.Forms.Button btnResetFormBorrow;
        private System.Windows.Forms.Button btnCancelFormBorrow;
        private System.Windows.Forms.Button btnSubmitFormBorrow;
        private System.Windows.Forms.Panel pnlBorrowBookBody;
        private System.Windows.Forms.Panel pnlHeaderGetBorrowInfo;
        private System.Windows.Forms.Button btnExitBorrowProduct;
        private System.Windows.Forms.Label lbBorrowProduct;
        private System.Windows.Forms.TableLayoutPanel tbGetBorrowInfo;
        private System.Windows.Forms.Label lbGetProduct;
        private System.Windows.Forms.Label lbGetBorrowMemberID;
        private System.Windows.Forms.Label lbGetBorrowTransDate;
        private System.Windows.Forms.Label lbGetBorrowDueDate;
        private System.Windows.Forms.DateTimePicker dtpGetGBorrowTransDate;
        private System.Windows.Forms.TextBox txtGetBorrowMemberID;
        private System.Windows.Forms.DateTimePicker dtpGetBorrowDueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTypeProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.Button btnEditListProducts;
        private System.Windows.Forms.Button btnDoneEdit;
    }
}