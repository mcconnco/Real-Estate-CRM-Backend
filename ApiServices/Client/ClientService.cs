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

        public ClientDto addClient(ClientModel model)
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
                    resp.Message = "Agent created successfully!";
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

        public ClientDto getClient(ClientModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.read_client(model);
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

        public ClientDto updateClient(ClientModel model)
        {
            resp = new();
            try
            {
                AccessData = new();
                var Ds = AccessData.update_client(model);
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

        public ClientDto deleteClient(ClientModel model)
        {
            resp = new();
            try 
            {
                AccessData = new();
                var Ds = AccessData.delete_client(model);
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
    }
}
