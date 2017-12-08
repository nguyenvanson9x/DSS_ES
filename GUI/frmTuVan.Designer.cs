namespace GUI
{
    partial class frmTuVan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolbar = new System.Windows.Forms.MenuStrip();
            this.thong_tin_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_tin_truong_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.thong_tin_tuyen_sinh_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.quan_ly_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.quan_ly_truong_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.quan_ly_tuyen_sinh_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.gioi_thieu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.huong_dan_su_dung_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnThamKhaoTinhThanh = new System.Windows.Forms.Button();
            this.btnThamKhaoTongDiem = new System.Windows.Forms.Button();
            this.pnInfoLeft = new System.Windows.Forms.Panel();
            this.lbInfoLeft = new System.Windows.Forms.Label();
            this.cbThongTinThem = new System.Windows.Forms.ComboBox();
            this.lbThongTinThem = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTuVan = new System.Windows.Forms.Button();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.lbTongDiem = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.lbDetailDiemChuan = new System.Windows.Forms.Label();
            this.lbDetailNganh = new System.Windows.Forms.Label();
            this.lbDetailTruong = new System.Windows.Forms.Label();
            this.lbDiemChuan = new System.Windows.Forms.Label();
            this.lbNganh = new System.Windows.Forms.Label();
            this.lbTruong = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.MaTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnInfoRight = new System.Windows.Forms.Panel();
            this.lbInfoRight = new System.Windows.Forms.Label();
            this.tu_van_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.diem_thi_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.khu_vuc_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnInfoLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.pnInfoRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.toolbar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolbar.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thong_tin_Item,
            this.quan_ly_Item,
            this.tu_van_Item,
            this.gioi_thieu_Item});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolbar.Size = new System.Drawing.Size(1274, 35);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolbar";
            // 
            // thong_tin_Item
            // 
            this.thong_tin_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thong_tin_truong_Item,
            this.thong_tin_tuyen_sinh_Item});
            this.thong_tin_Item.Name = "thong_tin_Item";
            this.thong_tin_Item.Size = new System.Drawing.Size(80, 23);
            this.thong_tin_Item.Text = "Thông tin";
            // 
            // thong_tin_truong_Item
            // 
            this.thong_tin_truong_Item.Name = "thong_tin_truong_Item";
            this.thong_tin_truong_Item.Size = new System.Drawing.Size(205, 24);
            this.thong_tin_truong_Item.Text = "Thông tin trường";
            this.thong_tin_truong_Item.Click += new System.EventHandler(this.thong_tin_truong_Item_Click);
            // 
            // thong_tin_tuyen_sinh_Item
            // 
            this.thong_tin_tuyen_sinh_Item.Name = "thong_tin_tuyen_sinh_Item";
            this.thong_tin_tuyen_sinh_Item.Size = new System.Drawing.Size(205, 24);
            this.thong_tin_tuyen_sinh_Item.Text = "Thông tin tuyển sinh";
            this.thong_tin_tuyen_sinh_Item.Click += new System.EventHandler(this.thong_tin_tuyen_sinh_Item_Click);
            // 
            // quan_ly_Item
            // 
            this.quan_ly_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quan_ly_truong_Item,
            this.quan_ly_tuyen_sinh_Item});
            this.quan_ly_Item.Name = "quan_ly_Item";
            this.quan_ly_Item.Size = new System.Drawing.Size(69, 23);
            this.quan_ly_Item.Text = "Quản lý";
            // 
            // quan_ly_truong_Item
            // 
            this.quan_ly_truong_Item.Name = "quan_ly_truong_Item";
            this.quan_ly_truong_Item.Size = new System.Drawing.Size(194, 24);
            this.quan_ly_truong_Item.Text = "Quản lý trường";
            this.quan_ly_truong_Item.Click += new System.EventHandler(this.quan_ly_truong_Item_Click);
            // 
            // quan_ly_tuyen_sinh_Item
            // 
            this.quan_ly_tuyen_sinh_Item.Name = "quan_ly_tuyen_sinh_Item";
            this.quan_ly_tuyen_sinh_Item.Size = new System.Drawing.Size(194, 24);
            this.quan_ly_tuyen_sinh_Item.Text = "Quản lý tuyển sinh";
            this.quan_ly_tuyen_sinh_Item.Click += new System.EventHandler(this.quan_ly_tuyen_sinh_Item_Click);
            // 
            // gioi_thieu_Item
            // 
            this.gioi_thieu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huong_dan_su_dung_Item});
            this.gioi_thieu_Item.Name = "gioi_thieu_Item";
            this.gioi_thieu_Item.Size = new System.Drawing.Size(80, 23);
            this.gioi_thieu_Item.Text = "Giới thiệu";
            // 
            // huong_dan_su_dung_Item
            // 
            this.huong_dan_su_dung_Item.Name = "huong_dan_su_dung_Item";
            this.huong_dan_su_dung_Item.Size = new System.Drawing.Size(201, 24);
            this.huong_dan_su_dung_Item.Text = "Hướng dẫn sử dụng";
            this.huong_dan_su_dung_Item.Click += new System.EventHandler(this.huong_dan_su_dung_Item_Click);
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.tbContainer);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 35);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1274, 656);
            this.pnContainer.TabIndex = 1;
            // 
            // tbContainer
            // 
            this.tbContainer.ColumnCount = 2;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbContainer.Controls.Add(this.pnLeft, 0, 0);
            this.tbContainer.Controls.Add(this.pnRight, 1, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(0, 0);
            this.tbContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbContainer.Size = new System.Drawing.Size(1274, 656);
            this.tbContainer.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnLeft.Controls.Add(this.btnThamKhaoTinhThanh);
            this.pnLeft.Controls.Add(this.btnThamKhaoTongDiem);
            this.pnLeft.Controls.Add(this.pnInfoLeft);
            this.pnLeft.Controls.Add(this.cbThongTinThem);
            this.pnLeft.Controls.Add(this.lbThongTinThem);
            this.pnLeft.Controls.Add(this.btnLamLai);
            this.pnLeft.Controls.Add(this.btnTuVan);
            this.pnLeft.Controls.Add(this.cbKhuVuc);
            this.pnLeft.Controls.Add(this.txtTongDiem);
            this.pnLeft.Controls.Add(this.lbKhuVuc);
            this.pnLeft.Controls.Add(this.lbTongDiem);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(6, 6);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(6);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(370, 644);
            this.pnLeft.TabIndex = 0;
            // 
            // btnThamKhaoTinhThanh
            // 
            this.btnThamKhaoTinhThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThamKhaoTinhThanh.AutoSize = true;
            this.btnThamKhaoTinhThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnThamKhaoTinhThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThamKhaoTinhThanh.FlatAppearance.BorderSize = 0;
            this.btnThamKhaoTinhThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThamKhaoTinhThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThamKhaoTinhThanh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThamKhaoTinhThanh.Location = new System.Drawing.Point(263, 231);
            this.btnThamKhaoTinhThanh.Margin = new System.Windows.Forms.Padding(0);
            this.btnThamKhaoTinhThanh.Name = "btnThamKhaoTinhThanh";
            this.btnThamKhaoTinhThanh.Size = new System.Drawing.Size(93, 28);
            this.btnThamKhaoTinhThanh.TabIndex = 10;
            this.btnThamKhaoTinhThanh.Text = "Tham khảo";
            this.btnThamKhaoTinhThanh.UseVisualStyleBackColor = false;
            this.btnThamKhaoTinhThanh.Click += new System.EventHandler(this.btnThamKhaoTinhThanh_Click);
            // 
            // btnThamKhaoTongDiem
            // 
            this.btnThamKhaoTongDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThamKhaoTongDiem.AutoSize = true;
            this.btnThamKhaoTongDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnThamKhaoTongDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThamKhaoTongDiem.FlatAppearance.BorderSize = 0;
            this.btnThamKhaoTongDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThamKhaoTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThamKhaoTongDiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThamKhaoTongDiem.Location = new System.Drawing.Point(263, 146);
            this.btnThamKhaoTongDiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThamKhaoTongDiem.Name = "btnThamKhaoTongDiem";
            this.btnThamKhaoTongDiem.Size = new System.Drawing.Size(93, 28);
            this.btnThamKhaoTongDiem.TabIndex = 9;
            this.btnThamKhaoTongDiem.Text = "Tham khảo";
            this.btnThamKhaoTongDiem.UseVisualStyleBackColor = false;
            this.btnThamKhaoTongDiem.Click += new System.EventHandler(this.btnThamKhaoTongDiem_Click);
            // 
            // pnInfoLeft
            // 
            this.pnInfoLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.pnInfoLeft.Controls.Add(this.lbInfoLeft);
            this.pnInfoLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfoLeft.Location = new System.Drawing.Point(0, 0);
            this.pnInfoLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnInfoLeft.Name = "pnInfoLeft";
            this.pnInfoLeft.Size = new System.Drawing.Size(370, 35);
            this.pnInfoLeft.TabIndex = 8;
            // 
            // lbInfoLeft
            // 
            this.lbInfoLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfoLeft.AutoSize = true;
            this.lbInfoLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoLeft.Location = new System.Drawing.Point(122, 7);
            this.lbInfoLeft.Name = "lbInfoLeft";
            this.lbInfoLeft.Size = new System.Drawing.Size(127, 20);
            this.lbInfoLeft.TabIndex = 0;
            this.lbInfoLeft.Text = "Nhập thông tin";
            // 
            // cbThongTinThem
            // 
            this.cbThongTinThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbThongTinThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThongTinThem.FormattingEnabled = true;
            this.cbThongTinThem.Location = new System.Drawing.Point(29, 319);
            this.cbThongTinThem.Name = "cbThongTinThem";
            this.cbThongTinThem.Size = new System.Drawing.Size(220, 28);
            this.cbThongTinThem.TabIndex = 7;
            this.cbThongTinThem.Text = "Câu hỏi what-if";
            this.cbThongTinThem.SelectedIndexChanged += new System.EventHandler(this.cbThongTinThem_SelectedIndexChanged);
            // 
            // lbThongTinThem
            // 
            this.lbThongTinThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThongTinThem.AutoSize = true;
            this.lbThongTinThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinThem.Location = new System.Drawing.Point(25, 286);
            this.lbThongTinThem.Name = "lbThongTinThem";
            this.lbThongTinThem.Size = new System.Drawing.Size(115, 20);
            this.lbThongTinThem.TabIndex = 6;
            this.lbThongTinThem.Text = "Thông tin thêm";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLamLai.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamLai.FlatAppearance.BorderSize = 0;
            this.btnLamLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLamLai.Location = new System.Drawing.Point(199, 585);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(95, 40);
            this.btnLamLai.TabIndex = 5;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTuVan
            // 
            this.btnTuVan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTuVan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTuVan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTuVan.FlatAppearance.BorderSize = 0;
            this.btnTuVan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTuVan.Location = new System.Drawing.Point(76, 585);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(95, 40);
            this.btnTuVan.TabIndex = 4;
            this.btnTuVan.Text = "Tư vấn";
            this.btnTuVan.UseVisualStyleBackColor = false;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Items.AddRange(new object[] {
            "Miền bắc",
            "Miền trung",
            "Miền nam"});
            this.cbKhuVuc.Location = new System.Drawing.Point(29, 231);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(220, 28);
            this.cbKhuVuc.TabIndex = 3;
            this.cbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbKhuVuc_SelectedIndexChanged);
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDiem.Location = new System.Drawing.Point(29, 146);
            this.txtTongDiem.Multiline = true;
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(220, 28);
            this.txtTongDiem.TabIndex = 2;
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhuVuc.Location = new System.Drawing.Point(24, 198);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(65, 20);
            this.lbKhuVuc.TabIndex = 1;
            this.lbKhuVuc.Text = "Khu vực";
            // 
            // lbTongDiem
            // 
            this.lbTongDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongDiem.AutoSize = true;
            this.lbTongDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDiem.Location = new System.Drawing.Point(24, 113);
            this.lbTongDiem.Name = "lbTongDiem";
            this.lbTongDiem.Size = new System.Drawing.Size(83, 20);
            this.lbTongDiem.TabIndex = 0;
            this.lbTongDiem.Text = "Tổng điểm";
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.pnDetail);
            this.pnRight.Controls.Add(this.dgvResult);
            this.pnRight.Controls.Add(this.pnInfoRight);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(388, 6);
            this.pnRight.Margin = new System.Windows.Forms.Padding(6);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(880, 644);
            this.pnRight.TabIndex = 1;
            // 
            // pnDetail
            // 
            this.pnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnDetail.Controls.Add(this.lbDetailDiemChuan);
            this.pnDetail.Controls.Add(this.lbDetailNganh);
            this.pnDetail.Controls.Add(this.lbDetailTruong);
            this.pnDetail.Controls.Add(this.lbDiemChuan);
            this.pnDetail.Controls.Add(this.lbNganh);
            this.pnDetail.Controls.Add(this.lbTruong);
            this.pnDetail.Location = new System.Drawing.Point(-2, 35);
            this.pnDetail.Margin = new System.Windows.Forms.Padding(0);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(882, 263);
            this.pnDetail.TabIndex = 14;
            // 
            // lbDetailDiemChuan
            // 
            this.lbDetailDiemChuan.AutoSize = true;
            this.lbDetailDiemChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailDiemChuan.Location = new System.Drawing.Point(286, 215);
            this.lbDetailDiemChuan.Name = "lbDetailDiemChuan";
            this.lbDetailDiemChuan.Size = new System.Drawing.Size(0, 20);
            this.lbDetailDiemChuan.TabIndex = 16;
            // 
            // lbDetailNganh
            // 
            this.lbDetailNganh.AutoSize = true;
            this.lbDetailNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailNganh.Location = new System.Drawing.Point(282, 48);
            this.lbDetailNganh.Name = "lbDetailNganh";
            this.lbDetailNganh.Size = new System.Drawing.Size(0, 24);
            this.lbDetailNganh.TabIndex = 14;
            // 
            // lbDetailTruong
            // 
            this.lbDetailTruong.AutoSize = true;
            this.lbDetailTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailTruong.Location = new System.Drawing.Point(283, 133);
            this.lbDetailTruong.Name = "lbDetailTruong";
            this.lbDetailTruong.Size = new System.Drawing.Size(0, 20);
            this.lbDetailTruong.TabIndex = 15;
            // 
            // lbDiemChuan
            // 
            this.lbDiemChuan.AutoSize = true;
            this.lbDiemChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemChuan.Location = new System.Drawing.Point(146, 215);
            this.lbDiemChuan.Name = "lbDiemChuan";
            this.lbDiemChuan.Size = new System.Drawing.Size(94, 20);
            this.lbDiemChuan.TabIndex = 13;
            this.lbDiemChuan.Text = "Điểm chuẩn";
            // 
            // lbNganh
            // 
            this.lbNganh.AutoSize = true;
            this.lbNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganh.Location = new System.Drawing.Point(145, 48);
            this.lbNganh.Name = "lbNganh";
            this.lbNganh.Size = new System.Drawing.Size(72, 24);
            this.lbNganh.TabIndex = 11;
            this.lbNganh.Text = "Ngành";
            // 
            // lbTruong
            // 
            this.lbTruong.AutoSize = true;
            this.lbTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTruong.Location = new System.Drawing.Point(143, 133);
            this.lbTruong.Name = "lbTruong";
            this.lbTruong.Size = new System.Drawing.Size(59, 20);
            this.lbTruong.TabIndex = 12;
            this.lbTruong.Text = "Trường";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTruong,
            this.clTenTruong,
            this.clDiaChi,
            this.clMaNganh,
            this.clTenNganh,
            this.clDiemChuan});
            this.dgvResult.Location = new System.Drawing.Point(0, 298);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(0);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResult.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResult.Size = new System.Drawing.Size(880, 346);
            this.dgvResult.TabIndex = 10;
            this.dgvResult.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_RowEnter);
            // 
            // MaTruong
            // 
            this.MaTruong.DataPropertyName = "MaTruong";
            this.MaTruong.HeaderText = "Mã trường";
            this.MaTruong.Name = "MaTruong";
            // 
            // clTenTruong
            // 
            this.clTenTruong.DataPropertyName = "TenTruong";
            this.clTenTruong.HeaderText = "Tên trường";
            this.clTenTruong.Name = "clTenTruong";
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "DiaChi";
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            // 
            // clMaNganh
            // 
            this.clMaNganh.DataPropertyName = "MaNganh";
            this.clMaNganh.HeaderText = "Mã ngành";
            this.clMaNganh.Name = "clMaNganh";
            // 
            // clTenNganh
            // 
            this.clTenNganh.DataPropertyName = "TenChuyenNganh";
            this.clTenNganh.HeaderText = "Tên ngành";
            this.clTenNganh.Name = "clTenNganh";
            // 
            // clDiemChuan
            // 
            this.clDiemChuan.DataPropertyName = "DiemChuan";
            this.clDiemChuan.HeaderText = "Điểm chuẩn";
            this.clDiemChuan.Name = "clDiemChuan";
            // 
            // pnInfoRight
            // 
            this.pnInfoRight.BackColor = System.Drawing.Color.DarkOrange;
            this.pnInfoRight.Controls.Add(this.lbInfoRight);
            this.pnInfoRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfoRight.Location = new System.Drawing.Point(0, 0);
            this.pnInfoRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnInfoRight.Name = "pnInfoRight";
            this.pnInfoRight.Size = new System.Drawing.Size(880, 35);
            this.pnInfoRight.TabIndex = 9;
            // 
            // lbInfoRight
            // 
            this.lbInfoRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfoRight.AutoSize = true;
            this.lbInfoRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInfoRight.Location = new System.Drawing.Point(370, 7);
            this.lbInfoRight.Name = "lbInfoRight";
            this.lbInfoRight.Size = new System.Drawing.Size(140, 20);
            this.lbInfoRight.TabIndex = 0;
            this.lbInfoRight.Text = "Bảng tham khảo";
            // 
            // tu_van_Item
            // 
            this.tu_van_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diem_thi_Item,
            this.khu_vuc_Item});
            this.tu_van_Item.Name = "tu_van_Item";
            this.tu_van_Item.Size = new System.Drawing.Size(62, 23);
            this.tu_van_Item.Text = "Tư vấn";
            // 
            // diem_thi_Item
            // 
            this.diem_thi_Item.Name = "diem_thi_Item";
            this.diem_thi_Item.Size = new System.Drawing.Size(152, 24);
            this.diem_thi_Item.Text = "Điểm thi";
            this.diem_thi_Item.Click += new System.EventHandler(this.diem_thi_Item_Click);
            // 
            // khu_vuc_Item
            // 
            this.khu_vuc_Item.Name = "khu_vuc_Item";
            this.khu_vuc_Item.Size = new System.Drawing.Size(152, 24);
            this.khu_vuc_Item.Text = "Khu vực";
            this.khu_vuc_Item.Click += new System.EventHandler(this.khu_vuc_Item_Click);
            // 
            // frmTuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.toolbar;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmTuVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tư vấn";
            this.Load += new System.EventHandler(this.TuVan_Load);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.pnContainer.ResumeLayout(false);
            this.tbContainer.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            this.pnInfoLeft.ResumeLayout(false);
            this.pnInfoLeft.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.pnInfoRight.ResumeLayout(false);
            this.pnInfoRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolbar;
        private System.Windows.Forms.ToolStripMenuItem thong_tin_Item;
        private System.Windows.Forms.ToolStripMenuItem thong_tin_truong_Item;
        private System.Windows.Forms.ToolStripMenuItem thong_tin_tuyen_sinh_Item;
        private System.Windows.Forms.ToolStripMenuItem quan_ly_Item;
        private System.Windows.Forms.ToolStripMenuItem quan_ly_truong_Item;
        private System.Windows.Forms.ToolStripMenuItem quan_ly_tuyen_sinh_Item;
        private System.Windows.Forms.ToolStripMenuItem gioi_thieu_Item;
        private System.Windows.Forms.ToolStripMenuItem huong_dan_su_dung_Item;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.TableLayoutPanel tbContainer;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Label lbTongDiem;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.ComboBox cbThongTinThem;
        private System.Windows.Forms.Label lbThongTinThem;
        private System.Windows.Forms.Panel pnInfoLeft;
        private System.Windows.Forms.Label lbInfoLeft;
        private System.Windows.Forms.Panel pnInfoRight;
        private System.Windows.Forms.Label lbInfoRight;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lbDiemChuan;
        private System.Windows.Forms.Label lbTruong;
        private System.Windows.Forms.Label lbNganh;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.Label lbDetailDiemChuan;
        private System.Windows.Forms.Label lbDetailNganh;
        private System.Windows.Forms.Label lbDetailTruong;
        private System.Windows.Forms.Button btnThamKhaoTongDiem;
        private System.Windows.Forms.Button btnThamKhaoTinhThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemChuan;
        private System.Windows.Forms.ToolStripMenuItem tu_van_Item;
        private System.Windows.Forms.ToolStripMenuItem diem_thi_Item;
        private System.Windows.Forms.ToolStripMenuItem khu_vuc_Item;

    }
}