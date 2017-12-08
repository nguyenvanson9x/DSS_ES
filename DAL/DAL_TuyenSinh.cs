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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TuyenSinh", _conn);
            DataTable dtTuyenSinh = new DataTable();
            da.Fill(dtTuyenSinh);
            return dtTuyenSinh;
        }

        public bool themTuyenSinh(DTO_TuyenSinh ts)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO TuyenSinh(MaTruong, MaNganh, DiemChuan,ChiTieu,SLDaTuyen) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", ts.MaTruong, ts.MaNganh, ts.DiemChuan, ts.ChiTieu, ts.SLDaTuyen);
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
                string SQL = string.Format("UPDATE TuyenSinh SET MaTruong = '{0}', MaNganh = '{1}', DiemChuan = '{2}', ChiTieu = '{3}', SLDaTuyen = '{4}' WHERE MaTruong = '{5}'", ts.MaTruong, ts.MaNganh, ts.DiemChuan, ts.ChiTieu, ts.SLDaTuyen, ts.MaTruong);
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
        public bool xoaTuyenSinh(string MaTruong)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM TuyenSinh WHERE MaTruong='{0}'", MaTruong);
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
