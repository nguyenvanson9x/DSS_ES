﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTuVan_Truong : Form
    {
        public frmTuVan_Truong()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmDanhSachTruong frm = new frmDanhSachTruong();
            frm.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}