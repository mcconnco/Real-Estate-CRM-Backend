using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class AgentService
    {
        private AgentDto resp;
        private AgentData AccessData;

        public AgentDto addAgent(AgentModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.create_agent(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    DataRow row = DsTable[0];
                    string message = (string)row["status"];
                    if (message == null)
                    {
                        resp.Success = false;
                        resp.Message = "Invalid user";
                    } else
                    {
                        resp.Success = true;
                        resp.Message = "Agent created successfully!";
                    }
                }
                else 
                {
                    resp.Success = false;
                    resp.Message = "An error has occured";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public AgentDto getAgent(AgentModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.read_agent(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    foreach (DataRow rows in Ds.Rows)
                    {
                        foreach (DataColumn col in Ds.Columns)
                        {
                            resp.Message += rows[col] + " ";
                        }
                    }
                }
                else 
                {
                    resp.Success = false;
                    resp.Message = "An error has occurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public AgentDto updateAgent(AgentModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.update_agent(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Agent successfully updated";
                }
                else {
                    resp.Success = false;
                    resp.Message = "An error has occurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public AgentDto deleteAgent(AgentModel model)
        {
            resp = new();
            try 
            {
                AccessData = new();
                var Ds = AccessData.delete_agent(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Agent successfully deleted";
                }
                else {
                    resp.Success = false;
                    resp.Message = "An error has occurred";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public AgentDto addClient(AgentClientModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.create_agent_client(model);
                var DsTable = Ds.Rows;

                if (DsTable.Count > 0)
                {
                    resp.Success = true;
                    resp.Message = "Agent-Client created successfully!";

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
