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
        public DataTable create_client(ClientModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("create_client");
            if(mySql.conn_status == true)
            {
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

        public DataTable read_client(ClientModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("read_client");
            if(mySql.conn_status == true)
            {
                mySql.addParameterIN("_first_name", model.first_name);
                mySql.addParameterIN("_last_name", model.last_name);
                mySql.addParameterIN("_address", model.address);
                mySql.addParameterIN("_phone_num", model.phone_num);
                DT = mySql.getTableSP();
            }
            else
            {
                // Handle Error
            }
            return DT;
        }

        public DataTable update_client(ClientModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("update_client");
            if(mySql.conn_status == true)
            {
                mySql.addParameterIN("_first_name", model.first_name);
                mySql.addParameterIN("_last_name", model.last_name);
                mySql.addParameterIN("_address", model.address);
                mySql.addParameterIN("_city", model.city);
                mySql.addParameterIN("_email", model.email);
                mySql.addParameterIN("_phone_num", model.phone_num);
                mySql.addParameterIN("_sw_active", model.sw_active);
                mySql.addParameterIN("_id_client", model.id_client);
                mySql.addParameterIN("_id_agent", model.id_agent);
                DT = mySql.getTableSP();
            }
            else
            {
                // Handle Error
            }
            return DT;
        }

        public DataTable delete_client(ClientModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("delete_client");
            if(mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_client", model.id_client);
                DT = mySql.getTableSP();
            }
            else
            {
                // Handle Error
            }
            return DT;
        }

    }
}
