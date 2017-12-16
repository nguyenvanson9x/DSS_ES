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
    public partial class frmQuanLyTruong : Form
    {
        private string _ma_truong = "";
        public frmQuanLyTruong()
        {
            InitializeComponent();
        }

        BUS_Truong bus = new BUS_Truong();
        string sql = "select truong.MaTruong, truong.TenTruong, truong.DiaChi, truong.Website from truong";

        private void frmQuanLyTruong_Load(object sender, EventArgs e)
        {
            try
            {
                bus.myconnect();
                dgvResult.DataSource = bus.getTruong(sql);
            }
            catch(Exception ex) {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data(){
            dgvResult.DataSource = bus.getTruong(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string s = "select * from truong where MaTruong = '" + txtMaTruong.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = bus.getTruong(s);
                if (dt.Rows.Count == 0)
                {
                    bus.them(txtMaTruong.Text, txtTenTruong.Text, txtDiaChi.Text, txtWebsite.Text);

                    txtMaTruong.ResetText();
                    txtTenTruong.ResetText();
                    txtDiaChi.ResetText();
                    txtWebsite.ResetText();
                    txtMaTruong.Focus();
                }
                else
                {
                    MessageBox.Show("Mã trường đã có, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string s = "select * from truong where MaTruong = '" + _ma_truong + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = bus.getTruong(s);
                if (dt.Rows.Count > 0)
                {
                    bus.sua(_ma_truong, txtMaTruong.Text, txtTenTruong.Text, txtDiaChi.Text, txtWebsite.Text);

                    txtMaTruong.ResetText();
                    txtTenTruong.ResetText();
                    txtDiaChi.ResetText();
                    txtWebsite.ResetText();
                    txtMaTruong.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string s = "select * from truong where MaTruong = '" + txtMaTruong.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = bus.getTruong(s);
                if (dt.Rows.Count != 0)
                {
                    bus.xoa(txtMaTruong.Text);

                    txtMaTruong.ResetText();
                    txtTenTruong.ResetText();
                    txtDiaChi.ResetText();
                    txtWebsite.ResetText();
                    txtMaTruong.Focus();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dữ liệu để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            bus.myclose();
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvResult.DataSource;
            chiso = dgvResult.SelectedCells[0].RowIndex;
            if (chiso >= 0)
            {
                DataRow hang = bang.Rows[chiso];
                txtMaTruong.Text = hang["MaTruong"].ToString();
                txtTenTruong.Text = hang["TenTruong"].ToString();
                txtDiaChi.Text = hang["DiaChi"].ToString();
                txtWebsite.Text = hang["Website"].ToString();

                _ma_truong = hang["MaTruong"].ToString();
            }
        }
    }
}
