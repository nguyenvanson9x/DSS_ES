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
        private BUS_TuyenSinh bus;

        public frmQuanLyTuyenSinh()
        {
            bus = new BUS_TuyenSinh();
            InitializeComponent();
        }

        private void frmQuanLyTuyenSinh_Load(object sender, EventArgs e)
        {
            dgvInfo.DataSource = bus.getTuyenSinh();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bus.themTuyenSinh(get_data());
            dgvInfo.DataSource = bus.getTuyenSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bus.suaTuyenSinh(get_data());
            dgvInfo.DataSource = bus.getTuyenSinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma_truong = get_data().MaTruong;
            bus.xoaTuyenSinh(ma_truong);
            dgvInfo.DataSource = bus.getTuyenSinh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTruong.Clear();
            txtMaNganh.Clear();
            txtChiTieu.Clear();
            txtDiemChuan.Clear();
            txtSLDaTuyen.Clear();
        }

        private DTO_TuyenSinh get_data()
        {
            DTO_TuyenSinh obj = new DTO_TuyenSinh();
            obj.MaTruong = txtMaTruong.Text;
            obj.MaNganh = txtMaNganh.Text;
            obj.DiemChuan = Double.Parse(txtDiemChuan.Text);
            obj.ChiTieu = Int32.Parse(txtChiTieu.Text);
            obj.SLDaTuyen = Int32.Parse(txtSLDaTuyen.Text);
            return obj;
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvInfo.DataSource;
            chiso = dgvInfo.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];

            txtMaTruong.Text = hang["MaTruong"].ToString();
            txtMaNganh.Text = hang["MaNganh"].ToString();
            txtDiemChuan.Text = hang["DiemChuan"].ToString();
            txtChiTieu.Text = hang["ChiTieu"].ToString();
            txtSLDaTuyen.Text = hang["SLDaTuyen"].ToString();
        }
    }
}
