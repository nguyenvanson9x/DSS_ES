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
        private BindingSource source1 = new BindingSource();
        public frmDiemChuan()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string truong = txtSearch.Text;
                string tinh = cbTinh.GetItemText(cbTinh.SelectedItem);
                List<string> list = bus.searchListTruong(truong, tinh);
                listTruong.Items.Clear();
                foreach (string li in list)
                {
                    listTruong.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtSearch.ResetText();
            cbTinh.ResetText();
            cbTinh.SelectedText = "--Tỉnh / TP--";
        }

        private void frmDiemChuan_Load(object sender, EventArgs e)
        {
            try
            {
                getListTruong();
                getListTinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "Cách xem điểm chuẩn ngành CNTT của các trường ĐH năm 2017";
            string text1 = "Cách 1: Tìm kiếm theo tên trường đại học:\r\n\t- Nhập tên trường cần tìm kiếm vào ô 'Chọn trường'.\r\n\t- Nhấn 'Tìm Kiếm' để hiển thị kết quả.\r\n\t- Kích chọn Trường cần xem để xem chi tiết.\r\n";
            string text2 = "Cách 2: Tìm kiếm theo tỉnh thành:\r\n\t- Chọn tỉnh thành cần tìm ở mục 'Tìm kiếm theo tỉnh thành'\r\n\t- Nhấn 'Tìm Kiếm' để hiển thị kết quả.\r\n\t- Kích chọn Trường cần xem để xem chi tiết.\r\n";
            frm.content =text1+text2;
            frm.ShowDialog();
        }
        private void getListTruong()
        {
            try
            {
                List<string> list = bus.getListTruong();
                foreach (string li in list)
                {
                    listTruong.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                "and (chuyennganh.MaNganh = tuyensinh.MaNganh) and (truong.MaTruong='"+matruong+"')"
                ;
            try
            {
                dgv.DataSource = bus.getTruong(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (String.Compare(text, String.Format("Không theo thứ tự ABC"))==0)
            {
                Array.Reverse(arr);
            }
            else
            {
                Array.Sort(arr);
            }
            listTruong.Items.Clear();
            foreach (string s in arr)
            {
                listTruong.Items.Add(s);
            }
        }

        private void getListTinh()
        {
            try
            {
                List<string> list = bus.getListTinh();
                foreach (string li in list)
                {
                    cbTinh.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtChanged(object sender, EventArgs e)
        {
            try
            {
                string truong = txtSearch.Text;
                string tinh = cbTinh.Text;
                List<string> list = bus.searchListTruong(truong, tinh);
                listTruong.Items.Clear();
                foreach (string li in list)
                {
                    listTruong.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTinhChanged(object sender, EventArgs e)
        {
            try
            {
                string truong = txtSearch.Text;
                string tinh = cbTinh.GetItemText(cbTinh.SelectedItem);
                List<string> list = bus.searchListTruong(truong, tinh);
                listTruong.Items.Clear();
                foreach (string li in list)
                {
                    listTruong.Items.Add(li);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
