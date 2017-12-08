namespace GUI
{
    partial class frmThongTinTuyenSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.tbContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.clMaTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLDaTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnContainer.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.White;
            this.pnContainer.Controls.Add(this.tbContainer);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(954, 511);
            this.pnContainer.TabIndex = 0;
            // 
            // tbContainer
            // 
            this.tbContainer.ColumnCount = 1;
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbContainer.Controls.Add(this.pnLeft, 0, 0);
            this.tbContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContainer.Location = new System.Drawing.Point(0, 0);
            this.tbContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainer.Name = "tbContainer";
            this.tbContainer.RowCount = 1;
            this.tbContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbContainer.Size = new System.Drawing.Size(954, 511);
            this.tbContainer.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnLeft.Controls.Add(this.btnTimKiem);
            this.pnLeft.Controls.Add(this.txtTimKiem);
            this.pnLeft.Controls.Add(this.dgvInfo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(952, 511);
            this.pnLeft.TabIndex = 0;
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.ColumnHeadersHeight = 26;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaTruong,
            this.clMaNganh,
            this.clDiemChuan,
            this.clChiTieu,
            this.clSLDaTuyen});
            this.dgvInfo.Location = new System.Drawing.Point(0, 105);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfo.ShowEditingIcon = false;
            this.dgvInfo.Size = new System.Drawing.Size(952, 406);
            this.dgvInfo.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(617, 32);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 28);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(835, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // clMaTruong
            // 
            this.clMaTruong.DataPropertyName = "MaTruong";
            this.clMaTruong.HeaderText = "Mã trường";
            this.clMaTruong.Name = "clMaTruong";
            this.clMaTruong.ReadOnly = true;
            // 
            // clMaNganh
            // 
            this.clMaNganh.DataPropertyName = "MaNganh";
            this.clMaNganh.HeaderText = "Mã ngành";
            this.clMaNganh.Name = "clMaNganh";
            this.clMaNganh.ReadOnly = true;
            // 
            // clDiemChuan
            // 
            this.clDiemChuan.DataPropertyName = "DiemChuan";
            this.clDiemChuan.HeaderText = "Điểm chuẩn";
            this.clDiemChuan.Name = "clDiemChuan";
            this.clDiemChuan.ReadOnly = true;
            // 
            // clChiTieu
            // 
            this.clChiTieu.DataPropertyName = "ChiTieu";
            this.clChiTieu.HeaderText = "Chỉ tiêu";
            this.clChiTieu.Name = "clChiTieu";
            this.clChiTieu.ReadOnly = true;
            // 
            // clSLDaTuyen
            // 
            this.clSLDaTuyen.DataPropertyName = "SLDaTuyen";
            this.clSLDaTuyen.HeaderText = "Số lượng đã tuyển";
            this.clSLDaTuyen.Name = "clSLDaTuyen";
            this.clSLDaTuyen.ReadOnly = true;
            // 
            // frmThongTinTuyenSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 511);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmThongTinTuyenSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tuyển sinh";
            this.Load += new System.EventHandler(this.frmThongTinTuyenSinh_Load);
            this.pnContainer.ResumeLayout(false);
            this.tbContainer.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.TableLayoutPanel tbContainer;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemChuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLDaTuyen;

    }
}