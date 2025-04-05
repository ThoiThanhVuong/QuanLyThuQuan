using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    partial class FormMain
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
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
            Color color1 = ColorTranslator.FromHtml("#320643");
            Color color2 = ColorTranslator.FromHtml("#140534");

            using (LinearGradientBrush brush = new LinearGradientBrush(
                SideBar.ClientRectangle,
                color1, color2,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, SideBar.ClientRectangle);
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnCloseProgram = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.ProductContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.ProductTransition = new System.Windows.Forms.Timer(this.components);
            this.SideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.TopMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnViolation = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.TableLayoutPanel();
            this.BottomMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.ProductContainer.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.BottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleBar.Controls.Add(this.flowLayoutPanel1);
            this.TitleBar.Controls.Add(this.btnSlide);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1200, 50);
            this.TitleBar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnMaximize);
            this.flowLayoutPanel1.Controls.Add(this.btnCloseProgram);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1096, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(91, 27);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(32, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCloseProgram
            // 
            this.btnCloseProgram.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseProgram.Image")));
            this.btnCloseProgram.Location = new System.Drawing.Point(64, 0);
            this.btnCloseProgram.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCloseProgram.Name = "btnCloseProgram";
            this.btnCloseProgram.Size = new System.Drawing.Size(25, 25);
            this.btnCloseProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseProgram.TabIndex = 11;
            this.btnCloseProgram.TabStop = false;
            this.btnCloseProgram.Click += new System.EventHandler(this.btnCloseProgram_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(7, 7);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click_1);
            // 
            // ProductContainer
            // 
            this.ProductContainer.BackColor = System.Drawing.Color.Transparent;
            this.ProductContainer.Controls.Add(this.btnProduct);
            this.ProductContainer.Controls.Add(this.btnBook);
            this.ProductContainer.Controls.Add(this.btnDevice);
            this.ProductContainer.Location = new System.Drawing.Point(0, 50);
            this.ProductContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Size = new System.Drawing.Size(240, 50);
            this.ProductContainer.TabIndex = 6;
            this.ProductContainer.TabStop = true;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(240, 50);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "     Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 50);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(240, 50);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "     Books";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevice.FlatAppearance.BorderSize = 0;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.Image")));
            this.btnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.Location = new System.Drawing.Point(0, 100);
            this.btnDevice.Margin = new System.Windows.Forms.Padding(0);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnDevice.Size = new System.Drawing.Size(240, 50);
            this.btnDevice.TabIndex = 5;
            this.btnDevice.Text = "     Devices";
            this.btnDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevice.UseVisualStyleBackColor = false;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // ProductTransition
            // 
            this.ProductTransition.Interval = 10;
            this.ProductTransition.Tick += new System.EventHandler(this.ProductTransition_Tick);
            // 
            // SideBarTransition
            // 
            this.SideBarTransition.Interval = 20;
            this.SideBarTransition.Tick += new System.EventHandler(this.SideBarTransition_Tick);
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.Transparent;
            this.TopMenu.Controls.Add(this.btnDashBoard);
            this.TopMenu.Controls.Add(this.ProductContainer);
            this.TopMenu.Controls.Add(this.btnRule);
            this.TopMenu.Controls.Add(this.btnTransaction);
            this.TopMenu.Controls.Add(this.btnViolation);
            this.TopMenu.Controls.Add(this.btnReview);
            this.TopMenu.Controls.Add(this.btnStatistic);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Margin = new System.Windows.Forms.Padding(0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(240, 540);
            this.TopMenu.TabIndex = 8;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashBoard.Size = new System.Drawing.Size(240, 50);
            this.btnDashBoard.TabIndex = 6;
            this.btnDashBoard.Text = "     DashBoard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnRule
            // 
            this.btnRule.BackColor = System.Drawing.Color.Transparent;
            this.btnRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRule.FlatAppearance.BorderSize = 0;
            this.btnRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRule.Image = ((System.Drawing.Image)(resources.GetObject("btnRule.Image")));
            this.btnRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRule.Location = new System.Drawing.Point(0, 100);
            this.btnRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnRule.Name = "btnRule";
            this.btnRule.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRule.Size = new System.Drawing.Size(240, 50);
            this.btnRule.TabIndex = 6;
            this.btnRule.Text = "     Rules";
            this.btnRule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRule.UseVisualStyleBackColor = false;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 150);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(240, 50);
            this.btnTransaction.TabIndex = 7;
            this.btnTransaction.Text = "    Transactions";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnViolation
            // 
            this.btnViolation.BackColor = System.Drawing.Color.Transparent;
            this.btnViolation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViolation.FlatAppearance.BorderSize = 0;
            this.btnViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViolation.Image = ((System.Drawing.Image)(resources.GetObject("btnViolation.Image")));
            this.btnViolation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolation.Location = new System.Drawing.Point(0, 200);
            this.btnViolation.Margin = new System.Windows.Forms.Padding(0);
            this.btnViolation.Name = "btnViolation";
            this.btnViolation.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnViolation.Size = new System.Drawing.Size(240, 50);
            this.btnViolation.TabIndex = 9;
            this.btnViolation.Text = "     Violation";
            this.btnViolation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViolation.UseVisualStyleBackColor = false;
            this.btnViolation.Click += new System.EventHandler(this.btnViolation_Click);
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.Transparent;
            this.btnReview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(0, 250);
            this.btnReview.Margin = new System.Windows.Forms.Padding(0);
            this.btnReview.Name = "btnReview";
            this.btnReview.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReview.Size = new System.Drawing.Size(240, 50);
            this.btnReview.TabIndex = 10;
            this.btnReview.Text = "     Reviews";
            this.btnReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistic.Image")));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(0, 300);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(240, 50);
            this.btnStatistic.TabIndex = 10;
            this.btnStatistic.Text = "    Statistics";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 50);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "     Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SideBar
            // 
            this.SideBar.AutoScroll = true;
            this.SideBar.BackColor = System.Drawing.Color.Black;
            this.SideBar.ColumnCount = 1;
            this.SideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideBar.Controls.Add(this.BottomMenu, 0, 1);
            this.SideBar.Controls.Add(this.TopMenu, 0, 0);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 50);
            this.SideBar.Margin = new System.Windows.Forms.Padding(0);
            this.SideBar.Name = "SideBar";
            this.SideBar.RowCount = 2;
            this.SideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.SideBar.Size = new System.Drawing.Size(240, 600);
            this.SideBar.TabIndex = 10;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // BottomMenu
            // 
            this.BottomMenu.BackColor = System.Drawing.Color.Transparent;
            this.BottomMenu.Controls.Add(this.btnLogout);
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomMenu.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.BottomMenu.Location = new System.Drawing.Point(0, 540);
            this.BottomMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BottomMenu.Name = "BottomMenu";
            this.BottomMenu.Size = new System.Drawing.Size(240, 60);
            this.BottomMenu.TabIndex = 12;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(240, 50);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(960, 600);
            this.pnMain.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TitleBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ProductContainer.ResumeLayout(false);
            this.TopMenu.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.BottomMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.FlowLayoutPanel ProductContainer;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Timer ProductTransition;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.FlowLayoutPanel TopMenu;
        private System.Windows.Forms.Button btnViolation;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnCloseProgram;
        private System.Windows.Forms.Button btnStatistic;
        private Button btnLogout;
        private TableLayoutPanel SideBar;
        private FlowLayoutPanel BottomMenu;

        private Panel pnMain;

    }
}

