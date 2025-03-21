namespace QuanLyThuQuan.GUI
{
    partial class FormTransaction
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.tbHeaderButtons = new System.Windows.Forms.TableLayoutPanel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataTransactions = new System.Windows.Forms.DataGridView();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHeaderButtons.SuspendLayout();
            this.tbBody.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(4, 4);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(312, 98);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow Book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            this.btnBorrow.MouseEnter += new System.EventHandler(this.btnBorrow_MouseEnter);
            this.btnBorrow.MouseLeave += new System.EventHandler(this.btnBorrow_MouseLeave);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBook.Location = new System.Drawing.Point(324, 4);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(312, 98);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.button2_Click);
            this.btnReturnBook.MouseEnter += new System.EventHandler(this.btnReturnBook_MouseEnter);
            this.btnReturnBook.MouseLeave += new System.EventHandler(this.btnReturnBook_MouseLeave);
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookReservation.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.Black;
            this.btnBookReservation.Location = new System.Drawing.Point(644, 4);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(312, 98);
            this.btnBookReservation.TabIndex = 3;
            this.btnBookReservation.Text = "Book Reservation";
            this.btnBookReservation.UseVisualStyleBackColor = true;
            this.btnBookReservation.Click += new System.EventHandler(this.btnHandleViolations_Click);
            this.btnBookReservation.MouseEnter += new System.EventHandler(this.btnBookReservation_MouseEnter);
            this.btnBookReservation.MouseLeave += new System.EventHandler(this.btnBookReservation_MouseLeave);
            // 
            // tbHeaderButtons
            // 
            this.tbHeaderButtons.BackColor = System.Drawing.Color.Black;
            this.tbHeaderButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbHeaderButtons.ColumnCount = 3;
            this.tbHeaderButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbHeaderButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbHeaderButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbHeaderButtons.Controls.Add(this.btnReturnBook, 1, 0);
            this.tbHeaderButtons.Controls.Add(this.btnBookReservation, 2, 0);
            this.tbHeaderButtons.Controls.Add(this.btnBorrow, 0, 0);
            this.tbHeaderButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHeaderButtons.Location = new System.Drawing.Point(0, 0);
            this.tbHeaderButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeaderButtons.Name = "tbHeaderButtons";
            this.tbHeaderButtons.RowCount = 1;
            this.tbHeaderButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbHeaderButtons.Size = new System.Drawing.Size(960, 106);
            this.tbHeaderButtons.TabIndex = 4;
            this.tbHeaderButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(0, 611);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResult.Size = new System.Drawing.Size(960, 39);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "Result";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.Visible = false;
            // 
            // tbBody
            // 
            this.tbBody.AutoSize = true;
            this.tbBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbBody.BackColor = System.Drawing.Color.Black;
            this.tbBody.ColumnCount = 1;
            this.tbBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBody.Controls.Add(this.panelHeader, 0, 0);
            this.tbBody.Controls.Add(this.dataTransactions, 0, 1);
            this.tbBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBody.Location = new System.Drawing.Point(0, 106);
            this.tbBody.Margin = new System.Windows.Forms.Padding(0);
            this.tbBody.Name = "tbBody";
            this.tbBody.RowCount = 3;
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbBody.Size = new System.Drawing.Size(960, 505);
            this.tbBody.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lbTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(954, 44);
            this.panelHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(397, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Transactions List";
            // 
            // dataTransactions
            // 
            this.dataTransactions.BackgroundColor = System.Drawing.Color.Black;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colMemberID,
            this.colTransactionType,
            this.colTransactionDate,
            this.colDueDate,
            this.colReturnDate,
            this.colStatus});
            this.dataTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTransactions.Location = new System.Drawing.Point(3, 53);
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.Size = new System.Drawing.Size(954, 398);
            this.dataTransactions.TabIndex = 1;
            this.dataTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTransactions_CellContentClick);
            // 
            // colTransactionID
            // 
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.Name = "colTransactionID";
            // 
            // colMemberID
            // 
            this.colMemberID.HeaderText = "MemberID";
            this.colMemberID.Name = "colMemberID";
            // 
            // colTransactionType
            // 
            this.colTransactionType.HeaderText = "Transaction Type";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Width = 140;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Width = 150;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Width = 150;
            // 
            // colReturnDate
            // 
            this.colReturnDate.FillWeight = 160F;
            this.colReturnDate.HeaderText = "Return Date";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 70;
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.tbHeaderButtons);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTransaction";
            this.Text = "FormTransaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransaction_FormClosing);
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.tbHeaderButtons.ResumeLayout(false);
            this.tbBody.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.TableLayoutPanel tbHeaderButtons;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TableLayoutPanel tbBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}