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
            this.dataTransactions = new System.Windows.Forms.DataGridView();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlHeaderTransInfoDetail = new System.Windows.Forms.Panel();
            this.btnChildPanelExit = new System.Windows.Forms.Button();
            this.lbTransInfo = new System.Windows.Forms.Label();
            this.pnlResultMessageBox = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.colRuleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenaty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViolationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcuseViolation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.tbBody.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlHeaderTransInfoDetail.SuspendLayout();
            this.pnlResultMessageBox.SuspendLayout();
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
            // dataTransactions
            // 
            this.dataTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataTransactions.BackgroundColor = System.Drawing.Color.Black;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colMemberID,
            this.colTransactionType,
            this.colTransactionDate,
            this.colDueDate,
            this.colReturnDate,
            this.colStatus,
            this.colMoreOptions});
            this.dataTransactions.Location = new System.Drawing.Point(3, 72);
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.Size = new System.Drawing.Size(954, 409);
            this.dataTransactions.TabIndex = 1;
            this.dataTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTransactions_CellContentClick);
            // 
            // colTransactionID
            // 
            this.colTransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionID.Frozen = true;
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.ReadOnly = true;
            this.colTransactionID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTransactionID.Width = 117;
            // 
            // colMemberID
            // 
            this.colMemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMemberID.Frozen = true;
            this.colMemberID.HeaderText = "MemberID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMemberID.Width = 98;
            // 
            // colTransactionType
            // 
            this.colTransactionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransactionType.HeaderText = "Transaction Type";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            this.colTransactionType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.ReadOnly = true;
            this.colTransactionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDueDate
            // 
            this.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            this.colDueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colReturnDate
            // 
            this.colReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReturnDate.FillWeight = 130F;
            this.colReturnDate.HeaderText = "Return Date";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReturnDate.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colStatus.Width = 72;
            // 
            // colMoreOptions
            // 
            this.colMoreOptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMoreOptions.HeaderText = "";
            this.colMoreOptions.Name = "colMoreOptions";
            this.colMoreOptions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMoreOptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMoreOptions.Text = "More";
            this.colMoreOptions.Width = 25;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(954, 48);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(397, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Transactions List";
            // 
            // tbBody
            // 
            this.tbBody.AutoSize = true;
            this.tbBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbBody.BackColor = System.Drawing.Color.Black;
            this.tbBody.ColumnCount = 1;
            this.tbBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBody.Controls.Add(this.pnlHeader, 0, 0);
            this.tbBody.Controls.Add(this.dataTransactions, 0, 1);
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
            // pnlChildDetailInfo
            // 
            this.pnlChildDetailInfo.BackColor = System.Drawing.Color.Black;
            this.pnlChildDetailInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChildDetailInfo.Controls.Add(this.pnlTransInfoContainer);
            this.pnlChildDetailInfo.Controls.Add(this.pnlHeaderTransInfoDetail);
            this.pnlChildDetailInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlChildDetailInfo.Name = "pnlChildDetailInfo";
            this.pnlChildDetailInfo.Size = new System.Drawing.Size(936, 626);
            this.pnlChildDetailInfo.TabIndex = 10;
            this.pnlChildDetailInfo.Visible = false;
            // 
            // pnlTransInfoContainer
            // 
            this.pnlTransInfoContainer.Controls.Add(this.tbTransInfoWraper);
            this.pnlTransInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransInfoContainer.Location = new System.Drawing.Point(0, 34);
            this.pnlTransInfoContainer.Name = "pnlTransInfoContainer";
            this.pnlTransInfoContainer.Size = new System.Drawing.Size(932, 588);
            this.pnlTransInfoContainer.TabIndex = 4;
            // 
            // tbTransInfoWraper
            // 
            this.tbTransInfoWraper.BackColor = System.Drawing.Color.DimGray;
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
            this.tbTransInfoWraper.Controls.Add(this.dataGridView1, 0, 4);
            this.tbTransInfoWraper.Controls.Add(this.dataGridView2, 1, 4);
            this.tbTransInfoWraper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTransInfoWraper.Location = new System.Drawing.Point(0, 0);
            this.tbTransInfoWraper.Name = "tbTransInfoWraper";
            this.tbTransInfoWraper.RowCount = 5;
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tbTransInfoWraper.Size = new System.Drawing.Size(932, 588);
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
            this.tbBlockInfoOne.Size = new System.Drawing.Size(376, 66);
            this.tbBlockInfoOne.TabIndex = 0;
            // 
            // lbTransID
            // 
            this.lbTransID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransID.AutoSize = true;
            this.lbTransID.BackColor = System.Drawing.Color.Transparent;
            this.lbTransID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransID.ForeColor = System.Drawing.Color.Azure;
            this.lbTransID.Location = new System.Drawing.Point(3, 7);
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
            this.lbMemID.ForeColor = System.Drawing.Color.Azure;
            this.lbMemID.Location = new System.Drawing.Point(3, 40);
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
            this.tbBlockInfoTwo.Size = new System.Drawing.Size(544, 66);
            this.tbBlockInfoTwo.TabIndex = 1;
            // 
            // lbMemFullName
            // 
            this.lbMemFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMemFullName.AutoSize = true;
            this.lbMemFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbMemFullName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemFullName.ForeColor = System.Drawing.Color.Azure;
            this.lbMemFullName.Location = new System.Drawing.Point(3, 7);
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
            this.lbUserName.ForeColor = System.Drawing.Color.Azure;
            this.lbUserName.Location = new System.Drawing.Point(3, 40);
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
            this.tbBlockInfoThree.Location = new System.Drawing.Point(3, 75);
            this.tbBlockInfoThree.Name = "tbBlockInfoThree";
            this.tbBlockInfoThree.RowCount = 2;
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.Size = new System.Drawing.Size(376, 66);
            this.tbBlockInfoThree.TabIndex = 2;
            // 
            // lbTransStatus
            // 
            this.lbTransStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransStatus.AutoSize = true;
            this.lbTransStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbTransStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransStatus.ForeColor = System.Drawing.Color.Azure;
            this.lbTransStatus.Location = new System.Drawing.Point(3, 40);
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
            this.lbTransType.ForeColor = System.Drawing.Color.Azure;
            this.lbTransType.Location = new System.Drawing.Point(3, 7);
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
            this.tbBlockInfoFour.Location = new System.Drawing.Point(385, 75);
            this.tbBlockInfoFour.Name = "tbBlockInfoFour";
            this.tbBlockInfoFour.RowCount = 2;
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.Size = new System.Drawing.Size(544, 66);
            this.tbBlockInfoFour.TabIndex = 3;
            // 
            // lbUserType
            // 
            this.lbUserType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserType.AutoSize = true;
            this.lbUserType.BackColor = System.Drawing.Color.Transparent;
            this.lbUserType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.Azure;
            this.lbUserType.Location = new System.Drawing.Point(3, 7);
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
            this.lbUserStatus.ForeColor = System.Drawing.Color.Azure;
            this.lbUserStatus.Location = new System.Drawing.Point(3, 40);
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
            this.tbBlockInfoFive.Location = new System.Drawing.Point(3, 147);
            this.tbBlockInfoFive.Name = "tbBlockInfoFive";
            this.tbBlockInfoFive.RowCount = 2;
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.Size = new System.Drawing.Size(376, 66);
            this.tbBlockInfoFive.TabIndex = 4;
            // 
            // lbTransDate
            // 
            this.lbTransDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTransDate.AutoSize = true;
            this.lbTransDate.BackColor = System.Drawing.Color.Transparent;
            this.lbTransDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransDate.ForeColor = System.Drawing.Color.Azure;
            this.lbTransDate.Location = new System.Drawing.Point(3, 7);
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
            this.lbDueDate.ForeColor = System.Drawing.Color.Azure;
            this.lbDueDate.Location = new System.Drawing.Point(3, 40);
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
            this.tbBlockInfoSix.Location = new System.Drawing.Point(385, 147);
            this.tbBlockInfoSix.Name = "tbBlockInfoSix";
            this.tbBlockInfoSix.RowCount = 2;
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.Size = new System.Drawing.Size(544, 66);
            this.tbBlockInfoSix.TabIndex = 5;
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbUserEmail.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserEmail.ForeColor = System.Drawing.Color.Azure;
            this.lbUserEmail.Location = new System.Drawing.Point(3, 7);
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
            this.lbUserPhoneNumber.ForeColor = System.Drawing.Color.Azure;
            this.lbUserPhoneNumber.Location = new System.Drawing.Point(3, 40);
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
            this.tbBlockInfoSeven.Location = new System.Drawing.Point(3, 219);
            this.tbBlockInfoSeven.Name = "tbBlockInfoSeven";
            this.tbBlockInfoSeven.RowCount = 2;
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.Size = new System.Drawing.Size(376, 66);
            this.tbBlockInfoSeven.TabIndex = 6;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.lbReturnDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.ForeColor = System.Drawing.Color.Azure;
            this.lbReturnDate.Location = new System.Drawing.Point(3, 7);
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
            this.lbListTransItems.ForeColor = System.Drawing.Color.Azure;
            this.lbListTransItems.Location = new System.Drawing.Point(3, 40);
            this.lbListTransItems.Name = "lbListTransItems";
            this.lbListTransItems.Size = new System.Drawing.Size(155, 19);
            this.lbListTransItems.TabIndex = 1;
            this.lbListTransItems.Text = "Transaction Item List :";
            this.lbListTransItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbListTransItems.Click += new System.EventHandler(this.lbListTransItems_Click);
            // 
            // tbBlockInfoEight
            // 
            this.tbBlockInfoEight.ColumnCount = 2;
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoEight.Controls.Add(this.lbViolationStatus, 0, 0);
            this.tbBlockInfoEight.Controls.Add(this.lbViolationList, 0, 1);
            this.tbBlockInfoEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoEight.Location = new System.Drawing.Point(385, 219);
            this.tbBlockInfoEight.Name = "tbBlockInfoEight";
            this.tbBlockInfoEight.RowCount = 2;
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.Size = new System.Drawing.Size(544, 66);
            this.tbBlockInfoEight.TabIndex = 7;
            // 
            // lbViolationStatus
            // 
            this.lbViolationStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbViolationStatus.AutoSize = true;
            this.lbViolationStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbViolationStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolationStatus.ForeColor = System.Drawing.Color.Azure;
            this.lbViolationStatus.Location = new System.Drawing.Point(3, 7);
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
            this.lbViolationList.ForeColor = System.Drawing.Color.Azure;
            this.lbViolationList.Location = new System.Drawing.Point(3, 40);
            this.lbViolationList.Name = "lbViolationList";
            this.lbViolationList.Size = new System.Drawing.Size(101, 19);
            this.lbViolationList.TabIndex = 1;
            this.lbViolationList.Text = "Violation List :";
            this.lbViolationList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemQuantity});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 294);
            this.dataGridView1.TabIndex = 10;
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
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleTitle,
            this.colPenaty,
            this.colViolationDate,
            this.colPaidStatus,
            this.colExcuseViolation});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(385, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 294);
            this.dataGridView2.TabIndex = 11;
            // 
            // pnlHeaderTransInfoDetail
            // 
            this.pnlHeaderTransInfoDetail.Controls.Add(this.btnChildPanelExit);
            this.pnlHeaderTransInfoDetail.Controls.Add(this.lbTransInfo);
            this.pnlHeaderTransInfoDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTransInfoDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTransInfoDetail.Name = "pnlHeaderTransInfoDetail";
            this.pnlHeaderTransInfoDetail.Size = new System.Drawing.Size(932, 34);
            this.pnlHeaderTransInfoDetail.TabIndex = 1;
            // 
            // btnChildPanelExit
            // 
            this.btnChildPanelExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChildPanelExit.BackColor = System.Drawing.Color.Transparent;
            this.btnChildPanelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildPanelExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnChildPanelExit.Location = new System.Drawing.Point(899, 1);
            this.btnChildPanelExit.Name = "btnChildPanelExit";
            this.btnChildPanelExit.Size = new System.Drawing.Size(30, 30);
            this.btnChildPanelExit.TabIndex = 1;
            this.btnChildPanelExit.Text = "X";
            this.btnChildPanelExit.UseVisualStyleBackColor = false;
            this.btnChildPanelExit.Click += new System.EventHandler(this.btnChildPanelExit_Click);
            // 
            // lbTransInfo
            // 
            this.lbTransInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTransInfo.AutoSize = true;
            this.lbTransInfo.Location = new System.Drawing.Point(410, 7);
            this.lbTransInfo.Name = "lbTransInfo";
            this.lbTransInfo.Size = new System.Drawing.Size(154, 19);
            this.lbTransInfo.TabIndex = 0;
            this.lbTransInfo.Text = "Transaction Information";
            this.lbTransInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtResult.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.pnlChildDetailInfo);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbHeaderButtons);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormTransaction";
            this.Text = "cccccffffddeeeeewwwwwhhhhhhhhbbbnnmmmmmmvbvvvvvvv                   ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTransaction_FormClosing);
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.tbHeaderButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tbBody.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlHeaderTransInfoDetail.ResumeLayout(false);
            this.pnlHeaderTransInfoDetail.PerformLayout();
            this.pnlResultMessageBox.ResumeLayout(false);
            this.pnlResultMessageBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.TableLayoutPanel tbHeaderButtons;
        private System.Windows.Forms.DataGridView dataTransactions;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemQuantity;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel pnlHeaderTransInfoDetail;
        private System.Windows.Forms.Button btnChildPanelExit;
        private System.Windows.Forms.Label lbTransInfo;
        private System.Windows.Forms.Panel pnlResultMessageBox;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRuleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViolationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExcuseViolation;
    }
}