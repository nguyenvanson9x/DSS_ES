using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAL
{
    public class DAL_ThemDuLieu : DBConnect
    {
        public void excuteSQL(string SQL)
        {
            SqlCommand command = null;
            _conn.Open();
            try
            {
                command = new SqlCommand(SQL, _conn);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _conn.Close();
            }

        }
        public string getGroup(string tennganh)
        {
            string sql=String.Format("Select NhomNganh From NhomNganh Where TenChuyenNganh=N'"+tennganh+"';");
            string group="";
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    group = reader.GetString(0);
                    
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
    }
}
