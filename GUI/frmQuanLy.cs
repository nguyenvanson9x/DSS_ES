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
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void btnTruong_Click(object sender, EventArgs e)
        {
            change_color(btnTruong);
            frmQuanLyTruong frm = new frmQuanLyTruong();
            add_form_to_panel(frm);
        }

        private void btnTuyenSinh_Click(object sender, EventArgs e)
        {
            change_color(btnTuyenSinh);
            frmQuanLyTuyenSinh frm = new frmQuanLyTuyenSinh();
            add_form_to_panel(frm);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "Quản lý nhập liệu thông tin trường và thông tin tuyển sinh";
            frm.content =
                "- Bấm vào nút Thông tin trường để quản lý thông tin của các trường đại học.\r\n"
                + "\t+ Bấm vào 1 dòng trong bảng dữ liệu để hiển thị chi tiết Trường.\r\n"
                + "\t+ Bấm vào các nút Sửa, Xóa để cập nhật hoặc xóa dữ liệu của trường đó.\r\n\r\n"
                + "- Bấm vào nút Thông tin tuyển sinh để quản lý thông tin tuyển sinh đại học của các trường đại học.\r\n"
                + "\t+ Bấm vào 1 dòng trong bảng dữ liệu để hiện thị chi tiết thông tin tuyển sinh\r\n"
                + "\t+ Bấm vào nút Sửa, Xóa, Hủy để cập nhật, xóa dòng đã chọn\r\n"
                + "\t+ Tìm kiếm dữ liệu: Hỗ trợ tìm kiếm theo tên trường, mã trường, mã ngành, tên ngành, điểm chuẩn, chỉ tiêu\r\n\r\n"
                + "- Bấm vào nút Thêm dữ liệu để tiến hành nhập liệu thông tin.\r\n"
                + "\t+ Bấm vào nút Thêm thủ công để nhập dữ liệu bằng tay.\r\n"
                + "\t\t+ Sau khi nhập dữ liệu, bấm nút Lưu để lưu dữ liệu.\r\n"
                + "\t+ Bấm vào nút Nhập Excel để nhập dữ liệu từ tệp excel.\r\n"
                ;
            frm.ShowDialog();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            btnThemDuLieu_Click(sender, e);
        }

        private void add_form_to_panel(Form f)
        {
            // Do not modify this function
            this.pnSubSystem.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnSubSystem.Controls.Add(f);
            f.Show();
        }

        private void change_color(Button btn)
        {
            // Do not modify this function
            int r_default = 79, g_default = 195, b_default = 247;
            int r_click = 3, g_click = 169, b_click = 244;
            //normal: 79, 195, 247
            // click: 3, 169, 244
            foreach (Control button in this.tbButton.Controls)
            {
                if (button is Button)
                {
                    if (button.Name.Equals(btn.Name))
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r_click)))), ((int)(((byte)(g_click)))), ((int)(((byte)(b_click)))));
                        button.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        button.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r_default)))), ((int)(((byte)(g_default)))), ((int)(((byte)(b_default)))));
                        button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        button.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            change_color(btnThemDuLieu);
            frmThemDuLieu frm = new frmThemDuLieu();
            add_form_to_panel(frm);
        }

        private void btnChuyenNganh_Click(object sender, EventArgs e)
        {
            change_color(btnChuyenNganh);
            frmQuanLyChuyenNganh frm = new frmQuanLyChuyenNganh();
            add_form_to_panel(frm);
        }
    }
}
