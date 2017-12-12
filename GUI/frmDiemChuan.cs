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
            List<string> list = bus.searchListTruong(truong, tinh);
            listTruong.Items.Clear();
            foreach (string li in list)
            {
                listTruong.Items.Add(li);
            }

            txtSearch.ResetText();
            cbTinh.ResetText();
            cbTinh.SelectedText = "--Tỉnh / TP--";
        }

        private void frmDiemChuan_Load(object sender, EventArgs e)
        {
            getListTruong();
            getListTinh();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content = "Line 1\r\nLine 2\r\nLine 3\r";
            frm.ShowDialog();
        }
        private void getListTruong()
        {
            List<string> list = bus.getListTruong();
            foreach (string li in list)
            {
                listTruong.Items.Add(li);
            }
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
            int num_items = listTruong.Items.Count;
            string[] arr = new string[num_items];
            for (int i = 0; i < num_items; i++)
            {
                arr[i] = listTruong.Items[i].ToString();
            }
            if (String.Compare(text, String.Format("Không theo thứ tự ABC")) == 0)
            {
                Array.Sort(arr);
            }
            else
            {
                Array.Reverse(arr);
            }
            listTruong.Items.Clear();
            foreach (string s in arr)
            {
                listTruong.Items.Add(s);
            }
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
