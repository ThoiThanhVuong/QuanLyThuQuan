namespace QuanLyThuQuan.GUI
{
    partial class BookItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBookCover = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnViewDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 6);
            this.panel1.TabIndex = 0;
            // 
            // pbBookCover
            // 
            this.pbBookCover.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBookCover.Location = new System.Drawing.Point(0, 6);
            this.pbBookCover.Margin = new System.Windows.Forms.Padding(0);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.Size = new System.Drawing.Size(220, 224);
            this.pbBookCover.TabIndex = 1;
            this.pbBookCover.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnViewDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 90);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblBookTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(220, 49);
            this.panel3.TabIndex = 0;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoEllipsis = true;
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(50, 12);
            this.lblBookTitle.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookTitle.Size = new System.Drawing.Size(84, 23);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Tên sách";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.btnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(45)))), ((int)(((byte)(121)))));
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.btnViewDetail.Location = new System.Drawing.Point(97, 54);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(120, 33);
            this.btnViewDetail.TabIndex = 1;
            this.btnViewDetail.Text = "Xem chi tiết";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // BookItemControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "BookItemControl";
            this.Size = new System.Drawing.Size(220, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBookCover;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Panel panel3;
    }
}
