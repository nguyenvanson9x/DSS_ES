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
            change_color(btnTuVan_Nganh);
            frmTuVan_Nganh frm = new frmTuVan_Nganh();
            add_form_to_panel(frm);
        }

        private void btnDiemChuan_Click(object sender, EventArgs e)
        {
            change_color(btnDiemChuan);
            frmDiemChuan frm = new frmDiemChuan();
            add_form_to_panel(frm);
        }

        private void btnTuVan_Truong_Click(object sender, EventArgs e)
        {
            change_color(btnTuVan_Truong);
            frmTuVan_Truong frm = new frmTuVan_Truong();
            add_form_to_panel(frm);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            change_color(btnQuanLy);
            frmQuanLy frm = new frmQuanLy();
            add_form_to_panel(frm);
        }

        private void btnCauHinh_Click(object sender, EventArgs e)
        {
            change_color(btnCauHinh);
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

        private void change_color(Button btn)
        {
            int r_default = 79, g_default = 195, b_default = 247;
            int r_click = 3, g_click = 169, b_click = 244;
            //normal: 79, 195, 247
            // click: 3, 169, 244
            foreach (Control c in this.tbNav.Controls)
            {
                try
                {
                    Button button = (Button)c;
                    if (button.Name.Equals(btn.Name))
                        button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r_click)))), ((int)(((byte)(g_click)))), ((int)(((byte)(b_click)))));
                    else
                        button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r_default)))), ((int)(((byte)(g_default)))), ((int)(((byte)(b_default)))));
                }
                catch (Exception e)
                {
                }
            }
        }
    }
}
