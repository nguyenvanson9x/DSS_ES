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
        public bool suaTuyenSinh(DTO_TuyenSinh ts, string tentruong, string matruong, string manganh, int group, string tennganh)
        {
            try
            {
                _conn.Open();
                Console.Write(ts.MaNganh);
                string sqlChuyenNganh = string.Format("UPDATE ChuyenNganh SET  MaNganh =N'{0}' WHERE  MaNganh='{1}'", ts.MaNganh, manganh);
                string sqlTruongNganh = string.Format("UPDATE TruongNganh SET  MaNganh =N'{0}' WHERE MaTruong='{1}' AND MaNganh='{2}'", ts.MaNganh, matruong,manganh);
                string sqlNhomNganh = string.Format("UPDATE NhomNganh SET  TenChuyenNganh=N'{0}' WHERE NhomNganh='{1}'",tennganh,group);
                string sqlTruong = string.Format("UPDATE Truong SET  TenTruong=N'{0}' WHERE MaTruong='{1}'", tentruong, matruong);
                string sqlTuyenSinh = string.Format("UPDATE TuyenSinh SET MaNganh=N'{0}',DiemChuan={1},ChiTieu={2},SLDaTuyen={3} WHERE MaNganh='{4}'", ts.MaNganh, ts.DiemChuan, ts.ChiTieu, ts.SLDaTuyen, manganh);
                SqlCommand cmd_Truong = new SqlCommand(sqlTruong, _conn);
                SqlCommand cmd_NhomNganh = new SqlCommand(sqlNhomNganh, _conn);
                SqlCommand cmd_ChuyenNganh = new SqlCommand(sqlChuyenNganh, _conn);
                SqlCommand cmd_TruongNganh = new SqlCommand(sqlTruongNganh, _conn);
                SqlCommand cmd_TuyenSinh = new SqlCommand(sqlTuyenSinh, _conn);

                if (cmd_Truong.ExecuteNonQuery() > 0 && cmd_TruongNganh.ExecuteNonQuery() > 0 && cmd_ChuyenNganh.ExecuteNonQuery() > 0 && cmd_NhomNganh.ExecuteNonQuery() > 0 && cmd_TuyenSinh.ExecuteNonQuery() > 0)
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
        public int getGroup(string tennganh)
        {
            string sql = String.Format("Select NhomNganh From NhomNganh Where TenChuyenNganh=N'" + tennganh + "';");
            int group = 0;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    group = reader.GetInt32(0);

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return group;
        }
        public bool xoaTuyenSinh(string MaTruong, string manganh)
        {
            try
            {
                _conn.Open();
                string SQLTS = string.Format("DELETE FROM TuyenSinh WHERE TuyenSinh.MaTruong = '"+MaTruong+"' AND TuyenSinh.MaNganh='"+manganh+"'");
                string SQLTN = string.Format("DELETE FROM TruongNganh WHERE TruongNganh.MaTruong = '" + MaTruong + "' AND TruongNganh.MaNganh='" + manganh + "'");
            
                SqlCommand cmd = new SqlCommand(SQLTS, _conn);
                SqlCommand _cmd = new SqlCommand(SQLTN, _conn);
                if (cmd.ExecuteNonQuery() > 0 && _cmd.ExecuteNonQuery() > 0)
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
