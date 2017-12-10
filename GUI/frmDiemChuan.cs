using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;
namespace GUI
{
    public partial class frmDiemChuan : Form
    {
        private BUS_Truong bus = new BUS_Truong();
        public frmDiemChuan()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string truong = txtSearch.Text;
            string tinh = cbTinh.GetItemText(cbTinh.SelectedItem);
            string SQL = "";
            if (String.Compare(truong, "") != 0 && tinh != "--Tỉnh / TP--")
            {
                SQL = String.Format("Select TenTruong From Truong Where (TenTruong LIKE N'%" + truong + "') AND (TinhThanh=N'" + tinh + "');");
            }
            else if (String.Compare(truong, "") == 0 && tinh != "--Tỉnh / TP--")
            {
                SQL = String.Format("Select TenTruong From Truong Where TinhThanh=N'" + tinh + "';");
            }
            else if (String.Compare(truong, "") != 0 && tinh == "--Tỉnh / TP--")
            {
                SQL = String.Format("Select TenTruong From Truong Where TenTruong LIKE N'%" + truong + "';");
            }
            else
            {
                SQL = String.Format("Select TenTruong From Truong ORDER BY TenTruong ;");
            }
            listTruong.DataSource = bus.getTruong(SQL);
            listTruong.DisplayMember = "TenTruong";
            listTruong.SelectedIndex = -1;
            txtSearch.ResetText();
            cbTinh.ResetText();
            cbTinh.SelectedText = "--Tỉnh / TP--";
        }

        private void frmDiemChuan_Load(object sender, EventArgs e)
        {
            getListTruong("");
            getListTinh();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content = "Line 1\r\nLine 2\r\nLine 3\r";
            frm.ShowDialog();
        }
        private void getListTruong(string value)
        {
            string SQL = "";
            if (String.Compare(value, String.Format("Không theo thứ tự ABC")) == 0)
            {
                SQL = String.Format("Select TenTruong AS Name From Truong ORDER BY TenTruong DESC;");
            }
            else
            {
                SQL = String.Format("Select TenTruong AS Name From Truong ORDER BY TenTruong ;");
            }
            listTruong.DataSource = bus.getTruong(SQL);
            listTruong.DisplayMember = "TenTruong";
            listTruong.ValueMember = "Name";
            listTruong.SelectedIndex = -1;
        }

        private void listTruongClick(object sender, EventArgs e)
        {
            lbName.Text = listTruong.GetItemText(listTruong.SelectedItem);
            string matruong = bus.getDataCol(listTruong.GetItemText(listTruong.SelectedItem));
            string sql = "select  tuyensinh.MaNganh,NhomNganh.TenChuyenNganh" +
                ", tuyensinh.DiemChuan " +
                "from tuyensinh, truong, NhomNganh, chuyennganh " +
                "where (tuyensinh.MaTruong = truong.MaTruong) " +
                "and (NhomNganh.NhomNganh = chuyennganh.NhomNganh) " +
                "and (chuyennganh.MaNganh = tuyensinh.MaNganh) and (truong.MaTruong='" + matruong + "')"
                ;

            dgv.DataSource = bus.getTruong(sql);
        }

        private void cbSortClick(object sender, EventArgs e)
        {
            string text = cbSort.SelectedItem.ToString();
            getListTruong(text);
        }
        private void getListTinh()
        {
            string SQL = "Select DISTINCT TinhThanh From Truong";
            cbTinh.DataSource = bus.getTruong(SQL);
            cbTinh.DisplayMember = "TinhThanh";
            cbTinh.SelectedIndex = -1;
            cbTinh.SelectedText = "--Tỉnh / TP--";
        }

    }
}
