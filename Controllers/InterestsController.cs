using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstateCRM.ApiServices.Interests;
using RealEstateCRM.ApiServices.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        InterestsDto RptApi;
        InterestsModel Model;
        InterestsService Srv;
        private readonly ILogger<LocationController> _logger;
        public InterestsController(ILogger<LocationController> logger)
        {
            _logger = logger;
            RptApi = new();
            Model = new();
            Srv = new();
        }

        [HttpPost]
        [Route("createInterest")]
        public InterestsDto CreateInterest(InterestsModel prm)
        {
            try
            {
                RptApi = Srv.Create(prm);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has ocurred, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

        [HttpDelete]
        [Route("deleteInterest")]
        public InterestsDto DeleteInterest(InterestsModel prm)
        {
            try
            {
                //RptApi = Srv.Delete(prm);
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
