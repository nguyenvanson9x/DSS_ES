using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn;
        public DBConnect()
        {
            _conn = GetDBConnection();
        }
        public SqlConnection GetDBConnection()
        {
            string datasource = @".\SQLEXPRESS";
            string database = "DSS_ES";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
