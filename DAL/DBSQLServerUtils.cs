using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            string connString = @"Server=" + datasource + ";Database=" + database + ";Trusted_Connection=True";
            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
