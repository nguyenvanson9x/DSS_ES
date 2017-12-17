using System;
using System.Collections.Generic;
using System.Collections;
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
        public bool checkSQL(string SQL)
        {
            int count = 0;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    count++;
                if (count > 0)
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
        public int getGroup(string tennganh)
        {
            string sql=String.Format("Select NhomNganh From NhomNganh Where TenChuyenNganh=N'"+tennganh+"';");
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
        public int getNumberRow()
        {
            string sql = String.Format("Select COUNT(NhomNganh) From NhomNganh");
            int row = 0;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    row=reader.GetInt32(0);

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return row;
        }

        public List<String> auto_complete(string type)
        {
            string sql = "select " + type + " from NhomNganh";
            List<string> auto = new List<string>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        auto.Add(reader[type].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                _conn.Close();
            }
            return auto;
        }
    }
}
