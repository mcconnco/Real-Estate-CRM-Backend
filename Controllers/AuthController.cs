using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using CRMApi.ApiServices.Login;
using CRMApi.Servicios.Seguridad;
using System;

namespace CRMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        LogInDto RptApi;
        LogInService Srv;
        private readonly IJwtAuth _jwtAuth;

        private readonly ILogger<AuthController> _logger;
        public AuthController(ILogger<AuthController> logger, IJwtAuth jwtAuth)
        {
            _logger = logger;
            _jwtAuth = jwtAuth;
            RptApi = new();
            Srv = new();
        }

        [HttpPost]
        [Route("authenticate")]
        public LogInDto Authenticate(LogInModel prm)
        {
            try
            {
                RptApi = Srv.Authentication(prm);
                if (RptApi.Success)
                {
                    RptApi.Token = _jwtAuth.Authentication(prm.User, RptApi.User.Id_user, RptApi.User.Id_role);
                }
            }
            catch (Exception ex)
            {
                RptApi.Success = false;
                RptApi.Message = "Ocurrio un error, " + ex.Message;
                _logger.LogError(ex.Message);
            }
            return RptApi;
        }

    }
}
