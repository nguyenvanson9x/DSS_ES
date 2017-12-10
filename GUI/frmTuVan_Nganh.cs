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
    public partial class frmTuVan_Nganh : Form
    {
        public frmTuVan_Nganh()
        {
            InitializeComponent();
        }
        BUS_Truong bus = new BUS_Truong();
        private void btnTongDiem_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 1;
            if (txtTongDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tổng điểm");
            }
            else {
                frm.TongDiem = Int32.Parse(txtTongDiem.Text);
                frm.ShowDialog();
            }
        }

        private void btnTinhThanh_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 2;
            if (cbTinhThanh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tên tỉnh thành");
            }
            else
            {
                frm.KhuVuc = cbTinhThanh.Text;
                frm.ShowDialog(); 
            }
            
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 3;
            if (cbTinhThanh.Text == ""||txtTongDiem.Text=="")
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu");
            }
            else
            {
                frm.TongDiem = Int32.Parse(txtTongDiem.Text);
                frm.KhuVuc = cbTinhThanh.Text;
                frm.ShowDialog();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content = "Line 1\r\nLine 2\r\nLine 3";
            frm.ShowDialog();
        }

        private void frmTuVan_Nganh_Load(object sender, EventArgs e)
        {
            bus.myconnect();

            string sqlTinhThanh = "select distinct truong.TinhThanh from truong";
            cbTinhThanh.DataSource = bus.getTruong(sqlTinhThanh);
            cbTinhThanh.DisplayMember = "TinhThanh";
            cbTinhThanh.SelectedIndex = -1;
        }

    }
}
