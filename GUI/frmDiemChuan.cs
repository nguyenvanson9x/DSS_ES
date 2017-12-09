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
    public partial class frmDiemChuan : Form
    {
        public frmDiemChuan()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmDiemChuan_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHuongDan frm = new frmHuongDan();
            frm.title = "";
            frm.content = "Line 1\r\nLine 2\r\nLine 3\r";
            frm.ShowDialog();
        }
    }
}
