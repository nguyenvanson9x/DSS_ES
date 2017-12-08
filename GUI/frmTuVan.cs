using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmTuVan : Form
    {
        public frmTuVan()
        {
            InitializeComponent();
        }

        private void thong_tin_truong_Item_Click(object sender, EventArgs e)
        {
            frmThongTinTruong frm = new frmThongTinTruong();
            frm.ShowDialog();
        }

        private void thong_tin_tuyen_sinh_Item_Click(object sender, EventArgs e)
        {
            frmThongTinTuyenSinh frm = new frmThongTinTuyenSinh();
            frm.ShowDialog();
        }

        private void quan_ly_truong_Item_Click(object sender, EventArgs e)
        {
            frmQuanLyTruong frm = new frmQuanLyTruong();
            frm.ShowDialog();
        }

        private void quan_ly_tuyen_sinh_Item_Click(object sender, EventArgs e)
        {
            frmQuanLyTuyenSinh frm = new frmQuanLyTuyenSinh();
            frm.ShowDialog();
        }

        private void huong_dan_su_dung_Item_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.ShowDialog();
        }

        private void btnThamKhaoTongDiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tham khảo tổng điểm");
        }

        private void btnThamKhaoTinhThanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tham khảo tỉnh thành");
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbThongTinThem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tư vấn");
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Làm lại");
        }

        private void TuVan_Load(object sender, EventArgs e)
        {
            BUS_TuVan bus = new BUS_TuVan();
            dgvResult.DataSource = bus.getTuVan();
            dgvResult.Rows[0].Selected = true;
        }

        private void dgvResult_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = e.RowIndex;
            if (chiso > 0)
            {
                DataTable bang = new DataTable();
                bang = (DataTable)dgvResult.DataSource;
                chiso = dgvResult.SelectedCells[0].RowIndex;
                DataRow hang = bang.Rows[chiso];

                lbDetailNganh.Text = hang["TenChuyenNganh"].ToString();
                lbDetailTruong.Text = hang["TenTruong"].ToString();
                lbDetailDiemChuan.Text = hang["DiemChuan"].ToString();
            }
        }

        private void diem_thi_Item_Click(object sender, EventArgs e)
        {

        }

        private void khu_vuc_Item_Click(object sender, EventArgs e)
        {

        }
    }
}
