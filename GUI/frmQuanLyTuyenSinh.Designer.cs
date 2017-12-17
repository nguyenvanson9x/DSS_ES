namespace GUI
{
    partial class frmQuanLyTuyenSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.clTenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLDaTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnRight = new System.Windows.Forms.Panel();
            this.txtTenTruong = new System.Windows.Forms.TextBox();
            this.lbTentruong = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSLDaTuyen = new System.Windows.Forms.TextBox();
            this.txtChiTieu = new System.Windows.Forms.TextBox();
            this.txtDiemChuan = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.lbSLDaTuyen = new System.Windows.Forms.Label();
            this.lbChiTieu = new System.Windows.Forms.Label();
            this.lbDiemChuan = new System.Windows.Forms.Label();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.lbTenNganh = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.tbContainer.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.pnRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContainer
            // 
            this.tbContainer.BackColor = System.Drawing.Color.White;
            this.tbContainer.ColumnCount = 2;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbContainer.Controls.Add(this.pnLeft, 0, 0);
            this.tbContainer.Controls.Add(this.pnRight, 1, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(0, 0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.Size = new System.Drawing.Size(960, 540);
            this.tbContainer.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnLeft.Controls.Add(this.lbSum);
            this.pnLeft.Controls.Add(this.lbS);
            this.pnLeft.Controls.Add(this.btnTimKiem);
            this.pnLeft.Controls.Add(this.txtTimKiem);
            this.pnLeft.Controls.Add(this.dgvInfo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(718, 540);
            this.pnLeft.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_property_24;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(592, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(364, 40);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 28);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtSearchChanged);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInfo.ColumnHeadersHeight = 26;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenTruong,
            this.clTenNganh,
            this.clMaNganh,
            this.clDiemChuan,
            this.clChiTieu,
            this.clSLDaTuyen});
            this.dgvInfo.Location = new System.Drawing.Point(0, 105);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInfo.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInfo.ShowEditingIcon = false;
            this.dgvInfo.Size = new System.Drawing.Size(718, 395);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_RowEnter);
            this.dgvInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellContentClick);
            // 
            // clTenTruong
            // 
            this.clTenTruong.DataPropertyName = "TenTruong";
            this.clTenTruong.HeaderText = "Tên Trường";
            this.clTenTruong.Name = "clTenTruong";
            this.clTenTruong.ReadOnly = true;
            this.clTenTruong.Width = 119;
            // 
            // clTenNganh
            // 
            this.clTenNganh.DataPropertyName = "TenChuyenNganh";
            this.clTenNganh.HeaderText = "Tên Ngành";
            this.clTenNganh.Name = "clTenNganh";
            this.clTenNganh.ReadOnly = true;
            this.clTenNganh.Width = 114;
            // 
            // clMaNganh
            // 
            this.clMaNganh.DataPropertyName = "MaNganh";
            this.clMaNganh.HeaderText = "Mã ngành";
            this.clMaNganh.Name = "clMaNganh";
            this.clMaNganh.ReadOnly = true;
            this.clMaNganh.Width = 106;
            // 
            // clDiemChuan
            // 
            this.clDiemChuan.DataPropertyName = "DiemChuan";
            this.clDiemChuan.HeaderText = "Điểm chuẩn";
            this.clDiemChuan.Name = "clDiemChuan";
            this.clDiemChuan.ReadOnly = true;
            this.clDiemChuan.Width = 122;
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "ChiTieu";
            this.clChiTieu.HeaderText = "Chỉ tiêu";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            this.clChiTieu.Width = 90;
            // 
            // clSLDaTuyen
            // 
            this.clSLDaTuyen.DataPropertyName = "SLDaTuyen";
            this.clSLDaTuyen.HeaderText = "Đã tuyển";
            this.clSLDaTuyen.Name = "clSLDaTuyen";
            this.clSLDaTuyen.ReadOnly = true;
            this.clSLDaTuyen.Width = 99;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnRight.Controls.Add(this.txtTenTruong);
            this.pnRight.Controls.Add(this.lbTentruong);
            this.pnRight.Controls.Add(this.btnHuy);
            this.pnRight.Controls.Add(this.btnXoa);
            this.pnRight.Controls.Add(this.btnSua);
            this.pnRight.Controls.Add(this.txtSLDaTuyen);
            this.pnRight.Controls.Add(this.txtChiTieu);
            this.pnRight.Controls.Add(this.txtDiemChuan);
            this.pnRight.Controls.Add(this.txtMaNganh);
            this.pnRight.Controls.Add(this.txtTenNganh);
            this.pnRight.Controls.Add(this.lbSLDaTuyen);
            this.pnRight.Controls.Add(this.lbChiTieu);
            this.pnRight.Controls.Add(this.lbDiemChuan);
            this.pnRight.Controls.Add(this.lbMaNganh);
            this.pnRight.Controls.Add(this.lbTenNganh);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(722, 0);
            this.pnRight.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(238, 540);
            this.pnRight.TabIndex = 2;
            // 
            // txtTenTruong
            // 
            this.txtTenTruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTruong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTruong.Location = new System.Drawing.Point(26, 48);
            this.txtTenTruong.Name = "txtTenTruong";
            this.txtTenTruong.Size = new System.Drawing.Size(190, 27);
            this.txtTenTruong.TabIndex = 15;
            // 
            // lbTentruong
            // 
            this.lbTentruong.AutoSize = true;
            this.lbTentruong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTentruong.Location = new System.Drawing.Point(23, 19);
            this.lbTentruong.Name = "lbTentruong";
            this.lbTentruong.Size = new System.Drawing.Size(81, 19);
            this.lbTentruong.TabIndex = 14;
            this.lbTentruong.Text = "Tên trường";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::GUI.Properties.Resources.icons8_close_pane_24;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(141, 486);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 36);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_delete_document_24;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(141, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_edit_property_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(26, 431);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSLDaTuyen
            // 
            this.txtSLDaTuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSLDaTuyen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDaTuyen.Location = new System.Drawing.Point(26, 370);
            this.txtSLDaTuyen.Name = "txtSLDaTuyen";
            this.txtSLDaTuyen.Size = new System.Drawing.Size(190, 27);
            this.txtSLDaTuyen.TabIndex = 9;
            // 
            // txtChiTieu
            // 
            this.txtChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiTieu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiTieu.Location = new System.Drawing.Point(26, 305);
            this.txtChiTieu.Name = "txtChiTieu";
            this.txtChiTieu.Size = new System.Drawing.Size(190, 27);
            this.txtChiTieu.TabIndex = 8;
            // 
            // txtDiemChuan
            // 
            this.txtDiemChuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiemChuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemChuan.Location = new System.Drawing.Point(26, 242);
            this.txtDiemChuan.Name = "txtDiemChuan";
            this.txtDiemChuan.Size = new System.Drawing.Size(190, 27);
            this.txtDiemChuan.TabIndex = 7;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNganh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(26, 176);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(190, 27);
            this.txtMaNganh.TabIndex = 6;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNganh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNganh.Location = new System.Drawing.Point(26, 112);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(190, 27);
            this.txtTenNganh.TabIndex = 5;
            // 
            // lbSLDaTuyen
            // 
            this.lbSLDaTuyen.AutoSize = true;
            this.lbSLDaTuyen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLDaTuyen.Location = new System.Drawing.Point(23, 339);
            this.lbSLDaTuyen.Name = "lbSLDaTuyen";
            this.lbSLDaTuyen.Size = new System.Drawing.Size(128, 19);
            this.lbSLDaTuyen.TabIndex = 4;
            this.lbSLDaTuyen.Text = "Số lượng đã tuyển";
            // 
            // lbChiTieu
            // 
            this.lbChiTieu.AutoSize = true;
            this.lbChiTieu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTieu.Location = new System.Drawing.Point(23, 275);
            this.lbChiTieu.Name = "lbChiTieu";
            this.lbChiTieu.Size = new System.Drawing.Size(59, 19);
            this.lbChiTieu.TabIndex = 3;
            this.lbChiTieu.Text = "Chỉ tiêu";
            // 
            // lbDiemChuan
            // 
            this.lbDiemChuan.AutoSize = true;
            this.lbDiemChuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemChuan.Location = new System.Drawing.Point(23, 211);
            this.lbDiemChuan.Name = "lbDiemChuan";
            this.lbDiemChuan.Size = new System.Drawing.Size(86, 19);
            this.lbDiemChuan.TabIndex = 2;
            this.lbDiemChuan.Text = "Điểm chuẩn";
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNganh.Location = new System.Drawing.Point(23, 147);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(74, 19);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành";
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNganh.Location = new System.Drawing.Point(23, 83);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(78, 19);
            this.lbTenNganh.TabIndex = 0;
            this.lbTenNganh.Text = "Tên Ngành";
            // 
            // lbSum
            // 
            this.lbSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSum.Location = new System.Drawing.Point(107, 512);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(0, 19);
            this.lbSum.TabIndex = 27;
            // 
            // lbS
            // 
            this.lbS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(12, 512);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(98, 19);
            this.lbS.TabIndex = 26;
            this.lbS.Text = "Tổng dữ liệu: ";
            // 
            // frmQuanLyTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.tbContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmQuanLyTuyenSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tuyển sinh";
            this.Load += new System.EventHandler(this.frmQuanLyTuyenSinh_Load);
            this.tbContainer.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbContainer;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbSLDaTuyen;
        private System.Windows.Forms.Label lbChiTieu;
        private System.Windows.Forms.Label lbDiemChuan;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Label lbTenNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.TextBox txtSLDaTuyen;
        private System.Windows.Forms.TextBox txtChiTieu;
        private System.Windows.Forms.TextBox txtDiemChuan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenTruong;
        private System.Windows.Forms.Label lbTentruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLDaTuyen;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbS;

    }
}