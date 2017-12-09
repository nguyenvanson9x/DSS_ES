namespace GUI
{
    partial class frmDanhSachTruong
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTruong,
            this.TenTruong,
            this.MaNganh,
            this.TenNganh,
            this.DiemChuan});
            this.dgv.Location = new System.Drawing.Point(0, 158);
            this.dgv.Margin = new System.Windows.Forms.Padding(0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(960, 309);
            this.dgv.TabIndex = 8;
            // 
            // MaTruong
            // 
            this.MaTruong.DataPropertyName = "MaTruong";
            this.MaTruong.HeaderText = "Mã trường";
            this.MaTruong.Name = "MaTruong";
            // 
            // TenTruong
            // 
            this.TenTruong.DataPropertyName = "TenTruong";
            this.TenTruong.HeaderText = "Tên trường";
            this.TenTruong.Name = "TenTruong";
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã ngành";
            this.MaNganh.Name = "MaNganh";
            // 
            // TenNganh
            // 
            this.TenNganh.DataPropertyName = "TenChuyenNganh";
            this.TenNganh.HeaderText = "Tên ngành";
            this.TenNganh.Name = "TenNganh";
            // 
            // DiemChuan
            // 
            this.DiemChuan.DataPropertyName = "DiemChuan";
            this.DiemChuan.HeaderText = "Điểm chuẩn";
            this.DiemChuan.Name = "DiemChuan";
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(960, 80);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "KẾT QUẢ TƯ VẤN CHỌN TRƯỜNG";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb1.Location = new System.Drawing.Point(12, 112);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(282, 20);
            this.lb1.TabIndex = 10;
            this.lb1.Text = "Danh sách các trường đại học đào tạo ";
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbChuyenNganh.Location = new System.Drawing.Point(289, 112);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(172, 20);
            this.lbChuyenNganh.TabIndex = 11;
            this.lbChuyenNganh.Text = "Công nghệ thông tin";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(825, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 41);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDanhSachTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbChuyenNganh);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachTruong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tư vấn chọn trường";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuan;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Button btnClose;
    }
}