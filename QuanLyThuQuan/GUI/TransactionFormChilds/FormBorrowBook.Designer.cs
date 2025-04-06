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
            this.lbGetBorrowMemberID = new System.Windows.Forms.Label();
            this.lbGetBorrowTransType = new System.Windows.Forms.Label();
            this.lbGetBorrowTransDate = new System.Windows.Forms.Label();
            this.lbGetBorrowDueDate = new System.Windows.Forms.Label();
            this.txtGetBorrowMemberID = new System.Windows.Forms.TextBox();
            this.dtpGetBorrowDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGetGBorrowTransDate = new System.Windows.Forms.DateTimePicker();
            this.lbGetBorrowItem = new System.Windows.Forms.Label();
            this.txtGetTransType = new System.Windows.Forms.TextBox();
            this.rtxtGetBorrowListItem = new System.Windows.Forms.RichTextBox();
            this.pnlHeaderGetBorrowInfo = new System.Windows.Forms.Panel();
            this.btnExitBookBorrow = new System.Windows.Forms.Button();
            this.lbBookBorrow = new System.Windows.Forms.Label();
            this.pnlFormBorrowBook.SuspendLayout();
            this.pnlBorrowBookFooter.SuspendLayout();
            this.tbBorrowBookButtons.SuspendLayout();
            this.pnlBorrowBookBody.SuspendLayout();
            this.tbGetBorrowInfo.SuspendLayout();
            this.pnlHeaderGetBorrowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBorrowBook
            // 
            this.pnlFormBorrowBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFormBorrowBook.BackColor = System.Drawing.Color.Azure;
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookFooter);
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookBody);
            this.pnlFormBorrowBook.Controls.Add(this.pnlHeaderGetBorrowInfo);
            this.pnlFormBorrowBook.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorrowBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlFormBorrowBook.Name = "pnlFormBorrowBook";
            this.pnlFormBorrowBook.Size = new System.Drawing.Size(336, 592);
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
            this.pnlBorrowBookFooter.Size = new System.Drawing.Size(336, 39);
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
            this.tbBorrowBookButtons.Size = new System.Drawing.Size(336, 39);
            this.tbBorrowBookButtons.TabIndex = 0;
            // 
            // btnResetFormBorrow
            // 
            this.btnResetFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetFormBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnResetFormBorrow.Location = new System.Drawing.Point(131, 5);
            this.btnResetFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResetFormBorrow.Name = "btnResetFormBorrow";
            this.btnResetFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnResetFormBorrow.TabIndex = 1;
            this.btnResetFormBorrow.Text = "Reset";
            this.btnResetFormBorrow.UseVisualStyleBackColor = true;
            // 
            // btnCancelFormBorrow
            // 
            this.btnCancelFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFormBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormBorrow.Location = new System.Drawing.Point(19, 5);
            this.btnCancelFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelFormBorrow.Name = "btnCancelFormBorrow";
            this.btnCancelFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnCancelFormBorrow.TabIndex = 2;
            this.btnCancelFormBorrow.Text = "Cancel";
            this.btnCancelFormBorrow.UseVisualStyleBackColor = true;
            // 
            // btnSubmitFormBorrow
            // 
            this.btnSubmitFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitFormBorrow.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitFormBorrow.Location = new System.Drawing.Point(243, 5);
            this.btnSubmitFormBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmitFormBorrow.Name = "btnSubmitFormBorrow";
            this.btnSubmitFormBorrow.Size = new System.Drawing.Size(74, 29);
            this.btnSubmitFormBorrow.TabIndex = 0;
            this.btnSubmitFormBorrow.Text = "Submit";
            this.btnSubmitFormBorrow.UseVisualStyleBackColor = true;
            // 
            // pnlBorrowBookBody
            // 
            this.pnlBorrowBookBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBorrowBookBody.Controls.Add(this.tbGetBorrowInfo);
            this.pnlBorrowBookBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorrowBookBody.Location = new System.Drawing.Point(0, 54);
            this.pnlBorrowBookBody.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBorrowBookBody.Name = "pnlBorrowBookBody";
            this.pnlBorrowBookBody.Size = new System.Drawing.Size(336, 538);
            this.pnlBorrowBookBody.TabIndex = 1;
            // 
            // tbGetBorrowInfo
            // 
            this.tbGetBorrowInfo.BackColor = System.Drawing.Color.Transparent;
            this.tbGetBorrowInfo.ColumnCount = 2;
            this.tbGetBorrowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.61194F));
            this.tbGetBorrowInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.38806F));
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowMemberID, 0, 0);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowTransType, 0, 1);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowTransDate, 0, 2);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowDueDate, 0, 3);
            this.tbGetBorrowInfo.Controls.Add(this.txtGetBorrowMemberID, 1, 0);
            this.tbGetBorrowInfo.Controls.Add(this.dtpGetBorrowDueDate, 1, 3);
            this.tbGetBorrowInfo.Controls.Add(this.dtpGetGBorrowTransDate, 1, 2);
            this.tbGetBorrowInfo.Controls.Add(this.lbGetBorrowItem, 0, 4);
            this.tbGetBorrowInfo.Controls.Add(this.txtGetTransType, 1, 1);
            this.tbGetBorrowInfo.Controls.Add(this.rtxtGetBorrowListItem, 1, 4);
            this.tbGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.tbGetBorrowInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbGetBorrowInfo.Name = "tbGetBorrowInfo";
            this.tbGetBorrowInfo.RowCount = 7;
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67599F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67599F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67599F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67599F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.29603F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbGetBorrowInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbGetBorrowInfo.Size = new System.Drawing.Size(336, 538);
            this.tbGetBorrowInfo.TabIndex = 1;
            // 
            // lbGetBorrowMemberID
            // 
            this.lbGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowMemberID.AutoSize = true;
            this.lbGetBorrowMemberID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowMemberID.Location = new System.Drawing.Point(2, 32);
            this.lbGetBorrowMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowMemberID.Name = "lbGetBorrowMemberID";
            this.lbGetBorrowMemberID.Size = new System.Drawing.Size(65, 13);
            this.lbGetBorrowMemberID.TabIndex = 0;
            this.lbGetBorrowMemberID.Text = "Member ID :";
            this.lbGetBorrowMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowTransType
            // 
            this.lbGetBorrowTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowTransType.AutoSize = true;
            this.lbGetBorrowTransType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowTransType.Location = new System.Drawing.Point(2, 110);
            this.lbGetBorrowTransType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowTransType.Name = "lbGetBorrowTransType";
            this.lbGetBorrowTransType.Size = new System.Drawing.Size(96, 13);
            this.lbGetBorrowTransType.TabIndex = 1;
            this.lbGetBorrowTransType.Text = "Transaction Type :";
            this.lbGetBorrowTransType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowTransDate
            // 
            this.lbGetBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowTransDate.AutoSize = true;
            this.lbGetBorrowTransDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowTransDate.Location = new System.Drawing.Point(2, 188);
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
            this.lbGetBorrowDueDate.Location = new System.Drawing.Point(2, 266);
            this.lbGetBorrowDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowDueDate.Name = "lbGetBorrowDueDate";
            this.lbGetBorrowDueDate.Size = new System.Drawing.Size(59, 13);
            this.lbGetBorrowDueDate.TabIndex = 3;
            this.lbGetBorrowDueDate.Text = "Due Date :";
            this.lbGetBorrowDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGetBorrowMemberID
            // 
            this.txtGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetBorrowMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetBorrowMemberID.Location = new System.Drawing.Point(130, 29);
            this.txtGetBorrowMemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGetBorrowMemberID.Name = "txtGetBorrowMemberID";
            this.txtGetBorrowMemberID.Size = new System.Drawing.Size(201, 20);
            this.txtGetBorrowMemberID.TabIndex = 6;
            this.txtGetBorrowMemberID.Text = "Member ID";
            // 
            // dtpGetBorrowDueDate
            // 
            this.dtpGetBorrowDueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGetBorrowDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetBorrowDueDate.Location = new System.Drawing.Point(130, 263);
            this.dtpGetBorrowDueDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpGetBorrowDueDate.Name = "dtpGetBorrowDueDate";
            this.dtpGetBorrowDueDate.Size = new System.Drawing.Size(201, 20);
            this.dtpGetBorrowDueDate.TabIndex = 10;
            // 
            // dtpGetGBorrowTransDate
            // 
            this.dtpGetGBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGetGBorrowTransDate.Enabled = false;
            this.dtpGetGBorrowTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetGBorrowTransDate.Location = new System.Drawing.Point(130, 185);
            this.dtpGetGBorrowTransDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpGetGBorrowTransDate.Name = "dtpGetGBorrowTransDate";
            this.dtpGetGBorrowTransDate.Size = new System.Drawing.Size(201, 20);
            this.dtpGetGBorrowTransDate.TabIndex = 12;
            // 
            // lbGetBorrowItem
            // 
            this.lbGetBorrowItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowItem.AutoSize = true;
            this.lbGetBorrowItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowItem.Location = new System.Drawing.Point(2, 398);
            this.lbGetBorrowItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetBorrowItem.Name = "lbGetBorrowItem";
            this.lbGetBorrowItem.Size = new System.Drawing.Size(52, 13);
            this.lbGetBorrowItem.TabIndex = 5;
            this.lbGetBorrowItem.Text = "List Item :";
            this.lbGetBorrowItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGetTransType
            // 
            this.txtGetTransType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetTransType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetTransType.Enabled = false;
            this.txtGetTransType.Location = new System.Drawing.Point(130, 107);
            this.txtGetTransType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGetTransType.Name = "txtGetTransType";
            this.txtGetTransType.ReadOnly = true;
            this.txtGetTransType.Size = new System.Drawing.Size(201, 20);
            this.txtGetTransType.TabIndex = 13;
            // 
            // rtxtGetBorrowListItem
            // 
            this.rtxtGetBorrowListItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtGetBorrowListItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtGetBorrowListItem.Location = new System.Drawing.Point(128, 315);
            this.rtxtGetBorrowListItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtxtGetBorrowListItem.Name = "rtxtGetBorrowListItem";
            this.rtxtGetBorrowListItem.Size = new System.Drawing.Size(206, 179);
            this.rtxtGetBorrowListItem.TabIndex = 9;
            this.rtxtGetBorrowListItem.Text = "(write id of this book, delimited by commas)";
            // 
            // pnlHeaderGetBorrowInfo
            // 
            this.pnlHeaderGetBorrowInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.btnExitBookBorrow);
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.lbBookBorrow);
            this.pnlHeaderGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetBorrowInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeaderGetBorrowInfo.Name = "pnlHeaderGetBorrowInfo";
            this.pnlHeaderGetBorrowInfo.Size = new System.Drawing.Size(336, 54);
            this.pnlHeaderGetBorrowInfo.TabIndex = 0;
            // 
            // btnExitBookBorrow
            // 
            this.btnExitBookBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitBookBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnExitBookBorrow.Location = new System.Drawing.Point(298, 3);
            this.btnExitBookBorrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitBookBorrow.Name = "btnExitBookBorrow";
            this.btnExitBookBorrow.Size = new System.Drawing.Size(30, 30);
            this.btnExitBookBorrow.TabIndex = 1;
            this.btnExitBookBorrow.Text = "X";
            this.btnExitBookBorrow.UseVisualStyleBackColor = true;
            this.btnExitBookBorrow.Click += new System.EventHandler(this.btnExitBookBorrow_Click);
            // 
            // lbBookBorrow
            // 
            this.lbBookBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBookBorrow.AutoSize = true;
            this.lbBookBorrow.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbBookBorrow.Location = new System.Drawing.Point(119, 29);
            this.lbBookBorrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBookBorrow.Name = "lbBookBorrow";
            this.lbBookBorrow.Size = new System.Drawing.Size(114, 23);
            this.lbBookBorrow.TabIndex = 0;
            this.lbBookBorrow.Text = "Book Borrow";
            this.lbBookBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 592);
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
        private System.Windows.Forms.TableLayoutPanel tbGetBorrowInfo;
        private System.Windows.Forms.Label lbGetBorrowMemberID;
        private System.Windows.Forms.Label lbGetBorrowTransType;
        private System.Windows.Forms.Label lbGetBorrowTransDate;
        private System.Windows.Forms.Label lbGetBorrowDueDate;
        private System.Windows.Forms.TextBox txtGetBorrowMemberID;
        private System.Windows.Forms.DateTimePicker dtpGetBorrowDueDate;
        private System.Windows.Forms.DateTimePicker dtpGetGBorrowTransDate;
        private System.Windows.Forms.Label lbGetBorrowItem;
        private System.Windows.Forms.RichTextBox rtxtGetBorrowListItem;
        private System.Windows.Forms.TextBox txtGetTransType;
        private System.Windows.Forms.Panel pnlHeaderGetBorrowInfo;
        private System.Windows.Forms.Button btnExitBookBorrow;
        private System.Windows.Forms.Label lbBookBorrow;
    }
}