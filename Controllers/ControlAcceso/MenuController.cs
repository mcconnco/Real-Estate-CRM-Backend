using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRMApi.ApiServices.ControlAcceso.Menu;
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
    public class MenuController : ControllerBase
    {
        //MenuDto RptApi;
        //MenuModel Model;
        //MenuService Srv;

        //private readonly ILogger<MenuController> _logger;
        //public MenuController(ILogger<MenuController> logger)
        //{
        //    _logger = logger;
        //    RptApi = new();
        //    Model = new();
        //    Srv = new();
        //}
        //// GET: api/<MenuController>
        //[HttpGet]
        //public MenuDto Get()
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

        //// GET api/<MenuController>/5
        //[HttpGet("{id}")]
        //public MenuDto Get(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "R";
        //        Model.Id_menu = id;
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

        //// POST api/<MenuController>
        //[HttpPost]
        //public MenuDto Post(MenuModel value)
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

        //// PUT api/<MenuController>/5
        //[HttpPut("{id}")]
        //public MenuDto Put(int id, [FromBody] MenuModel value)
        //{
        //    try
        //    {
        //        value.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        value.Consulta = "U";
        //        value.Id_menu = id;
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

        //// DELETE api/<MenuController>/5
        //[HttpDelete("{id}")]
        //public MenuDto Delete(int id)
        //{
        //    try
        //    {
        //        Model.Usu_accion = Convert.ToInt32(User.FindFirstValue("idUser"));
        //        Model.Consulta = "D";
        //        Model.Id_menu = id;
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
