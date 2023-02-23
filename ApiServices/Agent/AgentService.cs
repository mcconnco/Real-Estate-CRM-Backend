using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class AgentService
    {
        private AgentDto resp;
        private AgentData AccessData;

        public AgentDto addClient(AgentModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.create_client(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Interest created successfully!";

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
