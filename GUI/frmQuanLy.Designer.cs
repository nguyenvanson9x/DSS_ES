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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tbButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnTruong = new System.Windows.Forms.Button();
            this.btnTuyenSinh = new System.Windows.Forms.Button();
            this.pnSubSystem = new System.Windows.Forms.Panel();
            this.pnContainer.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.tbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.tbContainer);
            this.pnContainer.Controls.Add(this.lbTitle);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1274, 621);
            this.pnContainer.TabIndex = 0;
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
            this.lbTitle.Text = "QUẢN LÝ THÔNG TIN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbContainer.Size = new System.Drawing.Size(1274, 541);
            this.tbContainer.TabIndex = 2;
            // 
            // tbButton
            // 
            this.tbButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.tbButton.ColumnCount = 1;
            this.tbButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbButton.Controls.Add(this.btnTuyenSinh, 0, 2);
            this.tbButton.Controls.Add(this.btnTruong, 0, 1);
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
            this.tbButton.Size = new System.Drawing.Size(293, 541);
            this.tbButton.TabIndex = 0;
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
            this.btnTruong.Location = new System.Drawing.Point(0, 108);
            this.btnTruong.Margin = new System.Windows.Forms.Padding(0);
            this.btnTruong.Name = "btnTruong";
            this.btnTruong.Size = new System.Drawing.Size(293, 108);
            this.btnTruong.TabIndex = 2;
            this.btnTruong.Text = "Thông tin Trường";
            this.btnTruong.UseVisualStyleBackColor = false;
            this.btnTruong.Click += new System.EventHandler(this.btnTruong_Click);
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
            this.btnTuyenSinh.Location = new System.Drawing.Point(0, 216);
            this.btnTuyenSinh.Margin = new System.Windows.Forms.Padding(0);
            this.btnTuyenSinh.Name = "btnTuyenSinh";
            this.btnTuyenSinh.Size = new System.Drawing.Size(293, 108);
            this.btnTuyenSinh.TabIndex = 3;
            this.btnTuyenSinh.Text = "Thông tin Tuyển sinh";
            this.btnTuyenSinh.UseVisualStyleBackColor = false;
            this.btnTuyenSinh.Click += new System.EventHandler(this.btnTuyenSinh_Click);
            // 
            // pnSubSystem
            // 
            this.pnSubSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSubSystem.Location = new System.Drawing.Point(296, 3);
            this.pnSubSystem.Name = "pnSubSystem";
            this.pnSubSystem.Size = new System.Drawing.Size(975, 535);
            this.pnSubSystem.TabIndex = 1;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLy";
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
    }
}