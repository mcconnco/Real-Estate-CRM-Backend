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
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        AgentDto RptApi;
        AgentClientModel Model;
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
        [Route("addAgent")]
        public AgentDto addAgent(AgentModel prm)
        {
            try
            {
                RptApi = Srv.addAgent(prm);
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
        [Route("getAgent")]
        public AgentDto getAgent([FromQuery]AgentModel prm)
        {
            try
            {
                RptApi = Srv.getAgent(prm);
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
        [Route("getAgentByNumber")]
        public AgentDto getAgentByNumber([FromQuery] AgentByNumberModel prm)
        {
            try
            {
                RptApi = Srv.getAgentByNumber(prm);
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
        [Route("updateAgent")]
        public AgentDto updateAgent(AgentModel prm)
        {
            try
            {
                RptApi = Srv.updateAgent(prm);
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
        [Route("deleteAgent")]
        public AgentDto deleteAgent(AgentModel prm)
        {
            try
            {
                RptApi = Srv.deleteAgent(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has occured, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }



        [HttpPost]
        [Route("addClient")]
        public AgentDto addClient(AgentClientModel prm)
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
