namespace GUI
{
    partial class frm1
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
            this.pnNav = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnDiemChuan = new System.Windows.Forms.Button();
            this.btnTuVan_Truong = new System.Windows.Forms.Button();
            this.btnTuVan_Nganh = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnCauHinh = new System.Windows.Forms.Button();
            this.pnSubSystem = new System.Windows.Forms.Panel();
            this.pnNav.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNav
            // 
            this.pnNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.pnNav.Controls.Add(this.pnButton);
            this.pnNav.Controls.Add(this.lbLogo);
            this.pnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNav.Location = new System.Drawing.Point(0, 0);
            this.pnNav.Margin = new System.Windows.Forms.Padding(0);
            this.pnNav.Name = "pnNav";
            this.pnNav.Size = new System.Drawing.Size(1274, 70);
            this.pnNav.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.BackColor = System.Drawing.Color.Silver;
            this.lbLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(0, 0);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(262, 70);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Logo";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            this.pnButton.Controls.Add(this.btnCauHinh);
            this.pnButton.Controls.Add(this.btnQuanLy);
            this.pnButton.Controls.Add(this.btnTuVan_Nganh);
            this.pnButton.Controls.Add(this.btnTuVan_Truong);
            this.pnButton.Controls.Add(this.btnDiemChuan);
            this.pnButton.Location = new System.Drawing.Point(262, 0);
            this.pnButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1012, 70);
            this.pnButton.TabIndex = 1;
            // 
            // btnDiemChuan
            // 
            this.btnDiemChuan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDiemChuan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiemChuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemChuan.FlatAppearance.BorderSize = 0;
            this.btnDiemChuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemChuan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiemChuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemChuan.Location = new System.Drawing.Point(20, 15);
            this.btnDiemChuan.Name = "btnDiemChuan";
            this.btnDiemChuan.Size = new System.Drawing.Size(171, 40);
            this.btnDiemChuan.TabIndex = 0;
            this.btnDiemChuan.Text = "Điểm chuẩn đại học";
            this.btnDiemChuan.UseVisualStyleBackColor = false;
            this.btnDiemChuan.Click += new System.EventHandler(this.btnDiemChuan_Click);
            // 
            // btnTuVan_Truong
            // 
            this.btnTuVan_Truong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTuVan_Truong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTuVan_Truong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuVan_Truong.FlatAppearance.BorderSize = 0;
            this.btnTuVan_Truong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuVan_Truong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan_Truong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuVan_Truong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuVan_Truong.Location = new System.Drawing.Point(256, 15);
            this.btnTuVan_Truong.Name = "btnTuVan_Truong";
            this.btnTuVan_Truong.Size = new System.Drawing.Size(171, 40);
            this.btnTuVan_Truong.TabIndex = 1;
            this.btnTuVan_Truong.Text = "Tư vấn chọn trường";
            this.btnTuVan_Truong.UseVisualStyleBackColor = false;
            this.btnTuVan_Truong.Click += new System.EventHandler(this.btnTuVan_Truong_Click);
            // 
            // btnTuVan_Nganh
            // 
            this.btnTuVan_Nganh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTuVan_Nganh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTuVan_Nganh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuVan_Nganh.FlatAppearance.BorderSize = 0;
            this.btnTuVan_Nganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuVan_Nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan_Nganh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuVan_Nganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuVan_Nganh.Location = new System.Drawing.Point(492, 15);
            this.btnTuVan_Nganh.Name = "btnTuVan_Nganh";
            this.btnTuVan_Nganh.Size = new System.Drawing.Size(171, 40);
            this.btnTuVan_Nganh.TabIndex = 2;
            this.btnTuVan_Nganh.Text = "Tư vấn chọn ngành";
            this.btnTuVan_Nganh.UseVisualStyleBackColor = false;
            this.btnTuVan_Nganh.Click += new System.EventHandler(this.btnTuVan_Nganh_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuanLy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.Location = new System.Drawing.Point(728, 15);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(100, 40);
            this.btnQuanLy.TabIndex = 3;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCauHinh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCauHinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauHinh.FlatAppearance.BorderSize = 0;
            this.btnCauHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauHinh.Location = new System.Drawing.Point(893, 15);
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Size = new System.Drawing.Size(100, 40);
            this.btnCauHinh.TabIndex = 4;
            this.btnCauHinh.Text = "Cấu hình";
            this.btnCauHinh.UseVisualStyleBackColor = false;
            this.btnCauHinh.Click += new System.EventHandler(this.btnCauHinh_Click);
            // 
            // pnSubSystem
            // 
            this.pnSubSystem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnSubSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubSystem.Location = new System.Drawing.Point(0, 70);
            this.pnSubSystem.Margin = new System.Windows.Forms.Padding(0);
            this.pnSubSystem.Name = "pnSubSystem";
            this.pnSubSystem.Size = new System.Drawing.Size(1274, 621);
            this.pnSubSystem.TabIndex = 1;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.pnSubSystem);
            this.Controls.Add(this.pnNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm1";
            this.pnNav.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNav;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnTuVan_Nganh;
        private System.Windows.Forms.Button btnTuVan_Truong;
        private System.Windows.Forms.Button btnDiemChuan;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnCauHinh;
        private System.Windows.Forms.Panel pnSubSystem;
    }
}