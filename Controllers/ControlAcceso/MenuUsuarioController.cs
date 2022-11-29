    using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.MenuUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRMApi.Controllers.ControlAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuUsuarioController : ControllerBase
    {
        //MenuUsuarioDto RptApi;
        //MenuUsuarioModel Model;
        //MenuUsuarioService Srv;

        //private readonly ILogger<MenuUsuarioController> _logger;
        //public MenuUsuarioController(ILogger<MenuUsuarioController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}

        //// GET api/<MenuUsuarioController>/5
        //[HttpGet("menu-user-ByUser/{id}")]
        //public MenuUsuarioDto GetByUser(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        Model.Usuario_id = id;
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

        //// POST api/<MenuUsuarioController>
        //[HttpPost]
        //public MenuUsuarioDto Post([FromBody] MenuUsuarioModel value)
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
