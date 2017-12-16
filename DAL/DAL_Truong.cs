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

        public void sua(string _ma_truong, string MaTruong, string TenTruong, string DiaChi, string Website)
        {
            string sql = "update truong set MaTruong = N'" + MaTruong + "', TenTruong=N'" + TenTruong + "',DiaChi=N'" + DiaChi + "',Website='" + Website + "' where MaTruong = '" + _ma_truong + "'";
            SqlCommand scm = new SqlCommand(sql, _conn);
            scm.ExecuteNonQuery();
        }

        public void xoa(string MaTruong)
        {
            string sql = "delete from truong where MaTruong = '" + MaTruong + "'";
            SqlCommand scm = new SqlCommand(sql, _conn);
            scm.ExecuteNonQuery();
        }

        public string queryTruong(string ChuyenNganh, string TongDiem, string TinhThanh)
        {
            string sql = "select tuyensinh.MaTruong, tuyensinh.MaNganh, tuyensinh.DiemChuan" +
                ", truong.TenTruong" +
                ", NhomNganh.TenChuyenNganh " +
                "from tuyensinh, truong, NhomNganh, chuyennganh " +
                "where (tuyensinh.MaTruong = truong.MaTruong) " +
                "and (NhomNganh.NhomNganh = chuyennganh.NhomNganh) " +
                "and (chuyennganh.MaNganh = tuyensinh.MaNganh) ";

            if (!String.IsNullOrEmpty(TinhThanh))
            {
                sql += "and (truong.TinhThanh LIKE N'%" + TinhThanh + "') ";
            }
            if (!String.IsNullOrEmpty(TongDiem))
            {
                sql += "and (tuyensinh.DiemChuan <= " + TongDiem + ") ";
            }
            if (!String.IsNullOrEmpty(ChuyenNganh))
            {
                sql += "and (NhomNganh.TenChuyenNganh LIKE N'%" + ChuyenNganh + "') ";
            }
            return sql;
        }

        public string queryNganh(string TongDiem, string TinhThanh)
        {
            string sql = "select tuyensinh.MaNganh, NhomNganh.TenChuyenNganh, truong.TenTruong, tuyensinh.DiemChuan, truong.DiaChi " +
                "from tuyensinh, truong, NhomNganh, chuyennganh " +
                "where (tuyensinh.MaTruong = truong.MaTruong) " +
                "and (NhomNganh.NhomNganh = chuyennganh.NhomNganh) " +
                "and (chuyennganh.MaNganh = tuyensinh.MaNganh) ";

            if (!String.IsNullOrEmpty(TinhThanh))
            {
                sql += "and (truong.TinhThanh LIKE N'%" + TinhThanh + "') ";
            }
            if (!String.IsNullOrEmpty(TongDiem))
            {
                sql += "and (tuyensinh.DiemChuan <= " + TongDiem + ") ";
            }
            return sql;
        }
        public List<string> getListTruong()
        {
            List<string> list=new List<string>();
            try
            {
                _conn.Open();
                string SQL = String.Format("Select TenTruong From Truong ORDER BY TenTruong ASC;");

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return list;
        }
        public List<string> searchListTruong(string truong,string tinh)
        {
            List<string> list = new List<string>();
            try
            {
                _conn.Open();
                string SQL = "";
                if (String.Compare(truong, "") != 0 && tinh != "--Tỉnh / TP--" )
                {
                    SQL = String.Format("Select TenTruong From Truong Where (TenTruong LIKE N'%"+truong+"%') AND (TinhThanh=N'"+tinh+"');");
                }
                else if (String.Compare(truong, "") == 0 && tinh != "--Tỉnh / TP--")
                {
                    SQL = String.Format("Select TenTruong From Truong Where TinhThanh=N'" + tinh + "';");
                }
                else if (String.Compare(truong, "") != 0 && tinh == "--Tỉnh / TP--")
                {
                    SQL = String.Format("Select TenTruong From Truong Where TenTruong LIKE N'%" + truong + "%';");
                }
                else
                {
                    SQL = String.Format("Select TenTruong From Truong ORDER BY TenTruong ;");
                }
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return list;
        }
        public string getDataCol(string text)
        {
            string result = "";
            try
            {
                _conn.Open();
                string SQL = String.Format("Select MaTruong From Truong Where TenTruong=N'"+text+"';");
                Console.Write(SQL);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString(0);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            
            return result;
        }
        public List<string> getListTinh()
        {

            List<string> list = new List<string>();
            list.Add("--Tỉnh / TP--");
            try
            {
                _conn.Open();
                string SQL = "Select DISTINCT TinhThanh From Truong";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return list;
        }
    }
}
