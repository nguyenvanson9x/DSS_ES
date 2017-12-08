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
    public partial class frmThongTinTruong : Form
    {
        public frmThongTinTruong()
        {
            InitializeComponent();
        }

        BUS_Truong bus = new BUS_Truong();
        string sql = "select truong.MaTruong, truong.TenTruong, truong.DiaChi, truong.Website from truong";

        private void frmThongTinTruong_Load(object sender, EventArgs e)
        {
            bus.myconnect();
            dgvResult.DataSource = bus.getTruong(sql);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            bus.myclose();
        }
    }
}
