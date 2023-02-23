using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstateCRM.ApiServices.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RealEstateCRM.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        AgentDto RptApi;
        AgentModel Model;
        AgentService Srv;
        private readonly ILogger<AgentController> _logger;
        public AgentController(ILogger<AgentController> logger)
        {
            _logger = logger;
            RptApi = new();
            Model = new();
            Srv = new();
        }

        [HttpPost]
        [Route("addClient")]
        public AgentDto addClient(AgentModel prm)
        {
            try
            {
                RptApi = Srv.addClient(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has ocurred, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }
    }
}
