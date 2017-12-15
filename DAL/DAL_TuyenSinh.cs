using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_TuyenSinh : DBConnect
    {
        public DataTable getTuyenSinh()
        {
            string sql = String.Format("SELECT Truong.TenTruong,NhomNganh.TenChuyenNganh,TuyenSinh.MaNganh,TuyenSinh.DiemChuan,TuyenSinh.ChiTieu,TuyenSinh.SLDaTuyen FROM Truong,TuyenSinh,ChuyenNganh,NhomNganh WHERE Truong.MaTruong=TuyenSinh.MaTruong AND ChuyenNganh.MaNganh=TuyenSinh.MaNganh AND ChuyenNganh.NhomNganh=NhomNganh.NhomNganh");
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dtTuyenSinh = new DataTable();
            da.Fill(dtTuyenSinh);
            return dtTuyenSinh;
        }
        public DataTable searchData(string text)
        {
            string sql = String.Format("SELECT Truong.TenTruong,NhomNganh.TenChuyenNganh,TuyenSinh.MaNganh,TuyenSinh.DiemChuan,TuyenSinh.ChiTieu,TuyenSinh.SLDaTuyen FROM Truong,TuyenSinh,ChuyenNganh,NhomNganh WHERE Truong.MaTruong=TuyenSinh.MaTruong AND ChuyenNganh.MaNganh=TuyenSinh.MaNganh AND ChuyenNganh.NhomNganh=NhomNganh.NhomNganh AND (Truong.TenTruong LIKE N'%" + text + "%' OR NhomNganh.TenChuyenNganh LIKE N'%" + text + "%' OR TuyenSinh.MaNganh LIKE N'%" + text + "%' OR TuyenSinh.DiemChuan LIKE '%" + text + "%' OR TuyenSinh.ChiTieu LIKE '%" + text + "%' OR TuyenSinh.SLDaTuyen LIKE '%" + text + "%')");
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dtTuyenSinh = new DataTable();
            da.Fill(dtTuyenSinh);
            return dtTuyenSinh;
        }
        public bool excuteSQL(string SQL)
        {
            try
            {
              _conn.Open();
              int count = 0;
              SqlCommand cmd = new SqlCommand(SQL, _conn);
              SqlDataReader reader = cmd.ExecuteReader();
              while (reader.Read())
                  count++;
              if(count>0)
                  return false;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return true;
        }
        public string getMaTruong(string TenTruong)
        {
            string matruong = "";
            try
            {
                _conn.Open();
                
                string SQL = String.Format("Select Distinct Truong.MaTruong From Truong Where TenTruong=N'" + TenTruong + "'");
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    matruong = reader.GetString(0);
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return matruong;
        }
        public bool themTuyenSinh(DTO_TuyenSinh ts)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO TuyenSinh(MaTruong, MaNganh, DiemChuan,ChiTieu,SLDaTuyen) VALUES ('{0}', '{1}', {2},{3},{4})", ts.MaTruong, ts.MaNganh, ts.DiemChuan,ts.ChiTieu,ts.SLDaTuyen);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
 
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool suaTuyenSinh(DTO_TuyenSinh ts)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE TuyenSinh SET MaTruong = '{0}', MaNganh = '{1}', DiemChuan = {2},ChiTieu={3},SLDaTuyen={4}  WHERE MaTruong = '{5}' AND MaNganh='{6}' ", ts.MaTruong, ts.MaNganh, ts.DiemChuan, ts.ChiTieu, ts.SLDaTuyen, ts.MaTruong, ts.MaNganh);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
 
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                _conn.Close();
            }
 
            return false;
        }
        public bool xoaTuyenSinh(string MaTruong, string manganh)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM TuyenSinh WHERE MaTruong = '{0}' AND MaNganh = '{1}')",MaTruong,manganh);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
 
            }
            catch (Exception e)
            {
 
            }
            finally
            {
                _conn.Close();
            }
 
            return false;
        }
    }
}
