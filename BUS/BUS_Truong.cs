using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Truong
    {
        private DAL_Truong dal;

        public BUS_Truong()
        {
            dal = new DAL_Truong();
        }

        public void myconnect()
        {
            dal.myconnect();
        }

        public void myclose()
        {
            dal.myclose();
        }

        public DataTable getTruong(string sql)
        {
            return dal.getTruong(sql);
        }

        public void them(string MaTruong, String TenTruong, String DiaChi, String Website)
        {
            dal.them(MaTruong, TenTruong, DiaChi, Website);
        }

        public void sua(string MaTruong, String TenTruong, String DiaChi, String Website)
        {
            dal.sua(MaTruong, TenTruong, DiaChi, Website);
        }

        public void xoa(string MaTruong)
        {
            dal.xoa(MaTruong);
        }

        public string queryTruong(string ChuyenNganh, string TongDiem, string TinhThanh)
        {
            return dal.queryTruong(ChuyenNganh, TongDiem, TinhThanh);
        }

        public string queryNganh(string ChuyenNganh, string TongDiem)
        {
            return dal.queryNganh(ChuyenNganh, TongDiem);
        }
    }
}
