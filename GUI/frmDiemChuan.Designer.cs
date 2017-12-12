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
            this.lbTruong = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
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
            this.lbTitle.Location = new System.Drawing.Point(3, 3);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1268, 80);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "TRA ĐIỂM CHUẨN ĐẠI HỌC NĂM 2017 CHÍNH XÁC";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbContainer
            // 
            this.tbContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.tbContainer.ColumnCount = 2;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbContainer.Controls.Add(this.pnLeft, 0, 0);
            this.tbContainer.Controls.Add(this.pnRight, 1, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(3, 83);
            this.tbContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.Size = new System.Drawing.Size(1268, 535);
            this.tbContainer.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnLeft.Controls.Add(this.btnSearch);
            this.pnLeft.Controls.Add(this.cbTinh);
            this.pnLeft.Controls.Add(this.lbSearchFor);
            this.pnLeft.Controls.Add(this.cbSort);
            this.pnLeft.Controls.Add(this.lbSort);
            this.pnLeft.Controls.Add(this.listTruong);
            this.pnLeft.Controls.Add(this.pnSearch);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(633, 535);
            this.pnLeft.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = global::GUI.Properties.Resources.if_icon_ios7_search_211818;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(438, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbTinh
            // 
            this.cbTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinh.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Location = new System.Drawing.Point(404, 250);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(211, 29);
            this.cbTinh.TabIndex = 7;
            // 
            // lbSearchFor
            // 
            this.lbSearchFor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchFor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSearchFor.Location = new System.Drawing.Point(400, 203);
            this.lbSearchFor.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lbSearchFor.Name = "lbSearchFor";
            this.lbSearchFor.Size = new System.Drawing.Size(215, 35);
            this.lbSearchFor.TabIndex = 6;
            this.lbSearchFor.Text = "Tìm kiếm theo Tỉnh / TP";
            this.lbSearchFor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "-Sắp xếp theo-",
            "Thứ tự ABC",
            "Không theo thứ tự ABC"});
            this.cbSort.Location = new System.Drawing.Point(404, 142);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(211, 29);
            this.cbSort.TabIndex = 5;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSortClick);
            // 
            // lbSort
            // 
            this.lbSort.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSort.Location = new System.Drawing.Point(400, 94);
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
            this.listTruong.Location = new System.Drawing.Point(13, 99);
            this.listTruong.Name = "listTruong";
            this.listTruong.Size = new System.Drawing.Size(362, 422);
            this.listTruong.TabIndex = 3;
            this.listTruong.SelectedIndexChanged += new System.EventHandler(this.listTruongClick);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.lbSearch);
            this.pnSearch.Controls.Add(this.txtSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(633, 72);
            this.pnSearch.TabIndex = 2;
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSearch.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnRight.Controls.Add(this.dgv);
            this.pnRight.Controls.Add(this.lbName);
            this.pnRight.Controls.Add(this.lbTruong);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(635, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(633, 535);
            this.pnRight.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
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
            this.dgv.Location = new System.Drawing.Point(9, 99);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(621, 422);
            this.dgv.TabIndex = 7;
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
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(108)))));
            this.lbName.Location = new System.Drawing.Point(114, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(338, 35);
            this.lbName.TabIndex = 6;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTruong
            // 
            this.lbTruong.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTruong.ForeColor = System.Drawing.Color.Black;
            this.lbTruong.Location = new System.Drawing.Point(23, 18);
            this.lbTruong.Name = "lbTruong";
            this.lbTruong.Size = new System.Drawing.Size(85, 35);
            this.lbTruong.TabIndex = 5;
            this.lbTruong.Text = "Trường: ";
            this.lbTruong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnHelp.TabIndex = 2;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmDiemChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1274, 621);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tbContainer);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiemChuan";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "frmDiemChuan";
            this.Load += new System.EventHandler(this.frmDiemChuan_Load);
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
        private System.Windows.Forms.Label lbTruong;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemChuan;
    }
}