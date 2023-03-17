using RealEstateCRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Client
{
    public class ClientData
    {
        OsuMySqlHelper mySql;
        internal ClientData()
        {
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }
        public DataTable read_all_clients(ClientModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("read_all_clients");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_agent", model.id_agent);
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
