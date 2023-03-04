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
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserDto RptApi;
        UserModel Model;
        UserService Srv;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            RptApi = new();
            Model = new();
            Srv = new();
        }

        [HttpPost]
        [Route("register")]
        public UserDto createUser(UserModel prm)
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

        [HttpGet]
        [Route("getAllUsers")]
        public UserDto getAllUser()
        {
            try
            {
                RptApi = Srv.GetAll();
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has ocurred, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }
<<<<<<< Updated upstream
        //api/User/getUser/?id_user=1
=======
        //api/User/getUser/?user_id=1
>>>>>>> Stashed changes
        [HttpGet]
        [Route("getUser")]
        public UserDto getUser([FromQuery] int id_user)
        {
            try
            {
                RptApi = Srv.GetUser(id_user);
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "An error has ocurred, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

        [HttpPut]
        [Route("update")]
        public UserDto updateUser(User prm)
        {
            try
            {
                RptApi = Srv.Update(prm);
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
        [Route("deactivate")]
        public UserDto deactivateUser(UserDelete prm)
        {
            try
            {
                RptApi = Srv.Deactivate(prm);
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
