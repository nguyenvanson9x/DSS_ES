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
    public partial class frmHuongDan : Form
    {
        public string content = "";
        public string title = "";

        public frmHuongDan()
        {
            InitializeComponent();
            txtContent.TabStop = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {
            txtContent.Text = content;
            lb.Text = title;
        }
    }
}
