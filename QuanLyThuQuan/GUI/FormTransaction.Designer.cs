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
            this.dgvDataTransactions = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TableLayoutPanel();
            this.tbHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransactions)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tbBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBook.Location = new System.Drawing.Point(324, 4);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(312, 98);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            this.btnReturnBook.MouseEnter += new System.EventHandler(this.btnReturnBook_MouseEnter);
            this.btnReturnBook.MouseLeave += new System.EventHandler(this.btnReturnBook_MouseLeave);
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.Black;
            this.btnBookReservation.Location = new System.Drawing.Point(644, 4);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(312, 98);
            this.btnBookReservation.TabIndex = 3;
            this.btnBookReservation.Text = "Book Reservation";
            this.btnBookReservation.UseVisualStyleBackColor = true;
            this.btnBookReservation.Click += new System.EventHandler(this.btnBookReservation_Click);
            this.btnBookReservation.MouseEnter += new System.EventHandler(this.btnBookReservation_MouseEnter);
            this.btnBookReservation.MouseLeave += new System.EventHandler(this.btnBookReservation_MouseLeave);
            // 
            // tbHeaderButtons
            // 
            this.tbHeaderButtons.BackColor = System.Drawing.Color.Snow;
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
            this.tbHeaderButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tbHeaderButtons.Size = new System.Drawing.Size(960, 106);
            this.tbHeaderButtons.TabIndex = 4;
            // 
            // dgvDataTransactions
            // 
            this.dgvDataTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDataTransactions.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTransactions.Location = new System.Drawing.Point(3, 72);
            this.dgvDataTransactions.Name = "dgvDataTransactions";
            this.dgvDataTransactions.RowHeadersWidth = 62;
            this.dgvDataTransactions.Size = new System.Drawing.Size(954, 409);
            this.dgvDataTransactions.TabIndex = 1;
            this.dgvDataTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTransactions_CellContentClick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Snow;
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(954, 48);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(417, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Transactions List";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBody
            // 
            this.tbBody.AutoSize = true;
            this.tbBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbBody.ColumnCount = 1;
            this.tbBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBody.Controls.Add(this.pnlHeader, 0, 0);
            this.tbBody.Controls.Add(this.dgvDataTransactions, 0, 1);
            this.tbBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBody.Location = new System.Drawing.Point(0, 106);
            this.tbBody.Margin = new System.Windows.Forms.Padding(0);
            this.tbBody.Name = "tbBody";
            this.tbBody.RowCount = 3;
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.98529F));
            this.tbBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.088235F));
            this.tbBody.Size = new System.Drawing.Size(960, 544);
            this.tbBody.TabIndex = 7;
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbHeaderButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTransaction";
            this.Text = "cccccffffddeeeeewwwwwhhhhhhhhbbbnnmmmmmmvbvvvvvvv                   ";
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.tbHeaderButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransactions)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tbBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.TableLayoutPanel tbHeaderButtons;
        private System.Windows.Forms.DataGridView dgvDataTransactions;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tbBody;
    }
}