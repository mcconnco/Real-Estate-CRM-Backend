using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.Usuario;
using System;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRMApi.Controllers.ControlAcceso
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //UsuarioDto RptApi;
        //UsuarioModel Model;
        //UsuarioService Srv;

        //private readonly ILogger<UsuarioController> _logger;
        //public UsuarioController(ILogger<UsuarioController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}

        //// GET: api/<UsuarioController>
        //[HttpGet]
        //public UsuarioDto Get()
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

        //// GET api/<UsuarioController>/5
        //[HttpGet("{id}")]
        //public UsuarioDto Get(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        Model.Usuario_id = id;
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

        //// POST api/<UsuarioController>
        //[HttpPost]
        //public UsuarioDto Post(UsuarioModel value)
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

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public UsuarioDto Put(int id, [FromBody] UsuarioModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "U";
        //        value.Usuario_id = id;
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

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public UsuarioDto Delete(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "D";
        //        Model.Usuario_id = id;
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
