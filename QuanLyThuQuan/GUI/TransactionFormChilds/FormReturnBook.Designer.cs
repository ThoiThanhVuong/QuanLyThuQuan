namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    partial class FormReturnBook
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
            this.pnlFormReturnBook = new System.Windows.Forms.Panel();
            this.pnlReturnBookBody = new System.Windows.Forms.Panel();
            this.tbGetReturnInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtGetMemberIDReturn = new System.Windows.Forms.TextBox();
            this.dtpRealReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbGetRealReturnDate = new System.Windows.Forms.Label();
            this.lbTransactionID = new System.Windows.Forms.Label();
            this.lbListProducts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbViolation = new System.Windows.Forms.Label();
            this.dgvListPenalty = new System.Windows.Forms.DataGridView();
            this.pnlReturnBookFooter = new System.Windows.Forms.Panel();
            this.tbReturnBookButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelFormReturn = new System.Windows.Forms.Button();
            this.btnResetFromReturn = new System.Windows.Forms.Button();
            this.btnSubmitFormReturn = new System.Windows.Forms.Button();
            this.pnlHeaderGetReturnInfo = new System.Windows.Forms.Panel();
            this.btnExitFormReturn = new System.Windows.Forms.Button();
            this.lbFormReturnProduct = new System.Windows.Forms.Label();
            this.lbGetReturnMemberID = new System.Windows.Forms.Label();
            this.txtGetTransactionID = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.dgvListReturnProduct = new System.Windows.Forms.DataGridView();
            this.pnlFormReturnBook.SuspendLayout();
            this.pnlReturnBookBody.SuspendLayout();
            this.tbGetReturnInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPenalty)).BeginInit();
            this.pnlReturnBookFooter.SuspendLayout();
            this.tbReturnBookButtons.SuspendLayout();
            this.pnlHeaderGetReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReturnProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormReturnBook
            // 
            this.pnlFormReturnBook.BackColor = System.Drawing.Color.Azure;
            this.pnlFormReturnBook.Controls.Add(this.pnlReturnBookBody);
            this.pnlFormReturnBook.Controls.Add(this.pnlReturnBookFooter);
            this.pnlFormReturnBook.Controls.Add(this.pnlHeaderGetReturnInfo);
            this.pnlFormReturnBook.Location = new System.Drawing.Point(0, 0);
            this.pnlFormReturnBook.Name = "pnlFormReturnBook";
            this.pnlFormReturnBook.Size = new System.Drawing.Size(400, 592);
            this.pnlFormReturnBook.TabIndex = 16;
            // 
            // pnlReturnBookBody
            // 
            this.pnlReturnBookBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlReturnBookBody.Controls.Add(this.tbGetReturnInfo);
            this.pnlReturnBookBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturnBookBody.Location = new System.Drawing.Point(0, 54);
            this.pnlReturnBookBody.Name = "pnlReturnBookBody";
            this.pnlReturnBookBody.Size = new System.Drawing.Size(400, 499);
            this.pnlReturnBookBody.TabIndex = 2;
            // 
            // tbGetReturnInfo
            // 
            this.tbGetReturnInfo.BackColor = System.Drawing.Color.Transparent;
            this.tbGetReturnInfo.ColumnCount = 2;
            this.tbGetReturnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tbGetReturnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.25F));
            this.tbGetReturnInfo.Controls.Add(this.txtGetTransactionID, 1, 0);
            this.tbGetReturnInfo.Controls.Add(this.lbGetReturnMemberID, 0, 1);
            this.tbGetReturnInfo.Controls.Add(this.dtpRealReturnDate, 1, 2);
            this.tbGetReturnInfo.Controls.Add(this.lbGetRealReturnDate, 0, 2);
            this.tbGetReturnInfo.Controls.Add(this.lbListProducts, 0, 5);
            this.tbGetReturnInfo.Controls.Add(this.panel1, 1, 4);
            this.tbGetReturnInfo.Controls.Add(this.lbViolation, 0, 3);
            this.tbGetReturnInfo.Controls.Add(this.dgvListPenalty, 1, 3);
            this.tbGetReturnInfo.Controls.Add(this.dgvListReturnProduct, 1, 5);
            this.tbGetReturnInfo.Controls.Add(this.lbTransactionID, 0, 0);
            this.tbGetReturnInfo.Controls.Add(this.txtGetMemberIDReturn, 1, 1);
            this.tbGetReturnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGetReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.tbGetReturnInfo.Name = "tbGetReturnInfo";
            this.tbGetReturnInfo.RowCount = 6;
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105107F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.105107F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.568882F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.82365F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.014028F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.92986F));
            this.tbGetReturnInfo.Size = new System.Drawing.Size(400, 499);
            this.tbGetReturnInfo.TabIndex = 3;
            // 
            // txtGetMemberIDReturn
            // 
            this.txtGetMemberIDReturn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGetMemberIDReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetMemberIDReturn.Location = new System.Drawing.Point(110, 28);
            this.txtGetMemberIDReturn.Name = "txtGetMemberIDReturn";
            this.txtGetMemberIDReturn.Size = new System.Drawing.Size(121, 20);
            this.txtGetMemberIDReturn.TabIndex = 5;
            // 
            // dtpRealReturnDate
            // 
            this.dtpRealReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpRealReturnDate.Enabled = false;
            this.dtpRealReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRealReturnDate.Location = new System.Drawing.Point(110, 56);
            this.dtpRealReturnDate.Name = "dtpRealReturnDate";
            this.dtpRealReturnDate.Size = new System.Drawing.Size(121, 20);
            this.dtpRealReturnDate.TabIndex = 9;
            // 
            // lbGetRealReturnDate
            // 
            this.lbGetRealReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetRealReturnDate.AutoSize = true;
            this.lbGetRealReturnDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetRealReturnDate.Location = new System.Drawing.Point(3, 59);
            this.lbGetRealReturnDate.Name = "lbGetRealReturnDate";
            this.lbGetRealReturnDate.Size = new System.Drawing.Size(96, 13);
            this.lbGetRealReturnDate.TabIndex = 2;
            this.lbGetRealReturnDate.Text = "Real Return Date :";
            this.lbGetRealReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransactionID
            // 
            this.lbTransactionID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransactionID.AutoSize = true;
            this.lbTransactionID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransactionID.Location = new System.Drawing.Point(3, 6);
            this.lbTransactionID.Name = "lbTransactionID";
            this.lbTransactionID.Size = new System.Drawing.Size(80, 13);
            this.lbTransactionID.TabIndex = 16;
            this.lbTransactionID.Text = "TransactionID :";
            // 
            // lbListProducts
            // 
            this.lbListProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbListProducts.AutoSize = true;
            this.lbListProducts.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbListProducts.Location = new System.Drawing.Point(3, 330);
            this.lbListProducts.Name = "lbListProducts";
            this.lbListProducts.Size = new System.Drawing.Size(55, 13);
            this.lbListProducts.TabIndex = 14;
            this.lbListProducts.Text = "Products :";
            this.lbListProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnSaveEdit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnLoadTable);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(110, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 27);
            this.panel1.TabIndex = 15;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadTable.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLoadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTable.ForeColor = System.Drawing.Color.Black;
            this.btnLoadTable.Location = new System.Drawing.Point(145, 2);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTable.TabIndex = 4;
            this.btnLoadTable.Text = "Load Result";
            this.btnLoadTable.UseVisualStyleBackColor = false;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(78, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbViolation
            // 
            this.lbViolation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolation.AutoSize = true;
            this.lbViolation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbViolation.Location = new System.Drawing.Point(3, 104);
            this.lbViolation.Name = "lbViolation";
            this.lbViolation.Size = new System.Drawing.Size(47, 13);
            this.lbViolation.TabIndex = 18;
            this.lbViolation.Text = "penalty :";
            // 
            // dgvListPenalty
            // 
            this.dgvListPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListPenalty.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvListPenalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPenalty.Location = new System.Drawing.Point(110, 85);
            this.dgvListPenalty.Name = "dgvListPenalty";
            this.dgvListPenalty.Size = new System.Drawing.Size(287, 52);
            this.dgvListPenalty.TabIndex = 19;
            // 
            // pnlReturnBookFooter
            // 
            this.pnlReturnBookFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlReturnBookFooter.Controls.Add(this.tbReturnBookButtons);
            this.pnlReturnBookFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReturnBookFooter.Location = new System.Drawing.Point(0, 553);
            this.pnlReturnBookFooter.Name = "pnlReturnBookFooter";
            this.pnlReturnBookFooter.Size = new System.Drawing.Size(400, 39);
            this.pnlReturnBookFooter.TabIndex = 1;
            // 
            // tbReturnBookButtons
            // 
            this.tbReturnBookButtons.BackColor = System.Drawing.Color.Transparent;
            this.tbReturnBookButtons.ColumnCount = 3;
            this.tbReturnBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbReturnBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbReturnBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbReturnBookButtons.Controls.Add(this.btnCancelFormReturn, 0, 0);
            this.tbReturnBookButtons.Controls.Add(this.btnResetFromReturn, 1, 0);
            this.tbReturnBookButtons.Controls.Add(this.btnSubmitFormReturn, 2, 0);
            this.tbReturnBookButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbReturnBookButtons.Location = new System.Drawing.Point(0, 0);
            this.tbReturnBookButtons.Name = "tbReturnBookButtons";
            this.tbReturnBookButtons.RowCount = 1;
            this.tbReturnBookButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbReturnBookButtons.Size = new System.Drawing.Size(400, 39);
            this.tbReturnBookButtons.TabIndex = 0;
            // 
            // btnCancelFormReturn
            // 
            this.btnCancelFormReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFormReturn.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormReturn.Location = new System.Drawing.Point(29, 5);
            this.btnCancelFormReturn.Name = "btnCancelFormReturn";
            this.btnCancelFormReturn.Size = new System.Drawing.Size(75, 29);
            this.btnCancelFormReturn.TabIndex = 0;
            this.btnCancelFormReturn.Text = "Cancel";
            this.btnCancelFormReturn.UseVisualStyleBackColor = true;
            this.btnCancelFormReturn.Click += new System.EventHandler(this.btnExitFormReturn_Click);
            // 
            // btnResetFromReturn
            // 
            this.btnResetFromReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetFromReturn.ForeColor = System.Drawing.Color.Black;
            this.btnResetFromReturn.Location = new System.Drawing.Point(162, 5);
            this.btnResetFromReturn.Name = "btnResetFromReturn";
            this.btnResetFromReturn.Size = new System.Drawing.Size(75, 29);
            this.btnResetFromReturn.TabIndex = 1;
            this.btnResetFromReturn.Text = "Reset";
            this.btnResetFromReturn.UseVisualStyleBackColor = true;
            this.btnResetFromReturn.Click += new System.EventHandler(this.btnResetFromReturn_Click);
            // 
            // btnSubmitFormReturn
            // 
            this.btnSubmitFormReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitFormReturn.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitFormReturn.Location = new System.Drawing.Point(295, 5);
            this.btnSubmitFormReturn.Name = "btnSubmitFormReturn";
            this.btnSubmitFormReturn.Size = new System.Drawing.Size(75, 29);
            this.btnSubmitFormReturn.TabIndex = 2;
            this.btnSubmitFormReturn.Text = "Submit";
            this.btnSubmitFormReturn.UseVisualStyleBackColor = true;
            this.btnSubmitFormReturn.Click += new System.EventHandler(this.btnSubmitFormReturn_Click);
            // 
            // pnlHeaderGetReturnInfo
            // 
            this.pnlHeaderGetReturnInfo.BackColor = System.Drawing.Color.Azure;
            this.pnlHeaderGetReturnInfo.Controls.Add(this.btnExitFormReturn);
            this.pnlHeaderGetReturnInfo.Controls.Add(this.lbFormReturnProduct);
            this.pnlHeaderGetReturnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetReturnInfo.Name = "pnlHeaderGetReturnInfo";
            this.pnlHeaderGetReturnInfo.Size = new System.Drawing.Size(400, 54);
            this.pnlHeaderGetReturnInfo.TabIndex = 0;
            // 
            // btnExitFormReturn
            // 
            this.btnExitFormReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormReturn.ForeColor = System.Drawing.Color.Red;
            this.btnExitFormReturn.Location = new System.Drawing.Point(366, 3);
            this.btnExitFormReturn.Name = "btnExitFormReturn";
            this.btnExitFormReturn.Size = new System.Drawing.Size(30, 30);
            this.btnExitFormReturn.TabIndex = 4;
            this.btnExitFormReturn.Text = "X";
            this.btnExitFormReturn.UseVisualStyleBackColor = true;
            this.btnExitFormReturn.Click += new System.EventHandler(this.btnExitFormReturn_Click);
            // 
            // lbFormReturnProduct
            // 
            this.lbFormReturnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFormReturnProduct.AutoSize = true;
            this.lbFormReturnProduct.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormReturnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbFormReturnProduct.Location = new System.Drawing.Point(149, 19);
            this.lbFormReturnProduct.Name = "lbFormReturnProduct";
            this.lbFormReturnProduct.Size = new System.Drawing.Size(133, 23);
            this.lbFormReturnProduct.TabIndex = 3;
            this.lbFormReturnProduct.Text = "Return Product";
            this.lbFormReturnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGetReturnMemberID
            // 
            this.lbGetReturnMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetReturnMemberID.AutoSize = true;
            this.lbGetReturnMemberID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetReturnMemberID.Location = new System.Drawing.Point(3, 31);
            this.lbGetReturnMemberID.Name = "lbGetReturnMemberID";
            this.lbGetReturnMemberID.Size = new System.Drawing.Size(65, 13);
            this.lbGetReturnMemberID.TabIndex = 21;
            this.lbGetReturnMemberID.Text = "Member ID :";
            this.lbGetReturnMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGetTransactionID
            // 
            this.txtGetTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetTransactionID.Location = new System.Drawing.Point(110, 3);
            this.txtGetTransactionID.Name = "txtGetTransactionID";
            this.txtGetTransactionID.Size = new System.Drawing.Size(121, 20);
            this.txtGetTransactionID.TabIndex = 22;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(226, 2);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(58, 23);
            this.btnSaveEdit.TabIndex = 6;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // dgvListReturnProduct
            // 
            this.dgvListReturnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListReturnProduct.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvListReturnProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListReturnProduct.Location = new System.Drawing.Point(110, 177);
            this.dgvListReturnProduct.Name = "dgvListReturnProduct";
            this.dgvListReturnProduct.Size = new System.Drawing.Size(287, 319);
            this.dgvListReturnProduct.TabIndex = 20;
            this.dgvListReturnProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListReturnProduct_EditingControlShowing);
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 592);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFormReturnBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlFormReturnBook.ResumeLayout(false);
            this.pnlReturnBookBody.ResumeLayout(false);
            this.tbGetReturnInfo.ResumeLayout(false);
            this.tbGetReturnInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPenalty)).EndInit();
            this.pnlReturnBookFooter.ResumeLayout(false);
            this.tbReturnBookButtons.ResumeLayout(false);
            this.pnlHeaderGetReturnInfo.ResumeLayout(false);
            this.pnlHeaderGetReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReturnProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormReturnBook;
        private System.Windows.Forms.Panel pnlReturnBookBody;
        private System.Windows.Forms.Panel pnlReturnBookFooter;
        private System.Windows.Forms.TableLayoutPanel tbReturnBookButtons;
        private System.Windows.Forms.Button btnCancelFormReturn;
        private System.Windows.Forms.Button btnResetFromReturn;
        private System.Windows.Forms.Button btnSubmitFormReturn;
        private System.Windows.Forms.Panel pnlHeaderGetReturnInfo;
        private System.Windows.Forms.Button btnExitFormReturn;
        private System.Windows.Forms.Label lbFormReturnProduct;
        private System.Windows.Forms.TableLayoutPanel tbGetReturnInfo;
        private System.Windows.Forms.Label lbGetRealReturnDate;
        private System.Windows.Forms.TextBox txtGetMemberIDReturn;
        private System.Windows.Forms.DateTimePicker dtpRealReturnDate;
        private System.Windows.Forms.Label lbListProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbTransactionID;
        private System.Windows.Forms.Label lbViolation;
        private System.Windows.Forms.DataGridView dgvListPenalty;
        private System.Windows.Forms.Label lbGetReturnMemberID;
        private System.Windows.Forms.TextBox txtGetTransactionID;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.DataGridView dgvListReturnProduct;
    }
}