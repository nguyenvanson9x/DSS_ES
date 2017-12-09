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
    public partial class frmDanhSachNganh : Form
    {
        public int selected = 1;
        public int TongDiem = 0;
        public string KhuVuc = "";

        public frmDanhSachNganh()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhSachNganh_Load(object sender, EventArgs e)
        {
            if (selected == 1)
                load_tong_diem(TongDiem);
            if (selected == 2)
                load_khu_vuc(KhuVuc);
            if (selected == 3)
                load_tu_van();
        }

        private void load_tu_van()
        {
            
        }

        private void load_khu_vuc(string KhuVuc)
        {
        }

        private void load_tong_diem(int TongDiem)
        {
        }
    }
}
