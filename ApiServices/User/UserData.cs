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

        public DataTable getAll_Users()
        {
            DataTable DT = new DataTable();

            mySql.executeSP("read_all_users");
            if (mySql.conn_status == true)
            {
                DT = mySql.getTableSP();
            }
            else
            {
                //Handle Error
            }
            return DT;

        }
        public DataTable getUser(int id_user)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("read_user");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_user", id_user);
                DT = mySql.getTableSP();
            }
            else
            {
                //Handle Error
            }
            return DT;

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

        public DataTable update_user(User model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("update_user");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_user", model.id_user);
                mySql.addParameterIN("_first_name", model.first_name);
                mySql.addParameterIN("_last_name", model.last_name);
                mySql.addParameterIN("_username", model.username);
                mySql.addParameterIN("_password", model.password);
                mySql.addParameterIN("_sw_active", model.sw_active);
                mySql.addParameterIN("_sw_change_pass", model.sw_change_pass);
                mySql.addParameterIN("_id_user_mod", model.id_user_mod);
                DT = mySql.getTableSP();
            }
            else
            {
                //Handle Error
            }
            return DT;
        }
        public DataTable delete_user(UserDelete model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("update_user");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_id_user", model.id_user);
                mySql.addParameterIN("_id_user_mod", model.id_user_mod);
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
