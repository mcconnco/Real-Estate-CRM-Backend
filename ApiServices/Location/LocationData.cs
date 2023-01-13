using RealEstateCRM.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Location
{
    public class LocationData
    {
        OsuMySqlHelper mySql;
        internal LocationData()
        {
            mySql = new OsuMySqlHelper(OsuMySqlHelper.getConnectionString());
        }
        public DataTable crud_location(LocationModel model)
        {
            DataTable DT = new DataTable();

            mySql.executeSP("crud_location");
            if (mySql.conn_status == true)
            {
                mySql.addParameterIN("_operation", model.operation);
                mySql.addParameterIN("_address_1", model.address_1);
                mySql.addParameterIN("_address_2", model.address_2);
                mySql.addParameterIN("_x_coordinate", model.x_coordinate);
                mySql.addParameterIN("_y_coordinate", model.y_coordinate);
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
