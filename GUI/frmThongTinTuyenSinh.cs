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
    public partial class frmThongTinTuyenSinh : Form
    {
        private BUS_TuyenSinh bus;
        public frmThongTinTuyenSinh()
        {
            bus = new BUS_TuyenSinh();
            InitializeComponent();
        }

        private void frmThongTinTuyenSinh_Load(object sender, EventArgs e)
        {
            dgvInfo.DataSource = bus.getTuyenSinh();
        }
    }
}
