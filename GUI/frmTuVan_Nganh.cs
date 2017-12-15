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
            try
            {
                if (txtTongDiem.Text == "")
                {
                    MessageBox.Show(this, "Vui lòng nhập tổng điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frm.TongDiem = Double.Parse(txtTongDiem.Text);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Chỉ được nhập số", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTinhThanh_Click(object sender, EventArgs e)
        {
            frmDanhSachNganh frm = new frmDanhSachNganh();
            frm.selected = 2;
            if (cbTinhThanh.Text == "")
            {
                MessageBox.Show(this, "Vui lòng chọn tên tỉnh thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                if (cbTinhThanh.Text == "" || txtTongDiem.Text == "")
                {
                    MessageBox.Show(this, "Vui lòng không để trống dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frm.TongDiem = Double.Parse(txtTongDiem.Text);
                    frm.KhuVuc = cbTinhThanh.Text;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Chỉ được nhập số", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content =
                "- Nhập tổng điểm, bấm vào nút Tham Khảo để xem danh sách các ngành có số điểm phù hợp.\r\n\r\n"
                + "- Lựa chọn Tỉnh/TP, bấm vào nút Tham khảo để xem danh sách các ngành phù hợp.\r\n\r\n"
                + "- Bấm vào nút Tư vấn để xem danh sách các ngành phù hợp với cả hai tiêu chí Tổng điểm và Tỉnh/TP.\r\n\r\n"
                ;
            frm.ShowDialog();
        }

        private void frmTuVan_Nganh_Load(object sender, EventArgs e)
        {
            try
            {
                bus.myconnect();

                string sqlTinhThanh = "select distinct truong.TinhThanh from truong";
                cbTinhThanh.DataSource = bus.getTruong(sqlTinhThanh);
                cbTinhThanh.DisplayMember = "TinhThanh";
                cbTinhThanh.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
