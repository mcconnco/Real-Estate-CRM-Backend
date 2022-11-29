using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.MenuRol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRMApi.Controllers.ControlAcceso
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuRolController : ControllerBase
    {
        //MenuRolDto RptApi;
        //MenuRolModel Model;
        //MenuRolService Srv;

        //private readonly ILogger<MenuRolController> _logger;
        //public MenuRolController(ILogger<MenuRolController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}

        //// GET api/<MenuRolController>/5
        //[HttpGet("menu-rol-ByRol/{id}")]
        //public MenuRolDto GetByRol(int id)
        //{
        //    try
        //    {
        //        Model.Rol_id = id;
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        RptApi = Srv.Save(Model);
        //    }
        //    catch (Exception ex)
        //    {
        //        RptApi.Success = false;
        //        RptApi.Message = "Ocurrio un error, " + ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return RptApi;
        //}

        //// POST api/<MenuRolController>
        //[HttpPost]
        //public MenuRolDto Post([FromBody] MenuRolModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        RptApi = Srv.Save(value);
        //    }
        //    catch (Exception ex)
        //    {
        //        RptApi.Success = false;
        //        RptApi.Message = "Ocurrio un error, " + ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return RptApi;
        //}
    }
}
