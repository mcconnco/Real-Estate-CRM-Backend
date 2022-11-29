using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace RealEstateCRM.Utility
{
    public class OsuMySqlHelper
    {

        MySqlConnection conn;
        MySqlCommand cmd;
        
        public bool conn_status = false;
        public string error_msg;

        public OsuMySqlHelper(string connStr)
        {

            try
            {
                this.conn = new MySqlConnection(connStr);
            }
            catch (Exception ex)
            {
                this.conn_status = false;
                this.error_msg = ex.Message;
            }

        }

        public static string getConnectionString()
        {
            IConfigurationRoot MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var server = MyConfig.GetValue<string>("HostingVariables:UrlSERVER");
            var port = MyConfig.GetValue<string>("HostingVariables:PortSERVER");
            var dbname = MyConfig.GetValue<string>("HostingVariables:DbNameSERVER");
            var user = MyConfig.GetValue<string>("HostingVariables:UserSERVER");
            var password = MyConfig.GetValue<string>("HostingVariables:PwdSERVER");
            return "server=" + server + ";" +
                   "user=" + user + ";" +
                   "database=" + dbname + ";" +
                   "port=" + port + ";" +
                   "password=" + password + ";";
        }
        public void executeSP(string procedure)
        {
            this.conn.Open();
            this.conn_status = true;
            this.cmd = new MySqlCommand(procedure, conn);
            this.cmd.CommandType = CommandType.StoredProcedure;
        }
        public void addParameterIN(string parameter, object data)
        {
            this.cmd.Parameters.AddWithValue("@" + parameter, data);
        }
        public DataTable getTableSP()
        {
            MySqlDataReader rdr = this.cmd.ExecuteReader();
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            ds.Tables.Add(dataTable);
            ds.EnforceConstraints = false;
            dataTable.Load(rdr);
            rdr.Close();
            this.conn.Close();
            return dataTable;
        }
    }
}
