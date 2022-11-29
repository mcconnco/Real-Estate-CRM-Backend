using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Rol
{
    public class RolService
    {
        //private RolDto resp;
        //private RolData AccesoData;

        //private static Rol CastData(DataRow dr)
        //{
        //    Rol r = new();
        //    r.Rol_id = (int)dr["rol_id"];
        //    r.Nombre = (string)dr["nombre"];
        //    r.Status = (int)dr["status"];
        //    r.Nivel = (int)dr["nivel"];
        //    r.Sw_admin = (int)dr["sw_admin"];
        //    r.Dependiente = (int)dr["dependiente"];
        //    return r;
        //}
        //public RolDto FindById(RolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudRol(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Rol = new();
        //                resp.Rol = CastData(DsTable[0]);
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
        //public RolDto Find(RolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudRol(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Roles = new();
        //                for (int i = 0; i < DsTable.Count; i++)
        //                {
        //                    Rol u = new();
        //                    u = CastData(DsTable[i]);
        //                    resp.Roles.Add(u);
        //                }
        //            }
        //            else
        //            {
        //                resp.Success = false;
        //                resp.Message = "No Existen Usuarios.";
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
        //public RolDto Save(RolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        AccesoData.CrudRol(Prm);
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
        //public RolDto Update(RolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudRol(Prm);
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
        //public RolDto Delete(RolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudRol(Prm);
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
