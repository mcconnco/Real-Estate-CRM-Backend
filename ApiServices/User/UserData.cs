using RealEstateCRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class UserData
    {
        OsuMySqlHelper mySql;
        internal UserData()
        {
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }

        public DataTable register_user(UserModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("proc_register_user");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_agent_number", model.agent_number);
                mySql.addParameterIN("_first_name", model.first_name);
                mySql.addParameterIN("_last_name", model.last_name);
                mySql.addParameterIN("_username", model.username);
                mySql.addParameterIN("_password", model.password);
                mySql.addParameterIN("_id_user_create", model.id_user_create);
                mySql.addParameterIN("_sw_admin", model.sw_admin);
                mySql.addParameterIN("_sw_agent", model.sw_agent);
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
