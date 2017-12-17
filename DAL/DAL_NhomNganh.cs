using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhomNganh : DBConnect
    {
        public bool add(string ten_nhom_nganh)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("INSERT INTO NhomNganh(TenChuyenNganh) VALUES (N'{0}')", ten_nhom_nganh);
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

        public DataTable getNhomNganh()
        {
            string sql = "select * from NhomNganh";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool edit(int id, string p)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("update NhomNganh set TenChuyenNganh = N'{0}' where NhomNganh = {1}", p, id);
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

        public bool delete(int id)
        {
            try
            {
                _conn.Open();

                string SQL = string.Format("delete from NhomNganh where NhomNganh = {0}", id);
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
