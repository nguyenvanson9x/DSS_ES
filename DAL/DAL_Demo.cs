using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Demo : DBConnect
    {
        public DAL_Demo()
        { 
        }
        public DataTable getDemo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Truong", _conn);
            DataTable dtDemo = new DataTable();
            da.Fill(dtDemo);
            return dtDemo;
        }

        public bool themDemo(DTO_Demo d)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("insert into demo(name) values ('{0}')", d.Name);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
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

        public bool suaDemo(DTO_Demo d)
        {
            return d.Name.Equals("Son");
        }

        public bool xoaDemo(string name)
        {
            return false;
        }
    }
}
