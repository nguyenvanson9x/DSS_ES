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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            frmTuVan frmTuVan = new frmTuVan();
            frmTuVan.Show();
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            CauHinh frmCauHinh = new CauHinh();
            frmCauHinh.Show();
        }
    }
}
