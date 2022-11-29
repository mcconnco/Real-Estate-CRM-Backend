using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuUsuario
{
    public class MenuUsuarioService
    {
        //private MenuUsuarioDto resp;
        //private MenuUsuarioData AccesoData;

        //private static MenuUsuario CastData(DataRow dr)
        //{
        //    MenuUsuario r = new();
        //    r.Menu = (string)dr["Menu"];
        //    r.Acc_menu_id = (int)dr["Acc_menu_id"];
        //    r.Estado = (int)dr["Estado"];
        //    r.Crear = (int)dr["Crear"];
        //    r.Editar = (int)dr["Editar"];
        //    r.Eliminar = (int)dr["Eliminar"];
        //    r.Ver = (int)dr["Ver"];
        //    r.Principal = (int)dr["Principal"];
        //    r.Padre = (int)dr["Padre"];
        //    return r;
        //}
        //public MenuUsuarioDto Save(MenuUsuarioModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenuUsuario(Prm);
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (Ds.Tables[0].Rows.Count > 0)
        //            {
        //                resp.MenusUsuario = new();
        //                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
        //                {
        //                    MenuUsuario u = new();
        //                    u = CastData(Ds.Tables[0].Rows[i]);
        //                    resp.MenusUsuario.Add(u);
        //                }
        //            }
        //            else
        //            {
        //                resp.Success = false;
        //                resp.Message = "No Existen Menu-Usario.";
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
    }
}
