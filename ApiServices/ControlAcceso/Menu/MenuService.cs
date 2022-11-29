using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Menu
{
    public class MenuService
    {
        //private MenuDto resp;
        //private MenuData AccesoData;

        //private static Menu CastData(DataRow dr)
        //{
        //    Menu r = new();
        //    r.Id_menu = (int)dr["Id_menu"];
        //    r.Nombre = (string)dr["Nombre"];
        //    r.Link = (string)dr["Link"];
        //    r.Status = (int)dr["Status"];
        //    r.Sw_display = (int)dr["Sw_display"];
        //    r.Orden = (int)dr["Orden"];
        //    r.Descripcion = (string)dr["Descripcion"];
        //    r.Sw_admin = (int)dr["Sw_admin"];
        //    r.Nivel = (int)dr["Nivel"];
        //    r.Padre = (int)dr["padre"];
        //    return r;
        //}
        //public MenuDto FindById(MenuModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenu(Prm);
        //        var DsTable = Ds.Rows; 
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Menu = new();
        //                resp.Menu = CastData(DsTable[0]);
        //            }
        //            else
        //            {
        //                resp.Success = false;
        //                resp.Message = "No Existe Usuario.";
        //            }
        //        }
        //        else
        //        {
        //            resp.Success = false;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}
        //public MenuDto Find(MenuModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenu(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Menus = new();
        //                for (int i = 0; i < DsTable.Count; i++)
        //                {
        //                    Menu u = new();
        //                    u = CastData(DsTable[i]);
        //                    resp.Menus.Add(u);
        //                }
        //            }
        //            else
        //            {
        //                resp.Success = false;
        //                resp.Message = "No Existe menu.";
        //            }
        //        }
        //        else
        //        {
        //            resp.Success = false;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}
        //public MenuDto Save(MenuModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        AccesoData.CrudMenu(Prm);
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //        else
        //        {
        //            resp.Success = false;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}
        //public MenuDto Update(MenuModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenu(Prm);
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //        else
        //        {
        //            resp.Success = false;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}
        //public MenuDto Delete(MenuModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenu(Prm);
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //        else
        //        {
        //            resp.Success = false;
        //            resp.Message = AccesoData.ConsultaMensaje;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}
    }
}
