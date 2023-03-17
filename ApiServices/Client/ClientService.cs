using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Client
{
    public class ClientService
    {
        private ClientDto resp;
        private ClientData AccessData;
        private static AgentClient CastDataUser(DataRow dr)
        {
            AgentClient r = new();
            r.id_client = (int)dr["id_client"];
            r.first_name = (string)dr["first_name"];
            r.last_name = (string)dr["last_name"];
            r.address = (string)dr["address"];
            r.city = (string)dr["city"];
            r.email = (string)dr["email"];
            r.phone_num = (string)dr["phone_num"];
            var myDate = dr["last_contact"];
            r.last_contact = myDate == null ? (DateTime)myDate : DateTime.MinValue;
            r.contact_threshold_days = (int)dr["contact_threshold_days"];
            r.sw_active = (int)dr["sw_active"];
            return r;
        }

        public ClientDto ReadAll(ClientModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.read_all_clients(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "User list retrieved successfully!";
                    resp.AgentClients = new();

                    for (int i = 0; i < DsTable.Count; i++)
                    {
                        AgentClient u = new();
                        u = CastDataUser(DsTable[i]);
                        resp.AgentClients.Add(u);
                    }
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
