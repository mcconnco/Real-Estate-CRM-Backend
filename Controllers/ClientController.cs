using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstateCRM.ApiServices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RealEstateCRM.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ClientDto RptApi;
        ClientModel Model;
        ClientService Srv;
        private readonly ILogger<ClientController> _logger;
        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
            RptApi = new();
            Model = new();
            Srv = new();
        }

        [HttpPost]
        [Route("addClient")]
        public ClientDto addClient(ClientModel prm)
        {
            try
            {
                RptApi = Srv.addClient(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has occured, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

        [HttpGet]
        [Route("getClient")]
        public ClientDto getClient([FromQuery]ClientModel prm)
        {
            try
            {
                RptApi = Srv.getClient(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has occured, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

        [HttpPut]
        [Route("updateClient")]
        public ClientDto updateClient(ClientModel prm)
        {
            try
            {
                RptApi = Srv.updateClient(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has occured, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

        [HttpDelete]
        [Route("deleteClient")]
        public ClientDto deleteClient(ClientModel prm)
        {
            try
            {
                RptApi = Srv.deleteClient(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has occured, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }
    }
}
