namespace GUI
{
    partial class frmQuanLy
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
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tbButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnTuyenSinh = new System.Windows.Forms.Button();
            this.btnTruong = new System.Windows.Forms.Button();
            this.btnThemDuLieu = new System.Windows.Forms.Button();
            this.pnSubSystem = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnContainer.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.tbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.btnHelp);
            this.pnContainer.Controls.Add(this.tbContainer);
            this.pnContainer.Controls.Add(this.lbTitle);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(3, 3);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1268, 615);
            this.pnContainer.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::GUI.Properties.Resources.if_question_2625632__1_;
            this.btnHelp.Location = new System.Drawing.Point(1229, 24);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 33);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tbContainer
            // 
            this.tbContainer.ColumnCount = 2;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tbContainer.Controls.Add(this.tbButton, 0, 0);
            this.tbContainer.Controls.Add(this.pnSubSystem, 1, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(0, 80);
            this.tbContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.Size = new System.Drawing.Size(1268, 535);
            this.tbContainer.TabIndex = 2;
            // 
            // tbButton
            // 
            this.tbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.tbButton.ColumnCount = 1;
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbButton.Controls.Add(this.btnTuyenSinh, 0, 2);
            this.tbButton.Controls.Add(this.btnTruong, 0, 1);
            this.tbButton.Controls.Add(this.btnThemDuLieu, 0, 3);
            this.tbButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbButton.Location = new System.Drawing.Point(0, 0);
            this.tbButton.Margin = new System.Windows.Forms.Padding(0);
            this.tbButton.Name = "tbButton";
            this.tbButton.RowCount = 5;
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbButton.Size = new System.Drawing.Size(291, 535);
            this.tbButton.TabIndex = 0;
            // 
            // btnTuyenSinh
            // 
            this.btnTuyenSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTuyenSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnTuyenSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuyenSinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTuyenSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTuyenSinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTuyenSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyenSinh.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyenSinh.ForeColor = System.Drawing.Color.Black;
            this.btnTuyenSinh.Image = global::GUI.Properties.Resources.if_education_school_learn_study_02_2125360;
            this.btnTuyenSinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuyenSinh.Location = new System.Drawing.Point(0, 214);
            this.btnTuyenSinh.Margin = new System.Windows.Forms.Padding(0);
            this.btnTuyenSinh.Name = "btnTuyenSinh";
            this.btnTuyenSinh.Size = new System.Drawing.Size(291, 107);
            this.btnTuyenSinh.TabIndex = 3;
            this.btnTuyenSinh.Text = "Thông tin Tuyển sinh";
            this.btnTuyenSinh.UseVisualStyleBackColor = false;
            this.btnTuyenSinh.Click += new System.EventHandler(this.btnTuyenSinh_Click);
            // 
            // btnTruong
            // 
            this.btnTruong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTruong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnTruong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTruong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTruong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTruong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruong.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruong.ForeColor = System.Drawing.Color.Black;
            this.btnTruong.Image = global::GUI.Properties.Resources.if_education_school_learn_study_06_2125344;
            this.btnTruong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTruong.Location = new System.Drawing.Point(0, 107);
            this.btnTruong.Margin = new System.Windows.Forms.Padding(0);
            this.btnTruong.Name = "btnTruong";
            this.btnTruong.Size = new System.Drawing.Size(291, 107);
            this.btnTruong.TabIndex = 2;
            this.btnTruong.Text = "Thông tin Trường";
            this.btnTruong.UseVisualStyleBackColor = false;
            this.btnTruong.Click += new System.EventHandler(this.btnTruong_Click);
            // 
            // btnThemDuLieu
            // 
            this.btnThemDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnThemDuLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDuLieu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnThemDuLieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnThemDuLieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnThemDuLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDuLieu.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDuLieu.ForeColor = System.Drawing.Color.Black;
            this.btnThemDuLieu.Image = global::GUI.Properties.Resources.if_notes_add_103660;
            this.btnThemDuLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDuLieu.Location = new System.Drawing.Point(0, 321);
            this.btnThemDuLieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemDuLieu.Name = "btnThemDuLieu";
            this.btnThemDuLieu.Size = new System.Drawing.Size(291, 107);
            this.btnThemDuLieu.TabIndex = 4;
            this.btnThemDuLieu.Text = "Thêm dữ liệu";
            this.btnThemDuLieu.UseVisualStyleBackColor = false;
            this.btnThemDuLieu.Click += new System.EventHandler(this.btnThemDuLieu_Click);
            // 
            // pnSubSystem
            // 
            this.pnSubSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnSubSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubSystem.Location = new System.Drawing.Point(291, 0);
            this.pnSubSystem.Margin = new System.Windows.Forms.Padding(0);
            this.pnSubSystem.Name = "pnSubSystem";
            this.pnSubSystem.Size = new System.Drawing.Size(977, 535);
            this.pnSubSystem.TabIndex = 1;
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
            this.lbTitle.Size = new System.Drawing.Size(1268, 80);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "QUẢN LÝ THÔNG TIN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLy";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.pnContainer.ResumeLayout(false);
            this.tbContainer.ResumeLayout(false);
            this.tbButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tbContainer;
        private System.Windows.Forms.TableLayoutPanel tbButton;
        private System.Windows.Forms.Button btnTruong;
        private System.Windows.Forms.Button btnTuyenSinh;
        private System.Windows.Forms.Panel pnSubSystem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnThemDuLieu;
    }
}