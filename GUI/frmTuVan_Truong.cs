using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmTuVan_Truong : Form
    {
        public frmTuVan_Truong()
        {
            InitializeComponent();
        }

        BUS_Truong bus = new BUS_Truong();
        string sql = "select truong.MaTruong, truong.TenTruong, truong.DiaChi, truong.Website from truong";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlTuVanTruong = bus.queryTruong(cbChuyenNganh.Text, txtTongDiem.Text, cbTinhThanh.Text);
            frmDanhSachTruong frm = new frmDanhSachTruong(sqlTuVanTruong);
            frm.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string ChuyenNganh = cbChuyenNganh.Text;
            string TinhThanh = cbChuyenNganh.Text;
            string TongDiem = txtTongDiem.Text;

            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content = 
                "Lựa chọn Chuyên ngành, Tỉnh thành và Nhập tổng điểm.\r\n\r\n" + 
                "Bấm vào nút Tìm trường để xem danh sách các trường phù hợp.\r\n"
                ;
            frm.ShowDialog();
        }

        private void frmTuVan_Truong_Load(object sender, EventArgs e)
        {
            bus.myconnect();

            string sqlChuyenNganh = "select nhomnganh.TenChuyenNganh from nhomnganh";
            cbChuyenNganh.DataSource = bus.getTruong(sqlChuyenNganh);
            cbChuyenNganh.DisplayMember = "TenChuyenNganh";
            cbChuyenNganh.SelectedIndex = -1;

            string sqlTinhThanh = "select distinct truong.TinhThanh from truong";
            cbTinhThanh.DataSource = bus.getTruong(sqlTinhThanh);
            cbTinhThanh.DisplayMember = "TinhThanh";
            cbTinhThanh.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbTinhThanh.SelectedIndex = -1;
            txtTongDiem.ResetText();
            cbChuyenNganh.SelectedIndex = -1;
        }
    }
}
