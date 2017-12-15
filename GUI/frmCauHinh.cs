using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class frmCauHinh : Form
    {
        //private DBConnect db = new DBConnect();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DBConnect.EditAppSetting("datasource", txtMayChu.Text);
            DBConnect.EditAppSetting("database", txtCSDL.Text);
            DBConnect.EditAppSetting("username", txtUsername.Text);
            DBConnect.EditAppSetting("password", txtPassword.Text);
            MessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "Hướng dẫn cấu hình hệ thống";
            string l1 = "Dùng chức năng này khi bị lỗi kết nối với cơ sở dữ liệu.\r\n\r\n";
            string l2 = "- Nhập các thông số kết nối:\r\n";
            string l3 = "   + Máy chủ:\tTên máy chủ quản lý cơ sở dữ liệu.\r\n";
            string l4 = "   + Cơ sở dữ liệu:\tTên cơ sở dữ liệu.\r\n";
            string l5 = "   + Tên đăng nhập:\tTài khoản kết nối tới cơ sở dữ liệu.\r\n";
            string l6 = "   + Mật khẩu:\tMật khẩu truy cập cơ sở dữ liệu.\r\n\r\n";
            string l7 = "- Nhấn nút Lưu để lưu các thông số.\r\n";
            frm.content = l1 + l2 + l3 + l4 + l5 + l6 + l7;
            frm.ShowDialog();
        }
    }
}
