namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    partial class FormInformation
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
            this.SuspendLayout();
            // 
            // pnlChildDetailInfo
            // 
            this.pnlChildDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChildDetailInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlChildDetailInfo.Controls.Add(this.pnlTransInfoContainer);
            this.pnlChildDetailInfo.Controls.Add(this.pnlHeaderTransInfoDetail);
            this.pnlChildDetailInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlChildDetailInfo.Name = "pnlChildDetailInfo";
            this.pnlChildDetailInfo.Size = new System.Drawing.Size(936, 610);
            this.pnlChildDetailInfo.TabIndex = 12;
            // 
            // pnlTransInfoContainer
            // 
            this.pnlTransInfoContainer.Controls.Add(this.tbTransInfoWraper);
            this.pnlTransInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransInfoContainer.Location = new System.Drawing.Point(0, 34);
            this.pnlTransInfoContainer.Name = "pnlTransInfoContainer";
            this.pnlTransInfoContainer.Size = new System.Drawing.Size(936, 576);
            this.pnlTransInfoContainer.TabIndex = 4;
            // 
            // tbTransInfoWraper
            // 
            this.tbTransInfoWraper.BackColor = System.Drawing.Color.Transparent;
            this.tbTransInfoWraper.ColumnCount = 2;
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98713F));
            this.tbTransInfoWraper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01287F));
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
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tbTransInfoWraper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTransInfoWraper.Size = new System.Drawing.Size(936, 576);
            this.tbTransInfoWraper.TabIndex = 0;
            // 
            // tbBlockInfoOne
            // 
            this.tbBlockInfoOne.ColumnCount = 2;
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35106F));
            this.tbBlockInfoOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64894F));
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
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoOne.Size = new System.Drawing.Size(377, 63);
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
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoTwo.Controls.Add(this.lbMemFullName, 0, 0);
            this.tbBlockInfoTwo.Controls.Add(this.lbUserName, 0, 1);
            this.tbBlockInfoTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoTwo.Location = new System.Drawing.Point(386, 3);
            this.tbBlockInfoTwo.Name = "tbBlockInfoTwo";
            this.tbBlockInfoTwo.RowCount = 2;
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoTwo.Size = new System.Drawing.Size(547, 63);
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
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoThree.Size = new System.Drawing.Size(377, 63);
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
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoFour.Controls.Add(this.lbUserType, 0, 0);
            this.tbBlockInfoFour.Controls.Add(this.lbUserStatus, 0, 1);
            this.tbBlockInfoFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoFour.Location = new System.Drawing.Point(386, 72);
            this.tbBlockInfoFour.Name = "tbBlockInfoFour";
            this.tbBlockInfoFour.RowCount = 2;
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFour.Size = new System.Drawing.Size(547, 63);
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
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoFive.Size = new System.Drawing.Size(377, 63);
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
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoSix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoSix.Controls.Add(this.lbUserEmail, 0, 0);
            this.tbBlockInfoSix.Controls.Add(this.lbUserPhoneNumber, 0, 1);
            this.tbBlockInfoSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoSix.Location = new System.Drawing.Point(386, 141);
            this.tbBlockInfoSix.Name = "tbBlockInfoSix";
            this.tbBlockInfoSix.RowCount = 2;
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSix.Size = new System.Drawing.Size(547, 63);
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
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoSeven.Size = new System.Drawing.Size(377, 63);
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
            this.tbBlockInfoEight.BackColor = System.Drawing.Color.Transparent;
            this.tbBlockInfoEight.ColumnCount = 2;
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbBlockInfoEight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbBlockInfoEight.Controls.Add(this.lbViolationStatus, 0, 0);
            this.tbBlockInfoEight.Controls.Add(this.lbViolationList, 0, 1);
            this.tbBlockInfoEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBlockInfoEight.Location = new System.Drawing.Point(386, 210);
            this.tbBlockInfoEight.Name = "tbBlockInfoEight";
            this.tbBlockInfoEight.RowCount = 2;
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBlockInfoEight.Size = new System.Drawing.Size(547, 63);
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
            this.dgvDataItemList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDataItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemQuantity});
            this.dgvDataItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataItemList.Location = new System.Drawing.Point(3, 279);
            this.dgvDataItemList.Name = "dgvDataItemList";
            this.dgvDataItemList.Size = new System.Drawing.Size(377, 294);
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
            this.colItemQuantity.Width = 71;
            // 
            // dgvDataViolationHandle
            // 
            this.dgvDataViolationHandle.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDataViolationHandle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataViolationHandle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRuleTitle,
            this.colPenaty,
            this.colViolationDate,
            this.colPaidStatus,
            this.colExcuseViolation});
            this.dgvDataViolationHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataViolationHandle.Location = new System.Drawing.Point(386, 279);
            this.dgvDataViolationHandle.Name = "dgvDataViolationHandle";
            this.dgvDataViolationHandle.Size = new System.Drawing.Size(547, 294);
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
            this.colViolationDate.Width = 98;
            // 
            // colPaidStatus
            // 
            this.colPaidStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPaidStatus.HeaderText = "Paid Status";
            this.colPaidStatus.Name = "colPaidStatus";
            this.colPaidStatus.ReadOnly = true;
            this.colPaidStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaidStatus.Width = 86;
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
            this.pnlHeaderTransInfoDetail.BackColor = System.Drawing.Color.Azure;
            this.pnlHeaderTransInfoDetail.Controls.Add(this.btnExitChildPanel);
            this.pnlHeaderTransInfoDetail.Controls.Add(this.lbTransInfo);
            this.pnlHeaderTransInfoDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTransInfoDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTransInfoDetail.Name = "pnlHeaderTransInfoDetail";
            this.pnlHeaderTransInfoDetail.Size = new System.Drawing.Size(936, 34);
            this.pnlHeaderTransInfoDetail.TabIndex = 1;
            // 
            // btnExitChildPanel
            // 
            this.btnExitChildPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitChildPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChildPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitChildPanel.ForeColor = System.Drawing.Color.Red;
            this.btnExitChildPanel.Location = new System.Drawing.Point(901, 1);
            this.btnExitChildPanel.Name = "btnExitChildPanel";
            this.btnExitChildPanel.Size = new System.Drawing.Size(30, 30);
            this.btnExitChildPanel.TabIndex = 1;
            this.btnExitChildPanel.Text = "X";
            this.btnExitChildPanel.UseVisualStyleBackColor = false;
            this.btnExitChildPanel.Click += new System.EventHandler(this.btnExitChildPanel_Click);
            // 
            // lbTransInfo
            // 
            this.lbTransInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTransInfo.AutoSize = true;
            this.lbTransInfo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbTransInfo.Location = new System.Drawing.Point(383, 3);
            this.lbTransInfo.Name = "lbTransInfo";
            this.lbTransInfo.Size = new System.Drawing.Size(208, 23);
            this.lbTransInfo.TabIndex = 0;
            this.lbTransInfo.Text = "Transaction Information";
            this.lbTransInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnlChildDetailInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}