using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_TuVan : DBConnect
    {
        public DataTable getTuVan()
        {
            string sql = "select tuyensinh.MaTruong, tuyensinh.MaNganh, tuyensinh.DiemChuan" +
                ", truong.TenTruong, truong.DiaChi" + 
                ", NhomNganh.TenChuyenNganh " +
                "from tuyensinh, truong, NhomNganh, chuyennganh " +
                "where (tuyensinh.MaTruong = truong.MaTruong) " +
                "and (NhomNganh.NhomNganh = chuyennganh.NhomNganh) " +
                "and (chuyennganh.MaNganh = tuyensinh.MaNganh) "
                ;
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
