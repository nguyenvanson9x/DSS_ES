namespace GUI
{
    partial class frmTuVan_Nganh
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
            this.lnTongDiem = new System.Windows.Forms.Label();
            this.lbTinhThanh = new System.Windows.Forms.Label();
            this.cbTinhThanh = new System.Windows.Forms.ComboBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.btnTongDiem = new System.Windows.Forms.Button();
            this.btnTinhThanh = new System.Windows.Forms.Button();
            this.btnTuVan = new System.Windows.Forms.Button();
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
            this.lbTitle.Text = "TƯ VẤN CHỌN NGÀNH";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnContainer.Controls.Add(this.btnTuVan);
            this.pnContainer.Controls.Add(this.btnTinhThanh);
            this.pnContainer.Controls.Add(this.btnTongDiem);
            this.pnContainer.Controls.Add(this.txtTongDiem);
            this.pnContainer.Controls.Add(this.cbTinhThanh);
            this.pnContainer.Controls.Add(this.lbTinhThanh);
            this.pnContainer.Controls.Add(this.lnTongDiem);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 80);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1274, 541);
            this.pnContainer.TabIndex = 2;
            // 
            // lnTongDiem
            // 
            this.lnTongDiem.AutoSize = true;
            this.lnTongDiem.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTongDiem.Location = new System.Drawing.Point(370, 154);
            this.lnTongDiem.Name = "lnTongDiem";
            this.lnTongDiem.Size = new System.Drawing.Size(137, 23);
            this.lnTongDiem.TabIndex = 0;
            this.lnTongDiem.Text = "Nhập tổng điểm";
            // 
            // lbTinhThanh
            // 
            this.lbTinhThanh.AutoSize = true;
            this.lbTinhThanh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhThanh.Location = new System.Drawing.Point(370, 237);
            this.lbTinhThanh.Name = "lbTinhThanh";
            this.lbTinhThanh.Size = new System.Drawing.Size(108, 23);
            this.lbTinhThanh.TabIndex = 1;
            this.lbTinhThanh.Text = "Tỉnh / Thành";
            // 
            // cbTinhThanh
            // 
            this.cbTinhThanh.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhThanh.FormattingEnabled = true;
            this.cbTinhThanh.Location = new System.Drawing.Point(532, 234);
            this.cbTinhThanh.Name = "cbTinhThanh";
            this.cbTinhThanh.Size = new System.Drawing.Size(217, 29);
            this.cbTinhThanh.TabIndex = 2;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDiem.Location = new System.Drawing.Point(532, 151);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(217, 29);
            this.txtTongDiem.TabIndex = 3;
            // 
            // btnTongDiem
            // 
            this.btnTongDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTongDiem.FlatAppearance.BorderSize = 0;
            this.btnTongDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongDiem.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongDiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTongDiem.Location = new System.Drawing.Point(791, 142);
            this.btnTongDiem.Name = "btnTongDiem";
            this.btnTongDiem.Size = new System.Drawing.Size(120, 45);
            this.btnTongDiem.TabIndex = 4;
            this.btnTongDiem.Text = "Tham khảo";
            this.btnTongDiem.UseVisualStyleBackColor = false;
            // 
            // btnTinhThanh
            // 
            this.btnTinhThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTinhThanh.FlatAppearance.BorderSize = 0;
            this.btnTinhThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhThanh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhThanh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTinhThanh.Location = new System.Drawing.Point(791, 225);
            this.btnTinhThanh.Name = "btnTinhThanh";
            this.btnTinhThanh.Size = new System.Drawing.Size(120, 45);
            this.btnTinhThanh.TabIndex = 5;
            this.btnTinhThanh.Text = "Tham khảo";
            this.btnTinhThanh.UseVisualStyleBackColor = false;
            // 
            // btnTuVan
            // 
            this.btnTuVan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTuVan.FlatAppearance.BorderSize = 0;
            this.btnTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuVan.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuVan.Location = new System.Drawing.Point(577, 353);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(120, 45);
            this.btnTuVan.TabIndex = 6;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.UseVisualStyleBackColor = false;
            // 
            // frmTuVan_Nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTuVan_Nganh";
            this.Text = "frmTuVan_Nganh";
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Label lnTongDiem;
        private System.Windows.Forms.ComboBox cbTinhThanh;
        private System.Windows.Forms.Label lbTinhThanh;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.Button btnTinhThanh;
        private System.Windows.Forms.Button btnTongDiem;
    }
}