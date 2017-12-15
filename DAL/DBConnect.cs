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
        private static Configuration config;
        private string datasource, database, username, password;
        protected SqlConnection _conn;
        public DBConnect()
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("datasource"))
                AddAppSetting("datasource", @".\SQLEXPRESS");
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("database"))
                AddAppSetting("database", "DSS_ES");
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("username"))
                AddAppSetting("username", "");
            if (!ConfigurationManager.AppSettings.AllKeys.Contains("password"))
                AddAppSetting("password", "");
            _conn = GetDBConnection();
        }
        public SqlConnection GetDBConnection()
        {
            datasource = ConfigurationManager.AppSettings["datasource"];
            database = ConfigurationManager.AppSettings["database"];
            username = ConfigurationManager.AppSettings["username"];
            password = ConfigurationManager.AppSettings["password"];

            if (username.Equals("") && password.Equals(""))
                return DBSQLServerUtils.GetDBConnection(datasource, database);
            else
                return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void EditAppSetting(string key, string value)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void AddAppSetting(string key, string value)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void RemoveAppSetting(string key)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
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
