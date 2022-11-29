using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Usuario
{
    public class UsuarioService
    {
        //private UsuarioDto resp;
        //private UsuarioData AccesoData;

        //private static Usuario CastData(DataRow dr)
        //{
        //    Usuario r = new();
        //    r.status = (int)dr["status"];
        //    r.usuario_id = (int)dr["usuario_id"];
        //    r.rol_id = (int)dr["rol_id"];
        //    r.nombre = (string)dr["nombre"];
        //    r.usuario = (string)dr["usuario"];
        //    r.rol = (string)dr["rol"];
        //    r.sw_admin = (int)dr["sw_admin"];
        //    return r;
        //}
        //public UsuarioDto FindById(UsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudUsuarios(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Usuario = new();
        //                resp.Usuario = CastData(DsTable[0]);
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
        //public UsuarioDto Find(UsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudUsuarios(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Usuarios = new();
        //                for (int i = 0; i < DsTable.Count; i++)
        //                {
        //                    Usuario u = new();
        //                    u = CastData(DsTable[i]);
        //                    resp.Usuarios.Add(u);
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
        //public UsuarioDto Save(UsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        AccesoData.CrudUsuarios(Prm);
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
        //public UsuarioDto Update(UsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudUsuarios(Prm);
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
        //public UsuarioDto Delete(UsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudUsuarios(Prm);
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
