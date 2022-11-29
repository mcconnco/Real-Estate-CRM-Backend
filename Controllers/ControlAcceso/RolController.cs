using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.Rol;
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
    public class RolController : ControllerBase
    {
        //RolDto RptApi;
        //RolModel Model;
        //RolService Srv;

        //private readonly ILogger<RolController> _logger;
        //public RolController(ILogger<RolController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}

        //// GET: api/<RolController>
        //[HttpGet]
        //public RolDto Get()
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        RptApi = Srv.Find(Model);
        //    }
        //    catch (Exception ex)
        //    {
        //        RptApi.Success = false;
        //        RptApi.Message = "Ocurrio un error, " + ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return RptApi;
        //}

        //// GET api/<RolController>/5
        //[HttpGet("{id}")]
        //public RolDto Get(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        Model.Rol_id = id;
        //        RptApi = Srv.FindById(Model);
        //    }
        //    catch (Exception ex)
        //    {
        //        RptApi.Success = false;
        //        RptApi.Message = "Ocurrio un error, " + ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return RptApi;
        //}

        //// POST api/<RolController>
        //[HttpPost]
        //public RolDto Post(RolModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "C";
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

        //// PUT api/<RolController>/5
        //[HttpPut("{id}")]
        //public RolDto Put(int id, [FromBody] RolModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "U";
        //        value.Rol_id = id;
        //        RptApi = Srv.Update(value);
        //    }
        //    catch (Exception ex)
        //    {
        //        RptApi.Success = false;
        //        RptApi.Message = "Ocurrio un error, " + ex.Message;
        //        _logger.LogError(ex.Message);
        //    }

        //    return RptApi;
        //}

        //// DELETE api/<RolController>/5
        //[HttpDelete("{id}")]
        //public RolDto Delete(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "D";
        //        Model.Rol_id = id;
        //        RptApi = Srv.Delete(Model);
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
