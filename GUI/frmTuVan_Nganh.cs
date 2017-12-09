using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTuVan_Nganh : Form
    {
        public frmTuVan_Nganh()
        {
            InitializeComponent();
        }

        private void btnTongDiem_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 1;
            if (!txtTongDiem.Text.Equals(""))
                frm.TongDiem = Int32.Parse(txtTongDiem.Text);
            frm.ShowDialog();
        }

        private void btnTinhThanh_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 2;
            frm.KhuVuc = cbTinhThanh.SelectedItem.ToString();
            frm.ShowDialog();
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 3;
            frm.ShowDialog();
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

        }
    }
}
