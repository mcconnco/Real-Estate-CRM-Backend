using RealEstateCRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class AgentData
    {
        OsuMySqlHelper mySql;
        internal AgentData()
        {
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }

        public DataTable create_client(AgentModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("create_agent_client");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_agent", model.id_agent);
                mySql.addParameterIN("_first_name", model.first_name);
                mySql.addParameterIN("_last_name", model.last_name);
                mySql.addParameterIN("_address", model.address);
                mySql.addParameterIN("_city", model.city);
                mySql.addParameterIN("_email", model.email);
                mySql.addParameterIN("_phone_num", model.phone_num);
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
