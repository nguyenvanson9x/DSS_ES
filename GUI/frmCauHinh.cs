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
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "Hướng dẫn cấu hình hệ thống";
            frm.content = "Line 1\r\nLine 2\r\nLine 3";
            frm.ShowDialog();
        }
    }
}
