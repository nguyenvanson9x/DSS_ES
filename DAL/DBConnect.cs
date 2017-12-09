using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DBConnect
    {
        private string datasource, database, username, password;
        protected SqlConnection _conn;
        public DBConnect()
        {
            database = "DSS_ES";
            datasource = @".\SQLEXPRESS";
            username = "";
            password = "";
            _conn = GetDBConnection();
        }
        public SqlConnection GetDBConnection()
        {
            //datasource = ConfigurationManager.AppSettings["datasource"];
            //database = ConfigurationManager.AppSettings["database"];
            //username = ConfigurationManager.AppSettings["username"];
            //password = ConfigurationManager.AppSettings["password"];

            if (username.Equals("") && password.Equals(""))
                return DBSQLServerUtils.GetDBConnection(datasource, database);
            else
                return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);

        }
        public string DataSource
        {
            get
            {
                return datasource;
            }
            set
            {
                datasource = value;
            }
        }
        public string DataBase
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }
        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
