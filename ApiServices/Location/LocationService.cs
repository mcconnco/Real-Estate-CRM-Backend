using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Location
{
    public class LocationService
    {
        private LocationDto resp;
        private LocationData AccessData;

        private static Location CastDataLocation(DataRow dr)
        {
            Location r = new();
            r.id_location = (int)dr["id_location"];
            r.address_1 = (string)dr["address_1"];
            r.address_2 = (string)dr["address_2"];
            r.x_coordinate = (string)dr["x_coordinate"];
            r.y_coordinate = (string)dr["y_coordinate"];
            r.location_sales = (int)dr["location_sales"];
            r.location_revenue = (decimal)dr["location_revenue"];
            return r;
        }

        public LocationDto Create(LocationModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.crud_location(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Location created successfully!";

                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public LocationDto Get(LocationModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.crud_location(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Location obtained successfully!";

                    resp.Location = new();
                    resp.Location = CastDataLocation(DsTable[0]);
                }
                else
                {
                    resp.Success = false;
                    resp.Message = "An error has ocurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
    }
}
