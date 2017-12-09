namespace GUI
{
    partial class frmTuVan_Truong
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbTongDiem = new System.Windows.Forms.Label();
            this.lbTinhThanh = new System.Windows.Forms.Label();
            this.cbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cbTinhThanh = new System.Windows.Forms.ComboBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1274, 80);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "TƯ VẤN CHỌN TRƯỜNG ĐẠI HỌC NĂM 2017";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnContainer.Controls.Add(this.btnSearch);
            this.pnContainer.Controls.Add(this.txtTongDiem);
            this.pnContainer.Controls.Add(this.cbTinhThanh);
            this.pnContainer.Controls.Add(this.cbChuyenNganh);
            this.pnContainer.Controls.Add(this.lbTinhThanh);
            this.pnContainer.Controls.Add(this.lbTongDiem);
            this.pnContainer.Controls.Add(this.lbChuyenNganh);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 80);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1274, 541);
            this.pnContainer.TabIndex = 2;
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenNganh.Location = new System.Drawing.Point(350, 77);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(163, 23);
            this.lbChuyenNganh.TabIndex = 0;
            this.lbChuyenNganh.Text = "Chọn chuyên ngành";
            // 
            // lbTongDiem
            // 
            this.lbTongDiem.AutoSize = true;
            this.lbTongDiem.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDiem.Location = new System.Drawing.Point(350, 171);
            this.lbTongDiem.Name = "lbTongDiem";
            this.lbTongDiem.Size = new System.Drawing.Size(137, 23);
            this.lbTongDiem.TabIndex = 1;
            this.lbTongDiem.Text = "Nhập tổng điểm";
            // 
            // lbTinhThanh
            // 
            this.lbTinhThanh.AutoSize = true;
            this.lbTinhThanh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhThanh.Location = new System.Drawing.Point(350, 276);
            this.lbTinhThanh.Name = "lbTinhThanh";
            this.lbTinhThanh.Size = new System.Drawing.Size(94, 23);
            this.lbTinhThanh.TabIndex = 2;
            this.lbTinhThanh.Text = "Tỉnh thành";
            // 
            // cbChuyenNganh
            // 
            this.cbChuyenNganh.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenNganh.FormattingEnabled = true;
            this.cbChuyenNganh.Location = new System.Drawing.Point(655, 77);
            this.cbChuyenNganh.Name = "cbChuyenNganh";
            this.cbChuyenNganh.Size = new System.Drawing.Size(270, 29);
            this.cbChuyenNganh.TabIndex = 3;
            // 
            // cbTinhThanh
            // 
            this.cbTinhThanh.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhThanh.FormattingEnabled = true;
            this.cbTinhThanh.Location = new System.Drawing.Point(655, 276);
            this.cbTinhThanh.Name = "cbTinhThanh";
            this.cbTinhThanh.Size = new System.Drawing.Size(270, 29);
            this.cbTinhThanh.TabIndex = 4;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDiem.Location = new System.Drawing.Point(655, 171);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(270, 29);
            this.txtTongDiem.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(547, 407);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 50);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm trường";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTuVan_Truong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTuVan_Truong";
            this.Text = "frmTuVan_Truong";
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Label lbTinhThanh;
        private System.Windows.Forms.Label lbTongDiem;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.ComboBox cbTinhThanh;
        private System.Windows.Forms.ComboBox cbChuyenNganh;
        private System.Windows.Forms.Button btnSearch;
    }
}