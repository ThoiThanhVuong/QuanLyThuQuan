namespace QuanLyThuQuan.GUI.TransactionFormChilds
{
    partial class FormReservation
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
            this.tbBodyReservasion = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderReservation = new System.Windows.Forms.Panel();
            this.btnExitChildPanel = new System.Windows.Forms.Button();
            this.lbTitleReservation = new System.Windows.Forms.Label();
            this.tbReservationInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pReservationList = new System.Windows.Forms.Panel();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.pReservationDetailList = new System.Windows.Forms.Panel();
            this.dgvDetailReservation = new System.Windows.Forms.DataGridView();
            this.pDetailReservationHeader = new System.Windows.Forms.Panel();
            this.lbReservationDetail = new System.Windows.Forms.Label();
            this.tbBodyReservasion.SuspendLayout();
            this.pnlHeaderReservation.SuspendLayout();
            this.tbReservationInfo.SuspendLayout();
            this.pReservationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.pReservationDetailList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReservation)).BeginInit();
            this.pDetailReservationHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBodyReservasion
            // 
            this.tbBodyReservasion.AutoSize = true;
            this.tbBodyReservasion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbBodyReservasion.BackColor = System.Drawing.Color.AliceBlue;
            this.tbBodyReservasion.ColumnCount = 1;
            this.tbBodyReservasion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBodyReservasion.Controls.Add(this.pnlHeaderReservation, 0, 0);
            this.tbBodyReservasion.Controls.Add(this.tbReservationInfo, 0, 1);
            this.tbBodyReservasion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBodyReservasion.Location = new System.Drawing.Point(0, 0);
            this.tbBodyReservasion.Margin = new System.Windows.Forms.Padding(0);
            this.tbBodyReservasion.Name = "tbBodyReservasion";
            this.tbBodyReservasion.RowCount = 3;
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.364549F));
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.13043F));
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.337793F));
            this.tbBodyReservasion.Size = new System.Drawing.Size(1497, 920);
            this.tbBodyReservasion.TabIndex = 8;
            // 
            // pnlHeaderReservation
            // 
            this.pnlHeaderReservation.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderReservation.Controls.Add(this.btnExitChildPanel);
            this.pnlHeaderReservation.Controls.Add(this.lbTitleReservation);
            this.pnlHeaderReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderReservation.Location = new System.Drawing.Point(3, 5);
            this.pnlHeaderReservation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlHeaderReservation.Name = "pnlHeaderReservation";
            this.pnlHeaderReservation.Size = new System.Drawing.Size(1491, 76);
            this.pnlHeaderReservation.TabIndex = 3;
            // 
            // btnExitChildPanel
            // 
            this.btnExitChildPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitChildPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChildPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitChildPanel.ForeColor = System.Drawing.Color.Red;
            this.btnExitChildPanel.Location = new System.Drawing.Point(1432, 12);
            this.btnExitChildPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnExitChildPanel.Name = "btnExitChildPanel";
            this.btnExitChildPanel.Size = new System.Drawing.Size(45, 46);
            this.btnExitChildPanel.TabIndex = 2;
            this.btnExitChildPanel.Text = "X";
            this.btnExitChildPanel.UseVisualStyleBackColor = false;
            this.btnExitChildPanel.Click += new System.EventHandler(this.btnExitChildPanel_Click);
            // 
            // lbTitleReservation
            // 
            this.lbTitleReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitleReservation.AutoSize = true;
            this.lbTitleReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbTitleReservation.Location = new System.Drawing.Point(658, 26);
            this.lbTitleReservation.Name = "lbTitleReservation";
            this.lbTitleReservation.Size = new System.Drawing.Size(200, 29);
            this.lbTitleReservation.TabIndex = 0;
            this.lbTitleReservation.Text = "Reservation List";
            this.lbTitleReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReservationInfo
            // 
            this.tbReservationInfo.ColumnCount = 1;
            this.tbReservationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbReservationInfo.Controls.Add(this.pReservationList, 0, 0);
            this.tbReservationInfo.Controls.Add(this.pReservationDetailList, 0, 1);
            this.tbReservationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbReservationInfo.Location = new System.Drawing.Point(4, 91);
            this.tbReservationInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbReservationInfo.Name = "tbReservationInfo";
            this.tbReservationInfo.RowCount = 2;
            this.tbReservationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.99237F));
            this.tbReservationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.00763F));
            this.tbReservationInfo.Size = new System.Drawing.Size(1489, 811);
            this.tbReservationInfo.TabIndex = 2;
            // 
            // pReservationList
            // 
            this.pReservationList.Controls.Add(this.dgvReservation);
            this.pReservationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReservationList.Location = new System.Drawing.Point(4, 5);
            this.pReservationList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pReservationList.Name = "pReservationList";
            this.pReservationList.Size = new System.Drawing.Size(1481, 362);
            this.pReservationList.TabIndex = 0;
            // 
            // dgvReservation
            // 
            this.dgvReservation.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(0, 0);
            this.dgvReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 62;
            this.dgvReservation.Size = new System.Drawing.Size(1481, 362);
            this.dgvReservation.TabIndex = 1;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // pReservationDetailList
            // 
            this.pReservationDetailList.Controls.Add(this.dgvDetailReservation);
            this.pReservationDetailList.Controls.Add(this.pDetailReservationHeader);
            this.pReservationDetailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReservationDetailList.Location = new System.Drawing.Point(4, 377);
            this.pReservationDetailList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pReservationDetailList.Name = "pReservationDetailList";
            this.pReservationDetailList.Size = new System.Drawing.Size(1481, 429);
            this.pReservationDetailList.TabIndex = 1;
            // 
            // dgvDetailReservation
            // 
            this.dgvDetailReservation.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvDetailReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetailReservation.Location = new System.Drawing.Point(0, 82);
            this.dgvDetailReservation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetailReservation.Name = "dgvDetailReservation";
            this.dgvDetailReservation.RowHeadersWidth = 62;
            this.dgvDetailReservation.Size = new System.Drawing.Size(1481, 347);
            this.dgvDetailReservation.TabIndex = 1;
            // 
            // pDetailReservationHeader
            // 
            this.pDetailReservationHeader.Controls.Add(this.lbReservationDetail);
            this.pDetailReservationHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDetailReservationHeader.Location = new System.Drawing.Point(0, 0);
            this.pDetailReservationHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pDetailReservationHeader.Name = "pDetailReservationHeader";
            this.pDetailReservationHeader.Size = new System.Drawing.Size(1481, 82);
            this.pDetailReservationHeader.TabIndex = 0;
            // 
            // lbReservationDetail
            // 
            this.lbReservationDetail.AutoSize = true;
            this.lbReservationDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservationDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(30)))), ((int)(((byte)(76)))));
            this.lbReservationDetail.Location = new System.Drawing.Point(645, 26);
            this.lbReservationDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReservationDetail.Name = "lbReservationDetail";
            this.lbReservationDetail.Size = new System.Drawing.Size(240, 29);
            this.lbReservationDetail.TabIndex = 0;
            this.lbReservationDetail.Text = "Reservation Details";
            this.lbReservationDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 920);
            this.ControlBox = false;
            this.Controls.Add(this.tbBodyReservasion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tbBodyReservasion.ResumeLayout(false);
            this.pnlHeaderReservation.ResumeLayout(false);
            this.pnlHeaderReservation.PerformLayout();
            this.tbReservationInfo.ResumeLayout(false);
            this.pReservationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.pReservationDetailList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReservation)).EndInit();
            this.pDetailReservationHeader.ResumeLayout(false);
            this.pDetailReservationHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbBodyReservasion;
        private System.Windows.Forms.TableLayoutPanel tbReservationInfo;
        private System.Windows.Forms.Panel pReservationList;
        private System.Windows.Forms.Panel pReservationDetailList;
        private System.Windows.Forms.Panel pnlHeaderReservation;
        private System.Windows.Forms.Button btnExitChildPanel;
        private System.Windows.Forms.Label lbTitleReservation;
        private System.Windows.Forms.Panel pDetailReservationHeader;
        private System.Windows.Forms.DataGridView dgvDetailReservation;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Label lbReservationDetail;
    }
}