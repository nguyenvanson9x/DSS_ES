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
    public partial class frmThemDuLieu : Form
    {
        public frmThemDuLieu()
        {
            InitializeComponent();
            pnInput.Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!pnInput.Visible)
                pnInput.Visible = true;
            else
                pnInput.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
