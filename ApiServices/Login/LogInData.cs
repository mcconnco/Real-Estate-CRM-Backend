using MySql.Data.MySqlClient;
using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using RealEstateCRM.Utility;

namespace CRMApi.ApiServices.Login
{
    public class LogInData
    {
        OsuMySqlHelper mySql;
        internal LogInData()
        {
            //SQ = consultas.getMysqlConnection();
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }

        public DataTable QueryLogIn(LogInModel Prm)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("proc_acc_login");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_username", Prm.User);
                mySql.addParameterIN("_password", Prm.Pwd);// Variable global // su valor esta en el webConfig
                DT = mySql.getTableSP();
            }
            else
            {
                //Handle Error
            }
            return DT;
        }
        public DataTable QueryPermissions(LogInModel Prm)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("proc_acc_user_menu");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_user", Prm.Id_user);
                mySql.addParameterIN("_id_role", Prm.Id_role);// Variable global // su valor esta en el webConfig
                DT = mySql.getTableSP();
            }
            else
            {
                //Handle Error
            }
            return DT;
        }
        
    }
}
