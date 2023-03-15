using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstateCRM.ApiServices.Agent;
using RealEstateCRM.ApiServices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.Controllers
{
    //[Authorize]
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

        [HttpGet]
        [Route("getAllClients")]
        public ClientDto getAllClients([FromQuery] ClientModel prm)
        {
            try
            {
                RptApi = Srv.ReadAll(prm);
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
