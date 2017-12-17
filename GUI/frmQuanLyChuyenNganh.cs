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
    public partial class frmQuanLyChuyenNganh : Form
    {
        private BUS_NhomNganh bus = new BUS_NhomNganh();
        private string ma_nhom_nganh = "";
        public frmQuanLyChuyenNganh()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string ten_nhom_nganh = txtChuyenNganh.Text;
            try
            {
                if (!bus.add(ten_nhom_nganh))
                    MessageBox.Show(this, "Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_data();
        }

        private void frmQuanLyChuyenNganh_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Int32.Parse(ma_nhom_nganh);
                if (!bus.edit(id, txtChuyenNganh.Text))
                    MessageBox.Show(this, "Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_data();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(ma_nhom_nganh);
                if (!bus.delete(id))
                    MessageBox.Show(this, "Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            load_data();
        }

        private void dgvResult_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (!(index < 0))
            {
                DataGridViewRow row = dgvResult.Rows[index];

                txtChuyenNganh.Text = row.Cells["TenChuyenNganh"].Value.ToString();
                ma_nhom_nganh = row.Cells["NhomNganh"].Value.ToString();
            }
        }

        private void load_data()
        {
            try
            {
                dgvResult.DataSource = bus.getNhomNganh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txtChuyenNganh.Clear();
        }
    }
}
