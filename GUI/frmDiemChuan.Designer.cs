namespace GUI
{
    partial class frmDiemChuan
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
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.lbSearchFor = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.listTruong = new System.Windows.Forms.ListBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContainer.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TRA ĐIỂM CHUẨN ĐẠI HỌC NĂM 2017 CHÍNH XÁC";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbContainer
            // 
            this.tbContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbContainer.ColumnCount = 2;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbContainer.Controls.Add(this.pnLeft, 0, 0);
            this.tbContainer.Controls.Add(this.pnRight, 1, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(0, 80);
            this.tbContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.Size = new System.Drawing.Size(1274, 541);
            this.tbContainer.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnLeft.Controls.Add(this.btnSearch);
            this.pnLeft.Controls.Add(this.cbTinh);
            this.pnLeft.Controls.Add(this.lbSearchFor);
            this.pnLeft.Controls.Add(this.cbSort);
            this.pnLeft.Controls.Add(this.lbSort);
            this.pnLeft.Controls.Add(this.listTruong);
            this.pnLeft.Controls.Add(this.pnSearch);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(3, 3);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(631, 535);
            this.pnLeft.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(401, 335);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cbTinh
            // 
            this.cbTinh.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Items.AddRange(new object[] {
            "--Tỉnh / TP--",
            "An Giang"});
            this.cbTinh.Location = new System.Drawing.Point(401, 250);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(211, 29);
            this.cbTinh.TabIndex = 7;
            this.cbTinh.Text = "--Tỉnh / TP--";
            // 
            // lbSearchFor
            // 
            this.lbSearchFor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSearchFor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(108)))));
            this.lbSearchFor.Location = new System.Drawing.Point(397, 203);
            this.lbSearchFor.Name = "lbSearchFor";
            this.lbSearchFor.Size = new System.Drawing.Size(215, 35);
            this.lbSearchFor.TabIndex = 6;
            this.lbSearchFor.Text = "Tìm kiếm theo";
            this.lbSearchFor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "-Sắp xếp theo-",
            "Thứ tự ABC",
            "Không theo thứ tự ABC"});
            this.cbSort.Location = new System.Drawing.Point(401, 142);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(211, 29);
            this.cbSort.TabIndex = 5;
            this.cbSort.Text = "-Sắp xếp theo-";
            // 
            // lbSort
            // 
            this.lbSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSort.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(108)))));
            this.lbSort.Location = new System.Drawing.Point(397, 94);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(215, 35);
            this.lbSort.TabIndex = 4;
            this.lbSort.Text = "Sắp xếp tên trường theo:";
            this.lbSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listTruong
            // 
            this.listTruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listTruong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTruong.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTruong.FormattingEnabled = true;
            this.listTruong.ItemHeight = 21;
            this.listTruong.Items.AddRange(new object[] {
            "fdsfds",
            "fds",
            "f",
            "sd",
            "fsd",
            "f",
            "sd",
            "fsd",
            "f",
            "sd",
            "f",
            "sdf",
            "sd",
            "f",
            "sd",
            "fd",
            "sf",
            "sdf",
            "ds",
            "f",
            "dsf",
            "ds",
            "fds",
            "f",
            "sdf",
            "ds",
            "",
            "fg",
            "hẻ",
            "fg",
            "ẻ"});
            this.listTruong.Location = new System.Drawing.Point(13, 78);
            this.listTruong.Name = "listTruong";
            this.listTruong.Size = new System.Drawing.Size(362, 422);
            this.listTruong.TabIndex = 3;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(631, 72);
            this.pnSearch.TabIndex = 2;
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(108)))));
            this.lbSearch.Location = new System.Drawing.Point(9, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(175, 35);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Chọn trường:";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(190, 19);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.SystemColors.Control;
            this.pnRight.Controls.Add(this.dgv);
            this.pnRight.Controls.Add(this.lbName);
            this.pnRight.Controls.Add(this.label1);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(640, 3);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(631, 535);
            this.pnRight.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh,
            this.DiemChuan});
            this.dgv.Location = new System.Drawing.Point(29, 129);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(593, 397);
            this.dgv.TabIndex = 7;
            // 
            // MaNganh
            // 
            this.MaNganh.HeaderText = "Mã ngành";
            this.MaNganh.Name = "MaNganh";
            // 
            // TenNganh
            // 
            this.TenNganh.HeaderText = "Tên ngành";
            this.TenNganh.Name = "TenNganh";
            // 
            // DiemChuan
            // 
            this.DiemChuan.HeaderText = "Điểm chuẩn";
            this.DiemChuan.Name = "DiemChuan";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(108)))));
            this.lbName.Location = new System.Drawing.Point(116, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(338, 35);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Đại học Bách khoa Hà Nội";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trường: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDiemChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.tbContainer);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemChuan";
            this.Text = "frmDiemChuan";
            this.tbContainer.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tbContainer;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.ListBox listTruong;
        private System.Windows.Forms.Label lbSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label lbSearchFor;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuan;
    }
}