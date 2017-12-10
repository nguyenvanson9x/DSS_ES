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
    public partial class frmDanhSachTruong : Form
    {
        public frmDanhSachTruong()
        {
            InitializeComponent();
        }

        private string sql;
        public frmDanhSachTruong(string sql)
            : this()
        {
            this.sql = sql;
        }

        BUS_Truong bus = new BUS_Truong();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhSachTruong_Load(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = bus.getTruong(sql);
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm được dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm được dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bus.myclose();
            }
        }
    }
}
