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
            this.dgvDataReservation = new System.Windows.Forms.DataGridView();
            this.tbBodyReservasion.SuspendLayout();
            this.pnlHeaderReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataReservation)).BeginInit();
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
            this.tbBodyReservasion.Controls.Add(this.dgvDataReservation, 0, 1);
            this.tbBodyReservasion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBodyReservasion.Location = new System.Drawing.Point(0, 0);
            this.tbBodyReservasion.Margin = new System.Windows.Forms.Padding(0);
            this.tbBodyReservasion.Name = "tbBodyReservasion";
            this.tbBodyReservasion.RowCount = 3;
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.98529F));
            this.tbBodyReservasion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.088235F));
            this.tbBodyReservasion.Size = new System.Drawing.Size(960, 544);
            this.tbBodyReservasion.TabIndex = 8;
            // 
            // pnlHeaderReservation
            // 
            this.pnlHeaderReservation.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderReservation.Controls.Add(this.btnExitChildPanel);
            this.pnlHeaderReservation.Controls.Add(this.lbTitleReservation);
            this.pnlHeaderReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderReservation.Location = new System.Drawing.Point(2, 3);
            this.pnlHeaderReservation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeaderReservation.Name = "pnlHeaderReservation";
            this.pnlHeaderReservation.Size = new System.Drawing.Size(956, 48);
            this.pnlHeaderReservation.TabIndex = 0;
            // 
            // btnExitChildPanel
            // 
            this.btnExitChildPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExitChildPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChildPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitChildPanel.ForeColor = System.Drawing.Color.Red;
            this.btnExitChildPanel.Location = new System.Drawing.Point(914, 6);
            this.btnExitChildPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitChildPanel.Name = "btnExitChildPanel";
            this.btnExitChildPanel.Size = new System.Drawing.Size(30, 30);
            this.btnExitChildPanel.TabIndex = 2;
            this.btnExitChildPanel.Text = "X";
            this.btnExitChildPanel.UseVisualStyleBackColor = false;
            this.btnExitChildPanel.Click += new System.EventHandler(this.btnExitChildPanel_Click);
            // 
            // lbTitleReservation
            // 
            this.lbTitleReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTitleReservation.AutoSize = true;
            this.lbTitleReservation.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleReservation.ForeColor = System.Drawing.Color.Black;
            this.lbTitleReservation.Location = new System.Drawing.Point(382, 6);
            this.lbTitleReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitleReservation.Name = "lbTitleReservation";
            this.lbTitleReservation.Size = new System.Drawing.Size(168, 31);
            this.lbTitleReservation.TabIndex = 0;
            this.lbTitleReservation.Text = "Reservation List";
            this.lbTitleReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDataReservation
            // 
            this.dgvDataReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDataReservation.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDataReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataReservation.Location = new System.Drawing.Point(3, 72);
            this.dgvDataReservation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDataReservation.Name = "dgvDataReservation";
            this.dgvDataReservation.RowHeadersWidth = 62;
            this.dgvDataReservation.Size = new System.Drawing.Size(954, 409);
            this.dgvDataReservation.TabIndex = 1;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.ControlBox = false;
            this.Controls.Add(this.tbBodyReservasion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tbBodyReservasion.ResumeLayout(false);
            this.pnlHeaderReservation.ResumeLayout(false);
            this.pnlHeaderReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbBodyReservasion;
        private System.Windows.Forms.Panel pnlHeaderReservation;
        private System.Windows.Forms.Label lbTitleReservation;
        private System.Windows.Forms.DataGridView dgvDataReservation;
        private System.Windows.Forms.Button btnExitChildPanel;
    }
}