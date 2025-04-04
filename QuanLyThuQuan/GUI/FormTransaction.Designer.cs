﻿namespace QuanLyThuQuan.GUI
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
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoreOptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlResultMessageBox = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlChildDetailInfo = new System.Windows.Forms.Panel();
            this.pnlTransInfoContainer = new System.Windows.Forms.Panel();
            this.tbTransInfoWraper = new System.Windows.Forms.TableLayoutPanel();
            this.tbBlockInfoOne = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransID = new System.Windows.Forms.Label();
            this.lbMemID = new System.Windows.Forms.Label();
            this.tbBlockInfoTwo = new System.Windows.Forms.TableLayoutPanel();
            this.lbMemFullName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbBlockInfoThree = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransStatus = new System.Windows.Forms.Label();
            this.lbTransType = new System.Windows.Forms.Label();
            this.tbBlockInfoFour = new System.Windows.Forms.TableLayoutPanel();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbUserStatus = new System.Windows.Forms.Label();
            this.tbBlockInfoFive = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransDate = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.tbBlockInfoSix = new System.Windows.Forms.TableLayoutPanel();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserPhoneNumber = new System.Windows.Forms.Label();
            this.tbBlockInfoSeven = new System.Windows.Forms.TableLayoutPanel();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.lbListTransItems = new System.Windows.Forms.Label();
            this.tbBlockInfoEight = new System.Windows.Forms.TableLayoutPanel();
            this.lbViolationStatus = new System.Windows.Forms.Label();
            this.lbViolationList = new System.Windows.Forms.Label();
            this.dgvDataItemList = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDataViolationHandle = new System.Windows.Forms.DataGridView();
            this.colRuleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenaty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViolationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcuseViolation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeaderTransInfoDetail = new System.Windows.Forms.Panel();
            this.btnExitChildPanel = new System.Windows.Forms.Button();
            this.lbTransInfo = new System.Windows.Forms.Label();
            this.pnlHeaderGetBorrowInfo = new System.Windows.Forms.Panel();
            this.lbBookBorrow = new System.Windows.Forms.Label();
            this.btnExitBookBorrow = new System.Windows.Forms.Button();
            this.pnlBorrowBookBody = new System.Windows.Forms.Panel();
            this.tbGetBorrowInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtGetTransType = new System.Windows.Forms.TextBox();

            this.rtxtGetBorrowListItem = new System.Windows.Forms.RichTextBox();
            this.lbGetBorrowItem = new System.Windows.Forms.Label();
            this.dtpGetGBorrowTransDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGetBorrowDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtGetBorrowMemberID = new System.Windows.Forms.TextBox();
            this.lbGetBorrowDueDate = new System.Windows.Forms.Label();
            this.lbGetBorrowTransDate = new System.Windows.Forms.Label();
            this.lbGetBorrowTransType = new System.Windows.Forms.Label();
            this.lbGetBorrowMemberID = new System.Windows.Forms.Label();
            this.pnlBorrowBookFooter = new System.Windows.Forms.Panel();
            this.tbBorrowBookButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmitFormBorrow = new System.Windows.Forms.Button();
            this.btnCancelFormBorrow = new System.Windows.Forms.Button();
            this.btnResetFormBorrow = new System.Windows.Forms.Button();
            this.pnlFormBorrowBook = new System.Windows.Forms.Panel();
            this.pnlHeaderGetReturnInfo = new System.Windows.Forms.Panel();
            this.lbFormReturnBook = new System.Windows.Forms.Label();
            this.btnExitFormReturnBook = new System.Windows.Forms.Button();

            this.pnlReturnBookFooter = new System.Windows.Forms.Panel();
            this.tbReturnBookButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmitFormReturn = new System.Windows.Forms.Button();

            this.btnResetFromReturn = new System.Windows.Forms.Button();
            this.btnCancelFormReturn = new System.Windows.Forms.Button();
            this.pnlReturnBookBody = new System.Windows.Forms.Panel();
            this.tbGetReturnInfo = new System.Windows.Forms.TableLayoutPanel();
            this.dtpRealReturnDate = new System.Windows.Forms.DateTimePicker();
            this.rtxtReturnListItem = new System.Windows.Forms.RichTextBox();
            this.rtxtReturnPenalty = new System.Windows.Forms.RichTextBox();
            this.txtGetTransTypeReturn = new System.Windows.Forms.TextBox();
            this.txtGetMemberIDReturn = new System.Windows.Forms.TextBox();
            this.lbGetReturnItem = new System.Windows.Forms.Label();
            this.lbGetReturnPenaty = new System.Windows.Forms.Label();
            this.lbGetRealReturnDate = new System.Windows.Forms.Label();
            this.lbReturnTransType = new System.Windows.Forms.Label();
            this.lbGetReturnMemberID = new System.Windows.Forms.Label();
            this.pnlFormReturnBook = new System.Windows.Forms.Panel();
            this.tbHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransactions)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tbBody.SuspendLayout();
            this.pnlResultMessageBox.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlChildDetailInfo.SuspendLayout();
            this.pnlTransInfoContainer.SuspendLayout();
            this.tbTransInfoWraper.SuspendLayout();
            this.tbBlockInfoOne.SuspendLayout();
            this.tbBlockInfoTwo.SuspendLayout();
            this.tbBlockInfoThree.SuspendLayout();
            this.tbBlockInfoFour.SuspendLayout();
            this.tbBlockInfoFive.SuspendLayout();
            this.tbBlockInfoSix.SuspendLayout();
            this.tbBlockInfoSeven.SuspendLayout();
            this.tbBlockInfoEight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViolationHandle)).BeginInit();
            this.pnlHeaderTransInfoDetail.SuspendLayout();
            this.pnlHeaderGetBorrowInfo.SuspendLayout();
            this.pnlBorrowBookBody.SuspendLayout();
            this.tbGetBorrowInfo.SuspendLayout();
            this.pnlBorrowBookFooter.SuspendLayout();
            this.tbBorrowBookButtons.SuspendLayout();
            this.pnlFormBorrowBook.SuspendLayout();
            this.pnlHeaderGetReturnInfo.SuspendLayout();
            this.pnlReturnBookFooter.SuspendLayout();
            this.tbReturnBookButtons.SuspendLayout();
            this.pnlReturnBookBody.SuspendLayout();
            this.tbGetReturnInfo.SuspendLayout();
            this.pnlFormReturnBook.SuspendLayout();
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
            this.tbHeaderButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dgvDataTransactions
            // 
            this.dgvDataTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDataTransactions.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colMemberID,
            this.colTransactionType,
            this.colTransactionDate,
            this.colDueDate,
            this.colReturnDate,
            this.colStatus,
            this.colMoreOptions});
            this.dgvDataTransactions.Location = new System.Drawing.Point(3, 72);
            this.dgvDataTransactions.Name = "dgvDataTransactions";
            this.dgvDataTransactions.RowHeadersWidth = 62;
            this.dgvDataTransactions.Size = new System.Drawing.Size(954, 409);
            this.dgvDataTransactions.TabIndex = 1;
            this.dgvDataTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTransactions_CellContentClick);
            // 
            // colTransactionID
            // 
            this.colTransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionID.Frozen = true;
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.MinimumWidth = 8;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.ReadOnly = true;
            this.colTransactionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransactionID.Width = 170;
            // 
            // colMemberID
            // 
            this.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMemberID.Frozen = true;
            this.colMemberID.HeaderText = "MemberID";
            this.colMemberID.MinimumWidth = 8;
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMemberID.Width = 139;
            // 
            // colTransactionType
            // 
            this.colTransactionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransactionType.HeaderText = "Transaction Type";
            this.colTransactionType.MinimumWidth = 8;
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionDate.MinimumWidth = 8;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.ReadOnly = true;
            this.colTransactionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDueDate
            // 
            this.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.MinimumWidth = 8;
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colReturnDate
            // 
            this.colReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReturnDate.FillWeight = 130F;
            this.colReturnDate.HeaderText = "Return Date";
            this.colReturnDate.MinimumWidth = 8;
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReturnDate.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.Width = 104;
            // 
            // colMoreOptions
            // 
            this.colMoreOptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMoreOptions.HeaderText = "";
            this.colMoreOptions.MinimumWidth = 8;
            this.colMoreOptions.Name = "colMoreOptions";
            this.colMoreOptions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMoreOptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMoreOptions.Text = "More";
            this.colMoreOptions.Width = 25;
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
            this.lbTitle.Size = new System.Drawing.Size(261, 37);
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
            this.tbBody.Controls.Add(this.pnlResultMessageBox, 0, 2);
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
            this.tbBody.Paint += new System.Windows.Forms.PaintEventHandler(this.tbBody_Paint);
            // 
            // pnlResultMessageBox
            // 
            this.pnlResultMessageBox.Controls.Add(this.txtResult);
            this.pnlResultMessageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResultMessageBox.Location = new System.Drawing.Point(3, 517);
            this.pnlResultMessageBox.Name = "pnlResultMessageBox";
            this.pnlResultMessageBox.Size = new System.Drawing.Size(954, 24);
            this.pnlResultMessageBox.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(0, -1);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResult.Size = new System.Drawing.Size(954, 25);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "Result";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.Visible = false;
            // 

            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Black;
            this.pnlContainer.Controls.Add(this.pnlFormReturnBook);
            this.pnlContainer.Controls.Add(this.pnlFormBorrowBook);
            this.pnlContainer.Controls.Add(this.pnlChildDetailInfo);
            this.pnlContainer.Location = new System.Drawing.Point(12, 29);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(936, 592);
            this.pnlContainer.TabIndex = 8;
            this.pnlContainer.Visible = false;
            // 
            // pnlChildDetailInfo
            // 
            this.pnlChildDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChildDetailInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChildDetailInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChildDetailInfo.Controls.Add(this.pnlTransInfoContainer);
            this.pnlChildDetailInfo.Controls.Add(this.pnlHeaderTransInfoDetail);
            this.pnlChildDetailInfo.Location = new System.Drawing.Point(1, 0);
            this.pnlChildDetailInfo.Name = "pnlChildDetailInfo";
            this.pnlChildDetailInfo.Size = new System.Drawing.Size(936, 610);
            this.pnlChildDetailInfo.TabIndex = 11;
            this.pnlChildDetailInfo.Visible = false;
            // 
            // pnlTransInfoContainer
            // 
            this.pnlTransInfoContainer.Controls.Add(this.tbTransInfoWraper);
            this.pnlTransInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransInfoContainer.Location = new System.Drawing.Point(0, 34);
            this.pnlTransInfoContainer.Name = "pnlTransInfoContainer";
            this.pnlTransInfoContainer.Size = new System.Drawing.Size(934, 574);
            this.pnlTransInfoContainer.TabIndex = 4;
            // 
            // tbTransInfoWraper
            // 
            this.tbTransInfoWraper.BackColor = System.Drawing.Color.GhostWhite;
            this.tbTransInfoWraper.ColumnCount = 2;
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98713F));
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01287F));
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoOne, 0, 0);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoTwo, 1, 0);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoThree, 0, 1);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoFour, 1, 1);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoFive, 0, 2);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoSix, 1, 2);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoSeven, 0, 3);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoEight, 1, 3);
            this.tbTransInfoWraper.Controls.Add(this.dgvDataItemList, 0, 4);
            this.tbTransInfoWraper.Controls.Add(this.dgvDataViolationHandle, 1, 4);
            this.tbTransInfoWraper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTransInfoWraper.Location = new System.Drawing.Point(0, 0);
            this.tbTransInfoWraper.Name = "tbTransInfoWraper";
            this.tbTransInfoWraper.RowCount = 5;
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTransInfoWraper.Size = new System.Drawing.Size(934, 574);
            this.tbTransInfoWraper.TabIndex = 0;
            // 
            // tbBlockInfoOne
            // 
            this.tbBlockInfoOne.ColumnCount = 2;
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35106F));
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64894F));
            this.tbBlockInfoOne.Controls.Add(this.lbTransID, 0, 0);
            this.tbBlockInfoOne.Controls.Add(this.lbMemID, 0, 1);
            this.tbBlockInfoOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoOne.Location = new System.Drawing.Point(3, 3);
            this.tbBlockInfoOne.Name = "tbBlockInfoOne";
            this.tbBlockInfoOne.RowCount = 2;
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoOne.TabIndex = 0;
            // 
            // lbTransID
            // 
            this.lbTransID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransID.AutoSize = true;
            this.lbTransID.BackColor = System.Drawing.Color.Transparent;
            this.lbTransID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransID.Location = new System.Drawing.Point(3, 6);
            this.lbTransID.Name = "lbTransID";
            this.lbTransID.Size = new System.Drawing.Size(115, 19);
            this.lbTransID.TabIndex = 0;
            this.lbTransID.Text = "Transaction ID : ";
            this.lbTransID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMemID
            // 
            this.lbMemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemID.AutoSize = true;
            this.lbMemID.BackColor = System.Drawing.Color.Transparent;
            this.lbMemID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbMemID.Location = new System.Drawing.Point(3, 37);
            this.lbMemID.Name = "lbMemID";
            this.lbMemID.Size = new System.Drawing.Size(88, 19);
            this.lbMemID.TabIndex = 1;
            this.lbMemID.Text = "Member ID :";
            this.lbMemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoTwo
            // 
            this.tbBlockInfoTwo.ColumnCount = 2;
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoTwo.Controls.Add(this.lbMemFullName, 0, 0);
            this.tbBlockInfoTwo.Controls.Add(this.lbUserName, 0, 1);
            this.tbBlockInfoTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoTwo.Location = new System.Drawing.Point(385, 3);
            this.tbBlockInfoTwo.Name = "tbBlockInfoTwo";
            this.tbBlockInfoTwo.RowCount = 2;
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoTwo.TabIndex = 1;
            // 
            // lbMemFullName
            // 
            this.lbMemFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemFullName.AutoSize = true;
            this.lbMemFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbMemFullName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemFullName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbMemFullName.Location = new System.Drawing.Point(3, 6);
            this.lbMemFullName.Name = "lbMemFullName";
            this.lbMemFullName.Size = new System.Drawing.Size(141, 19);
            this.lbMemFullName.TabIndex = 0;
            this.lbMemFullName.Text = "Member Full Name :";
            this.lbMemFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserName.Location = new System.Drawing.Point(3, 37);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 19);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Member User Name :";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoThree
            // 
            this.tbBlockInfoThree.ColumnCount = 2;
            this.tbBlockInfoThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08511F));
            this.tbBlockInfoThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91489F));
            this.tbBlockInfoThree.Controls.Add(this.lbTransStatus, 0, 1);
            this.tbBlockInfoThree.Controls.Add(this.lbTransType, 0, 0);
            this.tbBlockInfoThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoThree.Location = new System.Drawing.Point(3, 72);
            this.tbBlockInfoThree.Name = "tbBlockInfoThree";
            this.tbBlockInfoThree.RowCount = 2;
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoThree.TabIndex = 2;
            // 
            // lbTransStatus
            // 
            this.lbTransStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransStatus.AutoSize = true;
            this.lbTransStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbTransStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransStatus.Location = new System.Drawing.Point(3, 37);
            this.lbTransStatus.Name = "lbTransStatus";
            this.lbTransStatus.Size = new System.Drawing.Size(140, 19);
            this.lbTransStatus.TabIndex = 0;
            this.lbTransStatus.Text = "Transaction Status :";
            this.lbTransStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransType
            // 
            this.lbTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransType.AutoSize = true;
            this.lbTransType.BackColor = System.Drawing.Color.Transparent;
            this.lbTransType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransType.Location = new System.Drawing.Point(3, 6);
            this.lbTransType.Name = "lbTransType";
            this.lbTransType.Size = new System.Drawing.Size(129, 19);
            this.lbTransType.TabIndex = 0;
            this.lbTransType.Text = "Transaction Type :";
            this.lbTransType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoFour
            // 
            this.tbBlockInfoFour.ColumnCount = 2;
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoFour.Controls.Add(this.lbUserType, 0, 0);
            this.tbBlockInfoFour.Controls.Add(this.lbUserStatus, 0, 1);
            this.tbBlockInfoFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoFour.Location = new System.Drawing.Point(385, 72);
            this.tbBlockInfoFour.Name = "tbBlockInfoFour";
            this.tbBlockInfoFour.RowCount = 2;
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoFour.TabIndex = 3;
            // 
            // lbUserType
            // 
            this.lbUserType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserType.AutoSize = true;
            this.lbUserType.BackColor = System.Drawing.Color.Transparent;
            this.lbUserType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserType.Location = new System.Drawing.Point(3, 6);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(80, 19);
            this.lbUserType.TabIndex = 1;
            this.lbUserType.Text = "User Type :";
            this.lbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbUserStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserStatus.Location = new System.Drawing.Point(3, 37);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(91, 19);
            this.lbUserStatus.TabIndex = 2;
            this.lbUserStatus.Text = "User Status :";
            this.lbUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoFive
            // 
            this.tbBlockInfoFive.ColumnCount = 2;
            this.tbBlockInfoFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08511F));
            this.tbBlockInfoFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91489F));
            this.tbBlockInfoFive.Controls.Add(this.lbTransDate, 0, 0);
            this.tbBlockInfoFive.Controls.Add(this.lbDueDate, 0, 1);
            this.tbBlockInfoFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoFive.Location = new System.Drawing.Point(3, 141);
            this.tbBlockInfoFive.Name = "tbBlockInfoFive";
            this.tbBlockInfoFive.RowCount = 2;
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoFive.TabIndex = 4;
            // 
            // lbTransDate
            // 
            this.lbTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransDate.AutoSize = true;
            this.lbTransDate.BackColor = System.Drawing.Color.Transparent;
            this.lbTransDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransDate.Location = new System.Drawing.Point(3, 6);
            this.lbTransDate.Name = "lbTransDate";
            this.lbTransDate.Size = new System.Drawing.Size(130, 19);
            this.lbTransDate.TabIndex = 0;
            this.lbTransDate.Text = "Transaction Date :";
            this.lbTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDueDate
            // 
            this.lbDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDueDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDueDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbDueDate.Location = new System.Drawing.Point(3, 37);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(78, 19);
            this.lbDueDate.TabIndex = 1;
            this.lbDueDate.Text = "Due Date :";
            this.lbDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoSix
            // 
            this.tbBlockInfoSix.ColumnCount = 2;
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoSix.Controls.Add(this.lbUserEmail, 0, 0);
            this.tbBlockInfoSix.Controls.Add(this.lbUserPhoneNumber, 0, 1);
            this.tbBlockInfoSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoSix.Location = new System.Drawing.Point(385, 141);
            this.tbBlockInfoSix.Name = "tbBlockInfoSix";
            this.tbBlockInfoSix.RowCount = 2;
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoSix.TabIndex = 5;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbUserEmail.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserEmail.Location = new System.Drawing.Point(3, 6);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(85, 19);
            this.lbUserEmail.TabIndex = 0;
            this.lbUserEmail.Text = "User Email :";
            this.lbUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserPhoneNumber
            // 
            this.lbUserPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserPhoneNumber.AutoSize = true;
            this.lbUserPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbUserPhoneNumber.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserPhoneNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserPhoneNumber.Location = new System.Drawing.Point(3, 37);
            this.lbUserPhoneNumber.Name = "lbUserPhoneNumber";
            this.lbUserPhoneNumber.Size = new System.Drawing.Size(116, 19);
            this.lbUserPhoneNumber.TabIndex = 1;
            this.lbUserPhoneNumber.Text = "Phone Number :";
            this.lbUserPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoSeven
            // 
            this.tbBlockInfoSeven.ColumnCount = 2;
            this.tbBlockInfoSeven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35106F));
            this.tbBlockInfoSeven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64894F));
            this.tbBlockInfoSeven.Controls.Add(this.lbReturnDate, 0, 0);
            this.tbBlockInfoSeven.Controls.Add(this.lbListTransItems, 0, 1);
            this.tbBlockInfoSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoSeven.Location = new System.Drawing.Point(3, 210);
            this.tbBlockInfoSeven.Name = "tbBlockInfoSeven";
            this.tbBlockInfoSeven.RowCount = 2;
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoSeven.TabIndex = 6;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lbReturnDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbReturnDate.Location = new System.Drawing.Point(3, 6);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(98, 19);
            this.lbReturnDate.TabIndex = 0;
            this.lbReturnDate.Text = "Return Date :";
            this.lbReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbListTransItems
            // 
            this.lbListTransItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbListTransItems.AutoSize = true;
            this.lbListTransItems.BackColor = System.Drawing.Color.Transparent;
            this.lbListTransItems.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListTransItems.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbListTransItems.Location = new System.Drawing.Point(3, 37);
            this.lbListTransItems.Name = "lbListTransItems";
            this.lbListTransItems.Size = new System.Drawing.Size(155, 19);
            this.lbListTransItems.TabIndex = 1;
            this.lbListTransItems.Text = "Transaction Item List :";
            this.lbListTransItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoEight
            // 
            this.tbBlockInfoEight.BackColor = System.Drawing.Color.GhostWhite;
            this.tbBlockInfoEight.ColumnCount = 2;
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoEight.Controls.Add(this.lbViolationStatus, 0, 0);
            this.tbBlockInfoEight.Controls.Add(this.lbViolationList, 0, 1);
            this.tbBlockInfoEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoEight.Location = new System.Drawing.Point(385, 210);
            this.tbBlockInfoEight.Name = "tbBlockInfoEight";
            this.tbBlockInfoEight.RowCount = 2;
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoEight.TabIndex = 7;
            // 
            // lbViolationStatus
            // 
            this.lbViolationStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolationStatus.AutoSize = true;
            this.lbViolationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbViolationStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolationStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbViolationStatus.Location = new System.Drawing.Point(3, 6);
            this.lbViolationStatus.Name = "lbViolationStatus";
            this.lbViolationStatus.Size = new System.Drawing.Size(120, 19);
            this.lbViolationStatus.TabIndex = 0;
            this.lbViolationStatus.Text = "Violation Status :";
            this.lbViolationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbViolationList
            // 
            this.lbViolationList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolationList.AutoSize = true;
            this.lbViolationList.BackColor = System.Drawing.Color.Transparent;
            this.lbViolationList.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolationList.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbViolationList.Location = new System.Drawing.Point(3, 37);
            this.lbViolationList.Name = "lbViolationList";
            this.lbViolationList.Size = new System.Drawing.Size(101, 19);
            this.lbViolationList.TabIndex = 1;
            this.lbViolationList.Text = "Violation List :";
            this.lbViolationList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDataItemList
            // 
            this.dgvDataItemList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDataItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemQuantity});
            this.dgvDataItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataItemList.Location = new System.Drawing.Point(3, 279);
            this.dgvDataItemList.Name = "dgvDataItemList";
            this.dgvDataItemList.Size = new System.Drawing.Size(376, 292);
            this.dgvDataItemList.TabIndex = 10;
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.ReadOnly = true;
            this.colItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemQuantity.Width = 87;
            // 
            // dgvDataViolationHandle
            // 
            this.dgvDataViolationHandle.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDataViolationHandle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataViolationHandle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleTitle,
            this.colPenaty,
            this.colViolationDate,
            this.colPaidStatus,
            this.colExcuseViolation});
            this.dgvDataViolationHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataViolationHandle.Location = new System.Drawing.Point(385, 279);
            this.dgvDataViolationHandle.Name = "dgvDataViolationHandle";
            this.dgvDataViolationHandle.Size = new System.Drawing.Size(546, 292);
            this.dgvDataViolationHandle.TabIndex = 11;
            // 
            // colRuleTitle
            // 
            this.colRuleTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRuleTitle.HeaderText = "Rule";
            this.colRuleTitle.Name = "colRuleTitle";
            this.colRuleTitle.ReadOnly = true;
            this.colRuleTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPenaty
            // 
            this.colPenaty.HeaderText = "Penaty";
            this.colPenaty.Name = "colPenaty";
            this.colPenaty.ReadOnly = true;
            this.colPenaty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colViolationDate
            // 
            this.colViolationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colViolationDate.HeaderText = "Violation Date";
            this.colViolationDate.Name = "colViolationDate";
            this.colViolationDate.ReadOnly = true;
            this.colViolationDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colViolationDate.Width = 118;
            // 
            // colPaidStatus
            // 
            this.colPaidStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPaidStatus.HeaderText = "Paid Status";
            this.colPaidStatus.Name = "colPaidStatus";
            this.colPaidStatus.ReadOnly = true;
            this.colPaidStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaidStatus.Width = 101;
            // 
            // colExcuseViolation
            // 
            this.colExcuseViolation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExcuseViolation.HeaderText = "";
            this.colExcuseViolation.Name = "colExcuseViolation";
            this.colExcuseViolation.ReadOnly = true;
            this.colExcuseViolation.Width = 20;
            // 
            // pnlHeaderTransInfoDetail
            // 
            this.pnlHeaderTransInfoDetail.BackColor = System.Drawing.Color.Snow;
            this.pnlHeaderTransInfoDetail.Controls.Add(this.btnExitChildPanel);
            this.pnlHeaderTransInfoDetail.Controls.Add(this.lbTransInfo);
            this.pnlHeaderTransInfoDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTransInfoDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTransInfoDetail.Name = "pnlHeaderTransInfoDetail";
            this.pnlHeaderTransInfoDetail.Size = new System.Drawing.Size(934, 34);
            this.pnlHeaderTransInfoDetail.TabIndex = 1;
            // 
            // btnExitChildPanel
            // 
            this.btnExitChildPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitChildPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChildPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitChildPanel.ForeColor = System.Drawing.Color.Red;
            this.btnExitChildPanel.Location = new System.Drawing.Point(900, 1);
            this.btnExitChildPanel.Name = "btnExitChildPanel";
            this.btnExitChildPanel.Size = new System.Drawing.Size(30, 30);
            this.btnExitChildPanel.TabIndex = 1;
            this.btnExitChildPanel.Text = "X";
            this.btnExitChildPanel.UseVisualStyleBackColor = false;
            // 
            // lbTransInfo
            // 
            this.lbTransInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTransInfo.AutoSize = true;
            this.lbTransInfo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbTransInfo.Location = new System.Drawing.Point(382, 3);
            this.lbTransInfo.Name = "lbTransInfo";
            this.lbTransInfo.Size = new System.Drawing.Size(208, 23);
            this.lbTransInfo.TabIndex = 0;
            this.lbTransInfo.Text = "Transaction Information";
            this.lbTransInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderGetBorrowInfo
            // 
            this.pnlHeaderGetBorrowInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.btnExitBookBorrow);
            this.pnlHeaderGetBorrowInfo.Controls.Add(this.lbBookBorrow);
            this.pnlHeaderGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetBorrowInfo.Name = "pnlHeaderGetBorrowInfo";
            this.pnlHeaderGetBorrowInfo.Size = new System.Drawing.Size(333, 54);
            this.pnlHeaderGetBorrowInfo.TabIndex = 0;
            // 
            // lbBookBorrow
            // 
            this.lbBookBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBookBorrow.AutoSize = true;
            this.lbBookBorrow.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbBookBorrow.Location = new System.Drawing.Point(117, 29);
            this.lbBookBorrow.Name = "lbBookBorrow";
            this.lbBookBorrow.Size = new System.Drawing.Size(114, 23);
            this.lbBookBorrow.TabIndex = 0;
            this.lbBookBorrow.Text = "Book Borrow";
            this.lbBookBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitBookBorrow
            // 
            this.btnExitBookBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitBookBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnExitBookBorrow.Location = new System.Drawing.Point(298, 3);
            this.btnExitBookBorrow.Name = "btnExitBookBorrow";
            this.btnExitBookBorrow.Size = new System.Drawing.Size(30, 30);
            this.btnExitBookBorrow.TabIndex = 1;
            this.btnExitBookBorrow.Text = "X";
            this.btnExitBookBorrow.UseVisualStyleBackColor = true;

            // 
            // pnlBorrowBookBody
            // 
            this.pnlBorrowBookBody.Controls.Add(this.tbGetBorrowInfo);
            this.pnlBorrowBookBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorrowBookBody.Location = new System.Drawing.Point(0, 54);
            this.pnlBorrowBookBody.Name = "pnlBorrowBookBody";
            this.pnlBorrowBookBody.Size = new System.Drawing.Size(333, 536);
            this.pnlBorrowBookBody.TabIndex = 1;
            // 
            // tbGetBorrowInfo
            // 
            this.tbGetBorrowInfo.BackColor = System.Drawing.Color.GhostWhite;
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
            this.tbGetBorrowInfo.Controls.Add(this.rtxtGetBorrowListItem, 1, 4);
            this.tbGetBorrowInfo.Controls.Add(this.txtGetTransType, 1, 1);
            this.tbGetBorrowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGetBorrowInfo.Location = new System.Drawing.Point(0, 0);
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
            this.tbGetBorrowInfo.Size = new System.Drawing.Size(333, 536);
            this.tbGetBorrowInfo.TabIndex = 1;
            // 
            // txtGetTransType
            // 

            this.txtGetTransType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetTransType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetTransType.Enabled = false;
            this.txtGetTransType.Location = new System.Drawing.Point(128, 103);
            this.txtGetTransType.Name = "txtGetTransType";
            this.txtGetTransType.ReadOnly = true;
            this.txtGetTransType.Size = new System.Drawing.Size(201, 25);
            this.txtGetTransType.TabIndex = 13;

            // 
            // rtxtGetBorrowListItem
            // 

            this.rtxtGetBorrowListItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtGetBorrowListItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtGetBorrowListItem.Location = new System.Drawing.Point(128, 323);
            this.rtxtGetBorrowListItem.Name = "rtxtGetBorrowListItem";
            this.rtxtGetBorrowListItem.Size = new System.Drawing.Size(201, 153);
            this.rtxtGetBorrowListItem.TabIndex = 9;
            this.rtxtGetBorrowListItem.Text = "(write id of this book, delimited by commas)";

            // 
            // lbGetBorrowItem
            // 

            this.lbGetBorrowItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowItem.AutoSize = true;
            this.lbGetBorrowItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowItem.Location = new System.Drawing.Point(3, 390);
            this.lbGetBorrowItem.Name = "lbGetBorrowItem";
            this.lbGetBorrowItem.Size = new System.Drawing.Size(67, 19);
            this.lbGetBorrowItem.TabIndex = 5;
            this.lbGetBorrowItem.Text = "List Item :";
            this.lbGetBorrowItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dtpGetGBorrowTransDate
            // 
            this.dtpGetGBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGetGBorrowTransDate.Enabled = false;
            this.dtpGetGBorrowTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetGBorrowTransDate.Location = new System.Drawing.Point(128, 177);
            this.dtpGetGBorrowTransDate.Name = "dtpGetGBorrowTransDate";
            this.dtpGetGBorrowTransDate.Size = new System.Drawing.Size(201, 30);
            this.dtpGetGBorrowTransDate.TabIndex = 12;
            // 
            // dtpGetBorrowDueDate
            // 

            this.dtpGetBorrowDueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGetBorrowDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGetBorrowDueDate.Location = new System.Drawing.Point(128, 257);
            this.dtpGetBorrowDueDate.Name = "dtpGetBorrowDueDate";
            this.dtpGetBorrowDueDate.Size = new System.Drawing.Size(201, 25);
            this.dtpGetBorrowDueDate.TabIndex = 10;

            // 
            // txtGetBorrowMemberID
            // 
            this.txtGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetBorrowMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetBorrowMemberID.Location = new System.Drawing.Point(128, 26);
            this.txtGetBorrowMemberID.Name = "txtGetBorrowMemberID";
            this.txtGetBorrowMemberID.Size = new System.Drawing.Size(201, 25);
            this.txtGetBorrowMemberID.TabIndex = 6;
            this.txtGetBorrowMemberID.Text = "Member ID";
            // 
            // lbGetBorrowDueDate
            // 

            this.lbGetBorrowDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowDueDate.AutoSize = true;
            this.lbGetBorrowDueDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowDueDate.Location = new System.Drawing.Point(3, 260);
            this.lbGetBorrowDueDate.Name = "lbGetBorrowDueDate";
            this.lbGetBorrowDueDate.Size = new System.Drawing.Size(70, 19);
            this.lbGetBorrowDueDate.TabIndex = 3;
            this.lbGetBorrowDueDate.Text = "Due Date :";
            this.lbGetBorrowDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lbGetBorrowTransDate
            // 
            this.lbGetBorrowTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowTransDate.AutoSize = true;
            this.lbGetBorrowTransDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowTransDate.Location = new System.Drawing.Point(3, 183);
            this.lbGetBorrowTransDate.Name = "lbGetBorrowTransDate";
            this.lbGetBorrowTransDate.Size = new System.Drawing.Size(116, 19);
            this.lbGetBorrowTransDate.TabIndex = 2;
            this.lbGetBorrowTransDate.Text = "Transaction Date :";
            this.lbGetBorrowTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowTransType
            // 
            this.lbGetBorrowTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowTransType.AutoSize = true;
            this.lbGetBorrowTransType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowTransType.Location = new System.Drawing.Point(3, 106);
            this.lbGetBorrowTransType.Name = "lbGetBorrowTransType";
            this.lbGetBorrowTransType.Size = new System.Drawing.Size(117, 19);
            this.lbGetBorrowTransType.TabIndex = 1;
            this.lbGetBorrowTransType.Text = "Transaction Type :";
            this.lbGetBorrowTransType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGetBorrowMemberID
            // 

            this.lbGetBorrowMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetBorrowMemberID.AutoSize = true;
            this.lbGetBorrowMemberID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetBorrowMemberID.Location = new System.Drawing.Point(3, 29);
            this.lbGetBorrowMemberID.Name = "lbGetBorrowMemberID";
            this.lbGetBorrowMemberID.Size = new System.Drawing.Size(82, 19);
            this.lbGetBorrowMemberID.TabIndex = 0;
            this.lbGetBorrowMemberID.Text = "Member ID :";
            this.lbGetBorrowMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlBorrowBookFooter
            // 
            this.pnlBorrowBookFooter.Controls.Add(this.tbBorrowBookButtons);
            this.pnlBorrowBookFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorrowBookFooter.Location = new System.Drawing.Point(0, 551);
            this.pnlBorrowBookFooter.Name = "pnlBorrowBookFooter";
            this.pnlBorrowBookFooter.Size = new System.Drawing.Size(333, 39);
            this.pnlBorrowBookFooter.TabIndex = 0;
            // 
            // tbBorrowBookButtons
            // 
            this.tbBorrowBookButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbBorrowBookButtons.ColumnCount = 3;
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbBorrowBookButtons.Controls.Add(this.btnResetFormBorrow, 1, 0);
            this.tbBorrowBookButtons.Controls.Add(this.btnCancelFormBorrow, 0, 0);
            this.tbBorrowBookButtons.Controls.Add(this.btnSubmitFormBorrow, 2, 0);
            this.tbBorrowBookButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBorrowBookButtons.Location = new System.Drawing.Point(0, 0);
            this.tbBorrowBookButtons.Name = "tbBorrowBookButtons";
            this.tbBorrowBookButtons.RowCount = 1;
            this.tbBorrowBookButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBorrowBookButtons.Size = new System.Drawing.Size(333, 39);
            this.tbBorrowBookButtons.TabIndex = 0;
            // 
            // btnSubmitFormBorrow
            // 
            this.btnSubmitFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitFormBorrow.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitFormBorrow.Location = new System.Drawing.Point(240, 5);
            this.btnSubmitFormBorrow.Name = "btnSubmitFormBorrow";
            this.btnSubmitFormBorrow.Size = new System.Drawing.Size(75, 29);
            this.btnSubmitFormBorrow.TabIndex = 0;
            this.btnSubmitFormBorrow.Text = "Submit";
            this.btnSubmitFormBorrow.UseVisualStyleBackColor = true;
            // 
            // btnCancelFormBorrow
            // 
            this.btnCancelFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFormBorrow.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormBorrow.Location = new System.Drawing.Point(18, 5);
            this.btnCancelFormBorrow.Name = "btnCancelFormBorrow";
            this.btnCancelFormBorrow.Size = new System.Drawing.Size(75, 29);
            this.btnCancelFormBorrow.TabIndex = 2;
            this.btnCancelFormBorrow.Text = "Cancel";
            this.btnCancelFormBorrow.UseVisualStyleBackColor = true;
            // 
            // btnResetFormBorrow
            // 
            this.btnResetFormBorrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetFormBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnResetFormBorrow.Location = new System.Drawing.Point(129, 5);
            this.btnResetFormBorrow.Name = "btnResetFormBorrow";
            this.btnResetFormBorrow.Size = new System.Drawing.Size(75, 29);
            this.btnResetFormBorrow.TabIndex = 1;
            this.btnResetFormBorrow.Text = "Reset";
            this.btnResetFormBorrow.UseVisualStyleBackColor = true;
            // 
            // pnlFormBorrowBook
            // 
            this.pnlFormBorrowBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFormBorrowBook.BackColor = System.Drawing.Color.Black;
            this.pnlFormBorrowBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookFooter);
            this.pnlFormBorrowBook.Controls.Add(this.pnlBorrowBookBody);
            this.pnlFormBorrowBook.Controls.Add(this.pnlHeaderGetBorrowInfo);
            this.pnlFormBorrowBook.Location = new System.Drawing.Point(300, 0);
            this.pnlFormBorrowBook.Name = "pnlFormBorrowBook";
            this.pnlFormBorrowBook.Size = new System.Drawing.Size(335, 592);
            this.pnlFormBorrowBook.TabIndex = 12;
            this.pnlFormBorrowBook.Visible = false;
            // 
            // pnlHeaderGetReturnInfo
            // 
            this.pnlHeaderGetReturnInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeaderGetReturnInfo.Controls.Add(this.btnExitFormReturnBook);
            this.pnlHeaderGetReturnInfo.Controls.Add(this.lbFormReturnBook);
            this.pnlHeaderGetReturnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderGetReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderGetReturnInfo.Name = "pnlHeaderGetReturnInfo";
            this.pnlHeaderGetReturnInfo.Size = new System.Drawing.Size(333, 54);
            this.pnlHeaderGetReturnInfo.TabIndex = 0;
            // 
            // lbFormReturnBook
            // 
            this.lbFormReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFormReturnBook.AutoSize = true;
            this.lbFormReturnBook.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbFormReturnBook.Location = new System.Drawing.Point(117, 20);
            this.lbFormReturnBook.Name = "lbFormReturnBook";
            this.lbFormReturnBook.Size = new System.Drawing.Size(111, 23);
            this.lbFormReturnBook.TabIndex = 3;
            this.lbFormReturnBook.Text = "Return Book";
            this.lbFormReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitFormReturnBook
            // 
            this.btnExitFormReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormReturnBook.ForeColor = System.Drawing.Color.Red;
            this.btnExitFormReturnBook.Location = new System.Drawing.Point(298, 3);
            this.btnExitFormReturnBook.Name = "btnExitFormReturnBook";
            this.btnExitFormReturnBook.Size = new System.Drawing.Size(30, 30);
            this.btnExitFormReturnBook.TabIndex = 4;
            this.btnExitFormReturnBook.Text = "X";
            this.btnExitFormReturnBook.UseVisualStyleBackColor = true;
            // 
            // pnlReturnBookFooter
            // 
            this.pnlReturnBookFooter.Controls.Add(this.tbReturnBookButtons);
            this.pnlReturnBookFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReturnBookFooter.Location = new System.Drawing.Point(0, 551);
            this.pnlReturnBookFooter.Name = "pnlReturnBookFooter";
            this.pnlReturnBookFooter.Size = new System.Drawing.Size(333, 39);
            this.pnlReturnBookFooter.TabIndex = 1;
            // 
            // tbReturnBookButtons
            // 
            this.tbReturnBookButtons.BackColor = System.Drawing.Color.GhostWhite;
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
            this.tbReturnBookButtons.Size = new System.Drawing.Size(333, 39);
            this.tbReturnBookButtons.TabIndex = 0;
            // 
            // btnSubmitFormReturn
            // 
            this.btnSubmitFormReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitFormReturn.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnSubmitFormReturn.Location = new System.Drawing.Point(240, 5);
            this.btnSubmitFormReturn.Name = "btnSubmitFormReturn";
            this.btnSubmitFormReturn.Size = new System.Drawing.Size(75, 29);
            this.btnSubmitFormReturn.TabIndex = 2;
            this.btnSubmitFormReturn.Text = "Submit";
            this.btnSubmitFormReturn.UseVisualStyleBackColor = true;
            // 
            // btnResetFromReturn
            // 
            this.btnResetFromReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetFromReturn.ForeColor = System.Drawing.Color.Black;
            this.btnResetFromReturn.Location = new System.Drawing.Point(129, 5);
            this.btnResetFromReturn.Name = "btnResetFromReturn";
            this.btnResetFromReturn.Size = new System.Drawing.Size(75, 29);
            this.btnResetFromReturn.TabIndex = 1;
            this.btnResetFromReturn.Text = "Reset";
            this.btnResetFromReturn.UseVisualStyleBackColor = true;
            // 
            // btnCancelFormReturn
            // 
            this.btnCancelFormReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFormReturn.ForeColor = System.Drawing.Color.Red;
            this.btnCancelFormReturn.Location = new System.Drawing.Point(18, 5);
            this.btnCancelFormReturn.Name = "btnCancelFormReturn";
            this.btnCancelFormReturn.Size = new System.Drawing.Size(75, 29);
            this.btnCancelFormReturn.TabIndex = 0;
            this.btnCancelFormReturn.Text = "Cancel";
            this.btnCancelFormReturn.UseVisualStyleBackColor = true;
            // 
            // pnlReturnBookBody
            // 
            this.pnlReturnBookBody.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlReturnBookBody.Controls.Add(this.tbGetReturnInfo);
            this.pnlReturnBookBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturnBookBody.Location = new System.Drawing.Point(0, 54);
            this.pnlReturnBookBody.Name = "pnlReturnBookBody";
            this.pnlReturnBookBody.Size = new System.Drawing.Size(333, 497);
            this.pnlReturnBookBody.TabIndex = 2;
            // 
            // tbGetReturnInfo
            // 
            this.tbGetReturnInfo.BackColor = System.Drawing.Color.GhostWhite;
            this.tbGetReturnInfo.ColumnCount = 2;
            this.tbGetReturnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.61194F));
            this.tbGetReturnInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.38806F));
            this.tbGetReturnInfo.Controls.Add(this.lbGetReturnMemberID, 0, 0);
            this.tbGetReturnInfo.Controls.Add(this.lbReturnTransType, 0, 1);
            this.tbGetReturnInfo.Controls.Add(this.lbGetRealReturnDate, 0, 2);
            this.tbGetReturnInfo.Controls.Add(this.lbGetReturnPenaty, 0, 3);
            this.tbGetReturnInfo.Controls.Add(this.lbGetReturnItem, 0, 4);
            this.tbGetReturnInfo.Controls.Add(this.txtGetMemberIDReturn, 1, 0);
            this.tbGetReturnInfo.Controls.Add(this.txtGetTransTypeReturn, 1, 1);
            this.tbGetReturnInfo.Controls.Add(this.rtxtReturnPenalty, 1, 3);
            this.tbGetReturnInfo.Controls.Add(this.rtxtReturnListItem, 1, 4);
            this.tbGetReturnInfo.Controls.Add(this.dtpRealReturnDate, 1, 2);
            this.tbGetReturnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGetReturnInfo.Location = new System.Drawing.Point(0, 0);
            this.tbGetReturnInfo.Name = "tbGetReturnInfo";
            this.tbGetReturnInfo.RowCount = 5;
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tbGetReturnInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tbGetReturnInfo.Size = new System.Drawing.Size(333, 497);
            this.tbGetReturnInfo.TabIndex = 3;
            // 

            // dtpRealReturnDate
            // 
            this.dtpRealReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpRealReturnDate.Enabled = false;
            this.dtpRealReturnDate.Location = new System.Drawing.Point(128, 197);
            this.dtpRealReturnDate.Name = "dtpRealReturnDate";
            this.dtpRealReturnDate.Size = new System.Drawing.Size(201, 25);
            this.dtpRealReturnDate.TabIndex = 9;
            // 
            // rtxtReturnListItem
            // 
            this.rtxtReturnListItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.rtxtReturnListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtReturnListItem.Location = new System.Drawing.Point(128, 376);
            this.rtxtReturnListItem.Name = "rtxtReturnListItem";
            this.rtxtReturnListItem.Size = new System.Drawing.Size(202, 118);
            this.rtxtReturnListItem.TabIndex = 8;
            this.rtxtReturnListItem.Text = "";
            // 

            // rtxtReturnPenalty
            // 
            this.rtxtReturnPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtReturnPenalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtReturnPenalty.Enabled = false;
            this.rtxtReturnPenalty.Location = new System.Drawing.Point(128, 255);
            this.rtxtReturnPenalty.Name = "rtxtReturnPenalty";
            this.rtxtReturnPenalty.ReadOnly = true;
            this.rtxtReturnPenalty.Size = new System.Drawing.Size(202, 115);
            this.rtxtReturnPenalty.TabIndex = 7;
            this.rtxtReturnPenalty.Text = "";
            // 
            // txtGetTransTypeReturn
            // 
            this.txtGetTransTypeReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetTransTypeReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetTransTypeReturn.Enabled = false;
            this.txtGetTransTypeReturn.Location = new System.Drawing.Point(128, 113);
            this.txtGetTransTypeReturn.Name = "txtGetTransTypeReturn";
            this.txtGetTransTypeReturn.ReadOnly = true;
            this.txtGetTransTypeReturn.Size = new System.Drawing.Size(201, 25);
            this.txtGetTransTypeReturn.TabIndex = 6;
            // 
            // txtGetMemberIDReturn
            // 
            this.txtGetMemberIDReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetMemberIDReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetMemberIDReturn.Location = new System.Drawing.Point(128, 29);
            this.txtGetMemberIDReturn.Name = "txtGetMemberIDReturn";
            this.txtGetMemberIDReturn.Size = new System.Drawing.Size(201, 25);
            this.txtGetMemberIDReturn.TabIndex = 5;
            this.txtGetMemberIDReturn.Text = "Member ID";
            // 
            // lbGetReturnItem
            // 
            this.lbGetReturnItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetReturnItem.AutoSize = true;
            this.lbGetReturnItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetReturnItem.Location = new System.Drawing.Point(3, 425);
            this.lbGetReturnItem.Name = "lbGetReturnItem";
            this.lbGetReturnItem.Size = new System.Drawing.Size(67, 19);
            this.lbGetReturnItem.TabIndex = 4;
            this.lbGetReturnItem.Text = "List Item :";
            this.lbGetReturnItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGetReturnPenaty
            // 
            this.lbGetReturnPenaty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetReturnPenaty.AutoSize = true;
            this.lbGetReturnPenaty.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetReturnPenaty.Location = new System.Drawing.Point(3, 303);
            this.lbGetReturnPenaty.Name = "lbGetReturnPenaty";
            this.lbGetReturnPenaty.Size = new System.Drawing.Size(60, 19);
            this.lbGetReturnPenaty.TabIndex = 3;
            this.lbGetReturnPenaty.Text = "Penalty :";
            this.lbGetReturnPenaty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGetRealReturnDate
            // 
            this.lbGetRealReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetRealReturnDate.AutoSize = true;
            this.lbGetRealReturnDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetRealReturnDate.Location = new System.Drawing.Point(3, 200);
            this.lbGetRealReturnDate.Name = "lbGetRealReturnDate";
            this.lbGetRealReturnDate.Size = new System.Drawing.Size(115, 19);
            this.lbGetRealReturnDate.TabIndex = 2;
            this.lbGetRealReturnDate.Text = "Real Return Date :";
            this.lbGetRealReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReturnTransType
            // 
            this.lbReturnTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbReturnTransType.AutoSize = true;
            this.lbReturnTransType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbReturnTransType.Location = new System.Drawing.Point(3, 116);
            this.lbReturnTransType.Name = "lbReturnTransType";
            this.lbReturnTransType.Size = new System.Drawing.Size(117, 19);
            this.lbReturnTransType.TabIndex = 1;
            this.lbReturnTransType.Text = "Transaction Type :";
            this.lbReturnTransType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGetReturnMemberID
            // 
            this.lbGetReturnMemberID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbGetReturnMemberID.AutoSize = true;
            this.lbGetReturnMemberID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbGetReturnMemberID.Location = new System.Drawing.Point(3, 32);
            this.lbGetReturnMemberID.Name = "lbGetReturnMemberID";
            this.lbGetReturnMemberID.Size = new System.Drawing.Size(82, 19);
            this.lbGetReturnMemberID.TabIndex = 0;
            this.lbGetReturnMemberID.Text = "Member ID :";
            this.lbGetReturnMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFormReturnBook
            // 
            this.pnlFormReturnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFormReturnBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlFormReturnBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormReturnBook.Controls.Add(this.pnlReturnBookBody);
            this.pnlFormReturnBook.Controls.Add(this.pnlReturnBookFooter);
            this.pnlFormReturnBook.Controls.Add(this.pnlHeaderGetReturnInfo);
            this.pnlFormReturnBook.Location = new System.Drawing.Point(301, 0);
            this.pnlFormReturnBook.Name = "pnlFormReturnBook";
            this.pnlFormReturnBook.Size = new System.Drawing.Size(335, 592);
            this.pnlFormReturnBook.TabIndex = 15;
            this.pnlFormReturnBook.Visible = false;
            // 

            // pnlHeaderTransInfoDetail
            // 
            this.pnlHeaderTransInfoDetail.BackColor = System.Drawing.Color.Snow;
            this.pnlHeaderTransInfoDetail.Controls.Add(this.btnExitChildPanel);
            this.pnlHeaderTransInfoDetail.Controls.Add(this.lbTransInfo);
            this.pnlHeaderTransInfoDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTransInfoDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTransInfoDetail.Name = "pnlHeaderTransInfoDetail";
            this.pnlHeaderTransInfoDetail.Size = new System.Drawing.Size(934, 34);
            this.pnlHeaderTransInfoDetail.TabIndex = 1;
            // 
            // lbTransInfo
            // 
            this.lbTransInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTransInfo.AutoSize = true;
            this.lbTransInfo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbTransInfo.Location = new System.Drawing.Point(382, 3);
            this.lbTransInfo.Name = "lbTransInfo";
            this.lbTransInfo.Size = new System.Drawing.Size(208, 23);
            this.lbTransInfo.TabIndex = 0;
            this.lbTransInfo.Text = "Transaction Information";
            this.lbTransInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitChildPanel
            // 
            this.btnExitChildPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitChildPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChildPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitChildPanel.ForeColor = System.Drawing.Color.Red;
            this.btnExitChildPanel.Location = new System.Drawing.Point(900, 1);
            this.btnExitChildPanel.Name = "btnExitChildPanel";
            this.btnExitChildPanel.Size = new System.Drawing.Size(30, 30);
            this.btnExitChildPanel.TabIndex = 1;
            this.btnExitChildPanel.Text = "X";
            this.btnExitChildPanel.UseVisualStyleBackColor = false;
            // 
            // pnlTransInfoContainer
            // 
            this.pnlTransInfoContainer.Controls.Add(this.tbTransInfoWraper);
            this.pnlTransInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransInfoContainer.Location = new System.Drawing.Point(0, 34);
            this.pnlTransInfoContainer.Name = "pnlTransInfoContainer";
            this.pnlTransInfoContainer.Size = new System.Drawing.Size(934, 574);
            this.pnlTransInfoContainer.TabIndex = 4;
            // 
            // tbTransInfoWraper
            // 
            this.tbTransInfoWraper.BackColor = System.Drawing.Color.GhostWhite;
            this.tbTransInfoWraper.ColumnCount = 2;
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98713F));
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01287F));
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoOne, 0, 0);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoTwo, 1, 0);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoThree, 0, 1);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoFour, 1, 1);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoFive, 0, 2);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoSix, 1, 2);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoSeven, 0, 3);
            this.tbTransInfoWraper.Controls.Add(this.tbBlockInfoEight, 1, 3);
            this.tbTransInfoWraper.Controls.Add(this.dgvDataItemList, 0, 4);
            this.tbTransInfoWraper.Controls.Add(this.dgvDataViolationHandle, 1, 4);
            this.tbTransInfoWraper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTransInfoWraper.Location = new System.Drawing.Point(0, 0);
            this.tbTransInfoWraper.Name = "tbTransInfoWraper";
            this.tbTransInfoWraper.RowCount = 5;
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTransInfoWraper.Size = new System.Drawing.Size(934, 574);
            this.tbTransInfoWraper.TabIndex = 0;
            // 
            // dgvDataViolationHandle
            // 
            this.dgvDataViolationHandle.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDataViolationHandle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataViolationHandle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleTitle,
            this.colPenaty,
            this.colViolationDate,
            this.colPaidStatus,
            this.colExcuseViolation});
            this.dgvDataViolationHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataViolationHandle.Location = new System.Drawing.Point(385, 279);
            this.dgvDataViolationHandle.Name = "dgvDataViolationHandle";
            this.dgvDataViolationHandle.Size = new System.Drawing.Size(546, 292);
            this.dgvDataViolationHandle.TabIndex = 11;
            // 
            // colExcuseViolation
            // 
            this.colExcuseViolation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExcuseViolation.HeaderText = "";
            this.colExcuseViolation.Name = "colExcuseViolation";
            this.colExcuseViolation.ReadOnly = true;
            this.colExcuseViolation.Width = 20;
            // 
            // colPaidStatus
            // 
            this.colPaidStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPaidStatus.HeaderText = "Paid Status";
            this.colPaidStatus.Name = "colPaidStatus";
            this.colPaidStatus.ReadOnly = true;
            this.colPaidStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaidStatus.Width = 101;
            // 
            // colViolationDate
            // 
            this.colViolationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colViolationDate.HeaderText = "Violation Date";
            this.colViolationDate.Name = "colViolationDate";
            this.colViolationDate.ReadOnly = true;
            this.colViolationDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colViolationDate.Width = 118;
            // 
            // colPenaty
            // 
            this.colPenaty.HeaderText = "Penaty";
            this.colPenaty.Name = "colPenaty";
            this.colPenaty.ReadOnly = true;
            this.colPenaty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colRuleTitle
            // 
            this.colRuleTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRuleTitle.HeaderText = "Rule";
            this.colRuleTitle.Name = "colRuleTitle";
            this.colRuleTitle.ReadOnly = true;
            this.colRuleTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvDataItemList
            // 
            this.dgvDataItemList.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDataItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemQuantity});
            this.dgvDataItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataItemList.Location = new System.Drawing.Point(3, 279);
            this.dgvDataItemList.Name = "dgvDataItemList";
            this.dgvDataItemList.Size = new System.Drawing.Size(376, 292);
            this.dgvDataItemList.TabIndex = 10;
            // 
            // colItemQuantity
            // 
            this.colItemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemQuantity.HeaderText = "Quantity";
            this.colItemQuantity.Name = "colItemQuantity";
            this.colItemQuantity.ReadOnly = true;
            this.colItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemQuantity.Width = 87;
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbBlockInfoEight
            // 
            this.tbBlockInfoEight.BackColor = System.Drawing.Color.GhostWhite;
            this.tbBlockInfoEight.ColumnCount = 2;
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoEight.Controls.Add(this.lbViolationStatus, 0, 0);
            this.tbBlockInfoEight.Controls.Add(this.lbViolationList, 0, 1);
            this.tbBlockInfoEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoEight.Location = new System.Drawing.Point(385, 210);
            this.tbBlockInfoEight.Name = "tbBlockInfoEight";
            this.tbBlockInfoEight.RowCount = 2;
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoEight.TabIndex = 7;
            // 
            // lbViolationList
            // 
            this.lbViolationList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolationList.AutoSize = true;
            this.lbViolationList.BackColor = System.Drawing.Color.Transparent;
            this.lbViolationList.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolationList.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbViolationList.Location = new System.Drawing.Point(3, 37);
            this.lbViolationList.Name = "lbViolationList";
            this.lbViolationList.Size = new System.Drawing.Size(101, 19);
            this.lbViolationList.TabIndex = 1;
            this.lbViolationList.Text = "Violation List :";
            this.lbViolationList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbViolationStatus
            // 
            this.lbViolationStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolationStatus.AutoSize = true;
            this.lbViolationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbViolationStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolationStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbViolationStatus.Location = new System.Drawing.Point(3, 6);
            this.lbViolationStatus.Name = "lbViolationStatus";
            this.lbViolationStatus.Size = new System.Drawing.Size(120, 19);
            this.lbViolationStatus.TabIndex = 0;
            this.lbViolationStatus.Text = "Violation Status :";
            this.lbViolationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoSeven
            // 
            this.tbBlockInfoSeven.ColumnCount = 2;
            this.tbBlockInfoSeven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35106F));
            this.tbBlockInfoSeven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64894F));
            this.tbBlockInfoSeven.Controls.Add(this.lbReturnDate, 0, 0);
            this.tbBlockInfoSeven.Controls.Add(this.lbListTransItems, 0, 1);
            this.tbBlockInfoSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoSeven.Location = new System.Drawing.Point(3, 210);
            this.tbBlockInfoSeven.Name = "tbBlockInfoSeven";
            this.tbBlockInfoSeven.RowCount = 2;
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoSeven.TabIndex = 6;
            // 
            // lbListTransItems
            // 
            this.lbListTransItems.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbListTransItems.AutoSize = true;
            this.lbListTransItems.BackColor = System.Drawing.Color.Transparent;
            this.lbListTransItems.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListTransItems.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbListTransItems.Location = new System.Drawing.Point(3, 37);
            this.lbListTransItems.Name = "lbListTransItems";
            this.lbListTransItems.Size = new System.Drawing.Size(155, 19);
            this.lbListTransItems.TabIndex = 1;
            this.lbListTransItems.Text = "Transaction Item List :";
            this.lbListTransItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lbReturnDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbReturnDate.Location = new System.Drawing.Point(3, 6);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(98, 19);
            this.lbReturnDate.TabIndex = 0;
            this.lbReturnDate.Text = "Return Date :";
            this.lbReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoSix
            // 
            this.tbBlockInfoSix.ColumnCount = 2;
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoSix.Controls.Add(this.lbUserEmail, 0, 0);
            this.tbBlockInfoSix.Controls.Add(this.lbUserPhoneNumber, 0, 1);
            this.tbBlockInfoSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoSix.Location = new System.Drawing.Point(385, 141);
            this.tbBlockInfoSix.Name = "tbBlockInfoSix";
            this.tbBlockInfoSix.RowCount = 2;
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoSix.TabIndex = 5;
            // 
            // lbUserPhoneNumber
            // 
            this.lbUserPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserPhoneNumber.AutoSize = true;
            this.lbUserPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbUserPhoneNumber.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserPhoneNumber.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserPhoneNumber.Location = new System.Drawing.Point(3, 37);
            this.lbUserPhoneNumber.Name = "lbUserPhoneNumber";
            this.lbUserPhoneNumber.Size = new System.Drawing.Size(116, 19);
            this.lbUserPhoneNumber.TabIndex = 1;
            this.lbUserPhoneNumber.Text = "Phone Number :";
            this.lbUserPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbUserEmail.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserEmail.Location = new System.Drawing.Point(3, 6);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(85, 19);
            this.lbUserEmail.TabIndex = 0;
            this.lbUserEmail.Text = "User Email :";
            this.lbUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoFive
            // 
            this.tbBlockInfoFive.ColumnCount = 2;
            this.tbBlockInfoFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08511F));
            this.tbBlockInfoFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91489F));
            this.tbBlockInfoFive.Controls.Add(this.lbTransDate, 0, 0);
            this.tbBlockInfoFive.Controls.Add(this.lbDueDate, 0, 1);
            this.tbBlockInfoFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoFive.Location = new System.Drawing.Point(3, 141);
            this.tbBlockInfoFive.Name = "tbBlockInfoFive";
            this.tbBlockInfoFive.RowCount = 2;
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoFive.TabIndex = 4;
            // 
            // lbDueDate
            // 
            this.lbDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDueDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDueDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbDueDate.Location = new System.Drawing.Point(3, 37);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(78, 19);
            this.lbDueDate.TabIndex = 1;
            this.lbDueDate.Text = "Due Date :";
            this.lbDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransDate
            // 
            this.lbTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransDate.AutoSize = true;
            this.lbTransDate.BackColor = System.Drawing.Color.Transparent;
            this.lbTransDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransDate.Location = new System.Drawing.Point(3, 6);
            this.lbTransDate.Name = "lbTransDate";
            this.lbTransDate.Size = new System.Drawing.Size(130, 19);
            this.lbTransDate.TabIndex = 0;
            this.lbTransDate.Text = "Transaction Date :";
            this.lbTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoFour
            // 
            this.tbBlockInfoFour.ColumnCount = 2;
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoFour.Controls.Add(this.lbUserType, 0, 0);
            this.tbBlockInfoFour.Controls.Add(this.lbUserStatus, 0, 1);
            this.tbBlockInfoFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoFour.Location = new System.Drawing.Point(385, 72);
            this.tbBlockInfoFour.Name = "tbBlockInfoFour";
            this.tbBlockInfoFour.RowCount = 2;
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoFour.TabIndex = 3;
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbUserStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserStatus.Location = new System.Drawing.Point(3, 37);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(91, 19);
            this.lbUserStatus.TabIndex = 2;
            this.lbUserStatus.Text = "User Status :";
            this.lbUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserType
            // 
            this.lbUserType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserType.AutoSize = true;
            this.lbUserType.BackColor = System.Drawing.Color.Transparent;
            this.lbUserType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserType.Location = new System.Drawing.Point(3, 6);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(80, 19);
            this.lbUserType.TabIndex = 1;
            this.lbUserType.Text = "User Type :";
            this.lbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoThree
            // 
            this.tbBlockInfoThree.ColumnCount = 2;
            this.tbBlockInfoThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08511F));
            this.tbBlockInfoThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91489F));
            this.tbBlockInfoThree.Controls.Add(this.lbTransStatus, 0, 1);
            this.tbBlockInfoThree.Controls.Add(this.lbTransType, 0, 0);
            this.tbBlockInfoThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoThree.Location = new System.Drawing.Point(3, 72);
            this.tbBlockInfoThree.Name = "tbBlockInfoThree";
            this.tbBlockInfoThree.RowCount = 2;
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoThree.TabIndex = 2;
            // 
            // lbTransType
            // 
            this.lbTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransType.AutoSize = true;
            this.lbTransType.BackColor = System.Drawing.Color.Transparent;
            this.lbTransType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransType.Location = new System.Drawing.Point(3, 6);
            this.lbTransType.Name = "lbTransType";
            this.lbTransType.Size = new System.Drawing.Size(129, 19);
            this.lbTransType.TabIndex = 0;
            this.lbTransType.Text = "Transaction Type :";
            this.lbTransType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransStatus
            // 
            this.lbTransStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransStatus.AutoSize = true;
            this.lbTransStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbTransStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransStatus.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransStatus.Location = new System.Drawing.Point(3, 37);
            this.lbTransStatus.Name = "lbTransStatus";
            this.lbTransStatus.Size = new System.Drawing.Size(140, 19);
            this.lbTransStatus.TabIndex = 0;
            this.lbTransStatus.Text = "Transaction Status :";
            this.lbTransStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoTwo
            // 
            this.tbBlockInfoTwo.ColumnCount = 2;
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoTwo.Controls.Add(this.lbMemFullName, 0, 0);
            this.tbBlockInfoTwo.Controls.Add(this.lbUserName, 0, 1);
            this.tbBlockInfoTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoTwo.Location = new System.Drawing.Point(385, 3);
            this.tbBlockInfoTwo.Name = "tbBlockInfoTwo";
            this.tbBlockInfoTwo.RowCount = 2;
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.Size = new System.Drawing.Size(546, 63);
            this.tbBlockInfoTwo.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserName.Location = new System.Drawing.Point(3, 37);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 19);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Member User Name :";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMemFullName
            // 
            this.lbMemFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemFullName.AutoSize = true;
            this.lbMemFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbMemFullName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemFullName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbMemFullName.Location = new System.Drawing.Point(3, 6);
            this.lbMemFullName.Name = "lbMemFullName";
            this.lbMemFullName.Size = new System.Drawing.Size(141, 19);
            this.lbMemFullName.TabIndex = 0;
            this.lbMemFullName.Text = "Member Full Name :";
            this.lbMemFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockInfoOne
            // 
            this.tbBlockInfoOne.ColumnCount = 2;
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35106F));
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64894F));
            this.tbBlockInfoOne.Controls.Add(this.lbTransID, 0, 0);
            this.tbBlockInfoOne.Controls.Add(this.lbMemID, 0, 1);
            this.tbBlockInfoOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoOne.Location = new System.Drawing.Point(3, 3);
            this.tbBlockInfoOne.Name = "tbBlockInfoOne";
            this.tbBlockInfoOne.RowCount = 2;
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.Size = new System.Drawing.Size(376, 63);
            this.tbBlockInfoOne.TabIndex = 0;
            // 
            // lbMemID
            // 
            this.lbMemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemID.AutoSize = true;
            this.lbMemID.BackColor = System.Drawing.Color.Transparent;
            this.lbMemID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbMemID.Location = new System.Drawing.Point(3, 37);
            this.lbMemID.Name = "lbMemID";
            this.lbMemID.Size = new System.Drawing.Size(88, 19);
            this.lbMemID.TabIndex = 1;
            this.lbMemID.Text = "Member ID :";
            this.lbMemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTransID
            // 
            this.lbTransID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransID.AutoSize = true;
            this.lbTransID.BackColor = System.Drawing.Color.Transparent;
            this.lbTransID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTransID.Location = new System.Drawing.Point(3, 6);
            this.lbTransID.Name = "lbTransID";
            this.lbTransID.Size = new System.Drawing.Size(115, 19);
            this.lbTransID.TabIndex = 0;
            this.lbTransID.Text = "Transaction ID : ";
            this.lbTransID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChildDetailInfo
            // 
            this.pnlChildDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChildDetailInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChildDetailInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChildDetailInfo.Controls.Add(this.pnlTransInfoContainer);
            this.pnlChildDetailInfo.Controls.Add(this.pnlHeaderTransInfoDetail);
            this.pnlChildDetailInfo.Location = new System.Drawing.Point(1, 0);
            this.pnlChildDetailInfo.Name = "pnlChildDetailInfo";
            this.pnlChildDetailInfo.Size = new System.Drawing.Size(936, 610);
            this.pnlChildDetailInfo.TabIndex = 11;
            this.pnlChildDetailInfo.Visible = false;

            // 

            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlContainer);
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
            this.pnlResultMessageBox.ResumeLayout(false);
            this.pnlResultMessageBox.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlChildDetailInfo.ResumeLayout(false);
            this.pnlTransInfoContainer.ResumeLayout(false);
            this.tbTransInfoWraper.ResumeLayout(false);
            this.tbBlockInfoOne.ResumeLayout(false);
            this.tbBlockInfoOne.PerformLayout();
            this.tbBlockInfoTwo.ResumeLayout(false);
            this.tbBlockInfoTwo.PerformLayout();
            this.tbBlockInfoThree.ResumeLayout(false);
            this.tbBlockInfoThree.PerformLayout();
            this.tbBlockInfoFour.ResumeLayout(false);
            this.tbBlockInfoFour.PerformLayout();
            this.tbBlockInfoFive.ResumeLayout(false);
            this.tbBlockInfoFive.PerformLayout();
            this.tbBlockInfoSix.ResumeLayout(false);
            this.tbBlockInfoSix.PerformLayout();
            this.tbBlockInfoSeven.ResumeLayout(false);
            this.tbBlockInfoSeven.PerformLayout();
            this.tbBlockInfoEight.ResumeLayout(false);
            this.tbBlockInfoEight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViolationHandle)).EndInit();
            this.pnlHeaderTransInfoDetail.ResumeLayout(false);
            this.pnlHeaderTransInfoDetail.PerformLayout();
            this.pnlHeaderGetBorrowInfo.ResumeLayout(false);
            this.pnlHeaderGetBorrowInfo.PerformLayout();
            this.pnlBorrowBookBody.ResumeLayout(false);
            this.tbGetBorrowInfo.ResumeLayout(false);
            this.tbGetBorrowInfo.PerformLayout();
            this.pnlBorrowBookFooter.ResumeLayout(false);
            this.tbBorrowBookButtons.ResumeLayout(false);
            this.pnlFormBorrowBook.ResumeLayout(false);
            this.pnlHeaderGetReturnInfo.ResumeLayout(false);
            this.pnlHeaderGetReturnInfo.PerformLayout();
            this.pnlReturnBookFooter.ResumeLayout(false);
            this.tbReturnBookButtons.ResumeLayout(false);
            this.pnlReturnBookBody.ResumeLayout(false);
            this.tbGetReturnInfo.ResumeLayout(false);
            this.tbGetReturnInfo.PerformLayout();
            this.pnlFormReturnBook.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colMoreOptions;
        private System.Windows.Forms.Panel pnlResultMessageBox;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlChildDetailInfo;
        private System.Windows.Forms.Panel pnlTransInfoContainer;
        private System.Windows.Forms.TableLayoutPanel tbTransInfoWraper;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoOne;
        private System.Windows.Forms.Label lbTransID;
        private System.Windows.Forms.Label lbMemID;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoTwo;
        private System.Windows.Forms.Label lbMemFullName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoThree;
        private System.Windows.Forms.Label lbTransStatus;
        private System.Windows.Forms.Label lbTransType;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoFour;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbUserStatus;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoFive;
        private System.Windows.Forms.Label lbTransDate;
        private System.Windows.Forms.Label lbDueDate;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoSix;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.Label lbUserPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoSeven;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label lbListTransItems;
        private System.Windows.Forms.TableLayoutPanel tbBlockInfoEight;
        private System.Windows.Forms.Label lbViolationStatus;
        private System.Windows.Forms.Label lbViolationList;
        private System.Windows.Forms.DataGridView dgvDataItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridView dgvDataViolationHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViolationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExcuseViolation;
        private System.Windows.Forms.Panel pnlHeaderTransInfoDetail;
        private System.Windows.Forms.Button btnExitChildPanel;
        private System.Windows.Forms.Label lbTransInfo;
        private System.Windows.Forms.Panel pnlFormReturnBook;
        private System.Windows.Forms.Panel pnlReturnBookBody;
        private System.Windows.Forms.TableLayoutPanel tbGetReturnInfo;
        private System.Windows.Forms.Label lbGetReturnMemberID;
        private System.Windows.Forms.Label lbReturnTransType;
        private System.Windows.Forms.Label lbGetRealReturnDate;
        private System.Windows.Forms.Label lbGetReturnPenaty;
        private System.Windows.Forms.Label lbGetReturnItem;
        private System.Windows.Forms.TextBox txtGetMemberIDReturn;
        private System.Windows.Forms.TextBox txtGetTransTypeReturn;
        private System.Windows.Forms.RichTextBox rtxtReturnPenalty;
        private System.Windows.Forms.RichTextBox rtxtReturnListItem;
        private System.Windows.Forms.DateTimePicker dtpRealReturnDate;
        private System.Windows.Forms.Panel pnlReturnBookFooter;
        private System.Windows.Forms.TableLayoutPanel tbReturnBookButtons;
        private System.Windows.Forms.Button btnCancelFormReturn;
        private System.Windows.Forms.Button btnResetFromReturn;
        private System.Windows.Forms.Button btnSubmitFormReturn;
        private System.Windows.Forms.Panel pnlHeaderGetReturnInfo;
        private System.Windows.Forms.Button btnExitFormReturnBook;
        private System.Windows.Forms.Label lbFormReturnBook;
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