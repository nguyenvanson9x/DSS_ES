namespace GUI
{
    partial class frmMain
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
            this.btnTuVan = new System.Windows.Forms.Button();
            this.btnCauHinh = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnContainer.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTuVan
            // 
            this.btnTuVan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTuVan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTuVan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuVan.FlatAppearance.BorderSize = 0;
            this.btnTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuVan.Location = new System.Drawing.Point(271, 416);
            this.btnTuVan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(150, 50);
            this.btnTuVan.TabIndex = 0;
            this.btnTuVan.Text = "Tư Vấn";
            this.btnTuVan.UseVisualStyleBackColor = false;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCauHinh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCauHinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauHinh.FlatAppearance.BorderSize = 0;
            this.btnCauHinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnCauHinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCauHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauHinh.Location = new System.Drawing.Point(534, 416);
            this.btnCauHinh.Margin = new System.Windows.Forms.Padding(0);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(150, 50);
            this.btnCauHinh.TabIndex = 1;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.UseVisualStyleBackColor = false;
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(950, 218);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Hệ thống lưu trữ thông tin tuyển sinh của các trường Đại học";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.pnTitle);
            this.pnContainer.Controls.Add(this.btnCauHinh);
            this.pnContainer.Controls.Add(this.btnTuVan);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(954, 511);
            this.pnContainer.TabIndex = 5;
            // 
            // pnTitle
            // 
            this.pnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(2, 77);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(950, 218);
            this.pnTitle.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(954, 511);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tư vấn chọn ngành CNTT";
            this.pnContainer.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.Button btnCauHinh;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Panel pnTitle;
    }
}