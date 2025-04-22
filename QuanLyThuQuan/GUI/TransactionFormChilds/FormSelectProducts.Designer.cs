namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    partial class FormSelectProducts
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
            this.pnFormSelectProducts = new System.Windows.Forms.Panel();
            this.pnlHeaderGetBorrowInfo = new System.Windows.Forms.Panel();
            this.btnExitProductSelect = new System.Windows.Forms.Button();
            this.lbBookBorrow = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnCancelForm = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSubmitForm = new System.Windows.Forms.Button();
            this.pnFormSelectProducts.SuspendLayout();
            this.pnlHeaderGetBorrowInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFormSelectProducts
            // 
            this.pnFormSelectProducts.Controls.Add(this.tableLayoutPanel1);
            this.pnFormSelectProducts.Controls.Add(this.pnlHeaderGetBorrowInfo);
            this.pnFormSelectProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFormSelectProducts.Location = new System.Drawing.Point(0, 0);
            this.pnFormSelectProducts.Name = "pnFormSelectProducts";
            this.pnFormSelectProducts.Size = new System.Drawing.Size(498, 798);
            this.pnFormSelectProducts.TabIndex = 0;
            // 
            // pnlHeaderGetBorrowInfo
            // 
            this.pnlHeaderGetBorrowInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.btnExitProductSelect);
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.lbBookBorrow);
            this.pnlHeaderGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetBorrowInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeaderGetBorrowInfo.Name = "pnlHeaderGetBorrowInfo";
            this.pnlHeaderGetBorrowInfo.Size = new System.Drawing.Size(498, 54);
            this.pnlHeaderGetBorrowInfo.TabIndex = 1;
            // 
            // btnExitProductSelect
            // 
            this.btnExitProductSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProductSelect.ForeColor = System.Drawing.Color.Red;
            this.btnExitProductSelect.Location = new System.Drawing.Point(466, 3);
            this.btnExitProductSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitProductSelect.Name = "btnExitProductSelect";
            this.btnExitProductSelect.Size = new System.Drawing.Size(30, 30);
            this.btnExitProductSelect.TabIndex = 1;
            this.btnExitProductSelect.Text = "X";
            this.btnExitProductSelect.UseVisualStyleBackColor = true;
            this.btnExitProductSelect.Click += new System.EventHandler(this.btnExitProductSelect_Click);
            // 
            // lbBookBorrow
            // 
            this.lbBookBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBookBorrow.AutoSize = true;
            this.lbBookBorrow.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbBookBorrow.Location = new System.Drawing.Point(191, 19);
            this.lbBookBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBookBorrow.Name = "lbBookBorrow";
            this.lbBookBorrow.Size = new System.Drawing.Size(124, 23);
            this.lbBookBorrow.TabIndex = 0;
            this.lbBookBorrow.Text = "Product Select";
            this.lbBookBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListProducts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.507239F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.44103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.051733F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 744);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 42);
            this.panel1.TabIndex = 0;
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListProducts.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Location = new System.Drawing.Point(3, 51);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.Size = new System.Drawing.Size(492, 644);
            this.dgvListProducts.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(3, 701);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(162, 7);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(74, 29);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnResetForm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelForm, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmitForm, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, -4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnResetForm
            // 
            this.btnResetForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetForm.ForeColor = System.Drawing.Color.Black;
            this.btnResetForm.Location = new System.Drawing.Point(45, 7);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(74, 29);
            this.btnResetForm.TabIndex = 4;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnCancelForm
            // 
            this.btnCancelForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelForm.ForeColor = System.Drawing.Color.Red;
            this.btnCancelForm.Location = new System.Drawing.Point(209, 7);
            this.btnCancelForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelForm.Name = "btnCancelForm";
            this.btnCancelForm.Size = new System.Drawing.Size(74, 29);
            this.btnCancelForm.TabIndex = 5;
            this.btnCancelForm.Text = "Cancel";
            this.btnCancelForm.UseVisualStyleBackColor = true;
            this.btnCancelForm.Click += new System.EventHandler(this.btnExitProductSelect_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(9, 11);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(133, 20);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchProduct_KeyDown);
            // 
            // btnSubmitForm
            // 
            this.btnSubmitForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitForm.Location = new System.Drawing.Point(373, 7);
            this.btnSubmitForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(74, 29);
            this.btnSubmitForm.TabIndex = 3;
            this.btnSubmitForm.Text = "Submit";
            this.btnSubmitForm.UseVisualStyleBackColor = true;
            this.btnSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            // 
            // FormSelectProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(498, 798);
            this.ControlBox = false;
            this.Controls.Add(this.pnFormSelectProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSelectProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSelectProducts_Load);
            this.pnFormSelectProducts.ResumeLayout(false);
            this.pnlHeaderGetBorrowInfo.ResumeLayout(false);
            this.pnlHeaderGetBorrowInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFormSelectProducts;
        private System.Windows.Forms.Panel pnlHeaderGetBorrowInfo;
        private System.Windows.Forms.Button btnExitProductSelect;
        private System.Windows.Forms.Label lbBookBorrow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnCancelForm;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSubmitForm;
    }
}