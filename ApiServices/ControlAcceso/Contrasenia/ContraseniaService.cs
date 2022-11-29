using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Contrasenia
{
    public class ContraseniaService
    {
        //private ContraseniaDto resp;
        //private ContraseniaData AccesoData;

        //private static Contrasenia CastData(DataRow dr)
        //{
        //    Contrasenia r = new();
        //    r.Sw_change_pass = (int)dr["sw_change_pass"];
        //    return r;
        //}
        //public ContraseniaDto FindById(ContraseniaModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudContrasena(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.Contrasenia = new();
        //                resp.Contrasenia = CastData(DsTable[0]);
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
        //public ContraseniaDto Update(ContraseniaModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudContrasena(Prm);
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
