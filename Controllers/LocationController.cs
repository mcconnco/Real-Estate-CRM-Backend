using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstateCRM.ApiServices.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.Controllers
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        LocationDto RptApi;
        LocationModel Model;
        LocationService Srv;
        private readonly ILogger<LocationController> _logger;
        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
            RptApi = new();
            Model = new();
            Srv = new();
        }

        [HttpPost]
        [Route("createLocation")]
        public LocationDto CreateLocation(LocationModel prm)
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

        [HttpPost]
        [Route("getLocation")]
        public LocationDto getLocation(LocationModel prm)
        {
            try
            {
                RptApi = Srv.Get(prm);
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
