using RealEstateCRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Interests
{
    public class InterestsData
    {
        OsuMySqlHelper mySql;
        internal InterestsData()
        {
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }
        public DataTable create_interest(InterestsModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("create_interest");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_interest_desc", model.interest_desc);
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
