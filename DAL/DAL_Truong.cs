using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_Truong : DBConnect
    {
        public void myconnect()
        {
            _conn.Open();
        }

        public void myclose()
        {
            _conn.Close();
        }

        public DataTable getTruong(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void them(string MaTruong, string TenTruong, string DiaChi, string Website)
        {
            string sql = "insert into truong(MaTruong,TenTruong,DiaChi,Website) values('" + MaTruong + "',N'" + TenTruong + "',N'" + DiaChi + "','" + Website + "')";
            SqlCommand scm = new SqlCommand(sql, _conn);
            scm.ExecuteNonQuery();
        }

        public void sua(string MaTruong, string TenTruong, string DiaChi, string Website)
        {
            string sql = "update truong set TenTruong=N'" + TenTruong + "',DiaChi=N'" + DiaChi + "',Website='" + Website + "' where MaTruong = '" + MaTruong + "'";
            SqlCommand scm = new SqlCommand(sql, _conn);
            scm.ExecuteNonQuery();
        }

        public void xoa(string MaTruong)
        {
            string sql = "delete from truong where MaTruong = '" + MaTruong + "'";
            SqlCommand scm = new SqlCommand(sql, _conn);
            scm.ExecuteNonQuery();
        }
    }
}
