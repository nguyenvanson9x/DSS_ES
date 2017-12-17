using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmQuanLyTuyenSinh : Form
    {
        BUS_TuyenSinh bus;
        BUS_Truong busTr;
        private string current_Manganh = "", current_TenTruong = "", current_TenNganh="";
        public frmQuanLyTuyenSinh()
        {
            bus = new BUS_TuyenSinh();
            busTr = new BUS_Truong();
            InitializeComponent();
        }

        private void frmQuanLyTuyenSinh_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfo.DataSource = bus.getTuyenSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtTimKiem.Text;
                dgvInfo.DataSource = bus.search(text);
                txtTimKiem.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tentruong = txtTenTruong.Text;
            string matruong = txtTenNganh.Text;
            string manganh = txtMaNganh.Text;
            string sql = String.Format("SELECT * FROM Truong,TruongNganh,ChuyenNganh,TuyenSinh WHERE Truong.MaTruong=TruongNganh.MaTruong AND Truong.MaTruong=TuyenSinh.MaTruong AND TruongNganh.MaNganh=ChuyenNganh.MaNganh AND TruongNganh.MaNganh=TuyenSinh.MaNganh AND TuyenSinh.MaTruong=N'"+matruong+"' AND TuyenSinh.MaTruong=N'"+manganh+"'");
            try
            {
                bool isAdd = bus.excuteSQL(sql);
                if (matruong == "" || tentruong == "" || manganh == "" || txtChiTieu.Text == "" || txtDiemChuan.Text == "" || txtSLDaTuyen.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (isAdd)
                    {
                        int chitieu = Convert.ToInt32(txtChiTieu.Text);
                        double diemchuan = Convert.ToDouble(txtDiemChuan.Text);
                        int sldatuyen = Convert.ToInt32(txtSLDaTuyen.Text);
                        DTO_TuyenSinh ts = new DTO_TuyenSinh(matruong, manganh, diemchuan, chitieu, sldatuyen);
                        busTr.them(matruong, tentruong, "", "");
                        bus.themTuyenSinh(ts);
                    }
                    else
                    {
                        MessageBox.Show("Trường đã tồn tại trên hệ thống, Xin Cảm Ơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tentruong = txtTenTruong.Text;
                string matruong = bus.getMaTruong(current_TenTruong);
                string manganh = txtMaNganh.Text;
                string tenganh = txtTenNganh.Text;
                int group = bus.getGroup(current_TenNganh);
                if (tenganh == "" || tentruong == "" || manganh == "" || txtChiTieu.Text == "" || txtDiemChuan.Text == "" || txtSLDaTuyen.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int chitieu = Convert.ToInt32(txtChiTieu.Text);
                    double diemchuan = Convert.ToDouble(txtDiemChuan.Text);
                    int sldatuyen = Convert.ToInt32(txtSLDaTuyen.Text);
                    DTO_TuyenSinh ts = new DTO_TuyenSinh(matruong, manganh, diemchuan, chitieu, sldatuyen);
                    bus.suaTuyenSinh(ts,tentruong,matruong,current_Manganh,group,tenganh);
                }
                dgvInfo.DataSource = bus.getTuyenSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string matruong = bus.getMaTruong(txtTenTruong.Text);
                bus.xoaTuyenSinh(matruong, txtMaNganh.Text);
                dgvInfo.DataSource = bus.getTuyenSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtChiTieu.ResetText();
            txtDiemChuan.ResetText();
            txtMaNganh.ResetText();
            txtTenNganh.ResetText();
            txtSLDaTuyen.ResetText();
            txtTenTruong.ResetText();
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (!(index <0))
            {
                DataGridViewRow row = dgvInfo.Rows[index];
                
                current_TenTruong = row.Cells["clTenTruong"].Value.ToString();
                current_TenNganh = row.Cells["clTenNganh"].Value.ToString();
                 current_Manganh= row.Cells["clMaNganh"].Value.ToString();
                txtChiTieu.Text = row.Cells["clChiTieu"].Value.ToString();
                txtDiemChuan.Text = row.Cells["clDiemChuan"].Value.ToString();
                txtSLDaTuyen.Text = row.Cells["clSLDaTuyen"].Value.ToString();
                txtTenTruong.Text = current_TenTruong;
                txtTenNganh.Text = current_TenNganh;
                txtMaNganh.Text = current_Manganh;
            }
            dgvInfo.Focus();
        }

        private void txtSearchChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtTimKiem.Text;
                dgvInfo.DataSource = bus.search(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInfo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvInfo_CellContentClick(sender, e);
        }

    }
}
