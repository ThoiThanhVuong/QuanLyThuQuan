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
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnViolation = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.ProductContainer.SuspendLayout();
            this.SideBar.SuspendLayout();
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
            this.ProductContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ProductContainer.Controls.Add(this.btnProduct);
            this.ProductContainer.Controls.Add(this.btnBook);
            this.ProductContainer.Controls.Add(this.btnDevice);
            this.ProductContainer.Location = new System.Drawing.Point(0, 56);
            this.ProductContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Size = new System.Drawing.Size(240, 50);
            this.ProductContainer.TabIndex = 6;
            this.ProductContainer.TabStop = true;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(3, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(240, 50);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "     Product";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 50);
            this.btnBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
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
            this.btnDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.Image")));
            this.btnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.Location = new System.Drawing.Point(0, 100);
            this.btnDevice.Margin = new System.Windows.Forms.Padding(0);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
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
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SideBar.Controls.Add(this.btnDashBoard);
            this.SideBar.Controls.Add(this.ProductContainer);
            this.SideBar.Controls.Add(this.btnRule);
            this.SideBar.Controls.Add(this.btnTransaction);
            this.SideBar.Controls.Add(this.btnViolation);
            this.SideBar.Controls.Add(this.btnReview);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 50);
            this.SideBar.Margin = new System.Windows.Forms.Padding(0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(240, 600);
            this.SideBar.TabIndex = 8;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(3, 3);
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
            this.btnRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRule.Image = ((System.Drawing.Image)(resources.GetObject("btnRule.Image")));
            this.btnRule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRule.Location = new System.Drawing.Point(3, 109);
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
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(3, 165);
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
            this.btnViolation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnViolation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnViolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolation.Image = ((System.Drawing.Image)(resources.GetObject("btnViolation.Image")));
            this.btnViolation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolation.Location = new System.Drawing.Point(3, 221);
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
            this.btnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(3, 277);
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
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
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
            this.SideBar.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Button btnViolation;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnCloseProgram;
    }
}

