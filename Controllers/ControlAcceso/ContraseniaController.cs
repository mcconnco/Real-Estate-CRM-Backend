using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.Contrasenia;
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
    public class ContraseniaController : ControllerBase
    {
        //ContraseniaDto RptApi;
        //ContraseniaModel Model;
        //ContraseniaService Srv;

        //private readonly ILogger<ContraseniaController> _logger;
        //public ContraseniaController(ILogger<ContraseniaController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}
        
        //// GET api/<ContraseniaController>/5
        //[HttpGet("{id}")]
        //public ContraseniaDto Get(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "A";
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

        //// PUT api/<ContraseniaController>/5
        //[HttpPut("cambio-contrasenia-solicitud/{id}")]
        ////[Route("cambio-contrasenia-solicitud/{id}")]
        //public ContraseniaDto CambioContraseniaSolicitud(int id, [FromBody] ContraseniaModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "B";
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

        //// PUT api/<ContraseniaController>/5
        //[HttpPut("cambio-contrasenia/{id}")]
        ////[Route("cambio-contrasenia/{id}")]
        //public ContraseniaDto CambioContrasenia(int id, [FromBody] ContraseniaModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "C";
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
    }
}
