﻿using System;
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
    public partial class frmDanhSachNganh : Form
    {
        public int selected = 1;
        public double TongDiem = 0;
        public string KhuVuc = "";

        public frmDanhSachNganh()
        {
            InitializeComponent();
            pnDetail.Visible = false;
        }
        BUS_Truong bus = new BUS_Truong();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDanhSachNganh_Load(object sender, EventArgs e)
        {
            try
            {
                if (selected == 1)
                    load_tong_diem(TongDiem);
                if (selected == 2)
                    load_khu_vuc(KhuVuc);
                if (selected == 3)
                    load_tu_van();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_tu_van()
        {
            try
            {
                dgv.DataSource = bus.getTruong(bus.queryNganh(TongDiem.ToString(), KhuVuc));
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm được dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bus.myclose();
            }
        }

        private void load_khu_vuc(string KhuVuc)
        {
            try
            {
                dgv.DataSource = bus.getTruong(bus.queryNganh("", KhuVuc));
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm được dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bus.myclose();
            }
        }

        private void load_tong_diem(double TongDiem)
        {
            try
            {
                dgv.DataSource = bus.getTruong(bus.queryNganh(TongDiem.ToString(),""));
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm được dữ liệu phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Lỗi kết nối cơ sở dữ liệu. Vào phần Cấu hình để thiết lập thông số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bus.myclose();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pnDetail.Visible = true;
            int row = e.RowIndex;
            lbTenNganh.Text = dgv[1, row].Value.ToString();
            lbDiemChuan.Text = dgv[3, row].Value.ToString();
            lbTenTruong.Text = dgv[2, row].Value.ToString();
            lbDiaChi.Text = dgv[4, row].Value.ToString();
        }
    }
}
