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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnTuVan_Nganh_Click(object sender, EventArgs e)
        {
            frmTuVan_Nganh frm = new frmTuVan_Nganh();
            add_form_to_panel(frm);
        }

        private void btnDiemChuan_Click(object sender, EventArgs e)
        {
            frmDiemChuan frm = new frmDiemChuan();
            add_form_to_panel(frm);
        }

        private void btnTuVan_Truong_Click(object sender, EventArgs e)
        {
            frmTuVan_Truong frm = new frmTuVan_Truong();
            add_form_to_panel(frm);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            add_form_to_panel(frm);
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            CauHinh frm = new CauHinh();
            add_form_to_panel(frm);
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
    }
}
