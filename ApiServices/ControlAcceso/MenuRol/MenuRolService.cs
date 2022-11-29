using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuRol
{
    public class MenuRolService
    {
        //private MenuRolDto resp;
        //private MenuRolData AccesoData;

        //private static MenuRol CastData(DataRow dr)
        //{
        //    MenuRol r = new();
        //    r.Menu = (string)dr["Menu"];
        //    r.Nombre_rol = (string)dr["Nombre_rol"];
        //    r.Acc_menu_id = (int)dr["Acc_menu_id"];
        //    r.Rol_id = (int)(long)dr["Rol_id"];
        //    r.Estado = (int)(long)dr["Estado"];
        //    r.Crear = (int)(long)dr["Crear"];
        //    r.Editar = (int)(long)dr["Editar"];
        //    r.Eliminar = (int)(long)dr["Eliminar"];
        //    r.Ver = (int)(long)dr["Ver"];
        //    r.Principal = (int)(long)dr["Principal"];
        //    r.Padre = (int)dr["Padre"];
        //    return r;
        //}
        //public MenuRolDto Save(MenuRolModel Prm)
        //{
        //    resp = new();
        //    try
        //    {
        //        AccesoData = new();
        //        var Ds = AccesoData.CrudMenuRol(Prm);
        //        var DsTable = Ds.Rows;
        //        if (AccesoData.ConsultaEstado)
        //        {
        //            resp.Success = AccesoData.ConsultaEstado;
        //            resp.Message = AccesoData.ConsultaMensaje;

        //            if (DsTable.Count > 0)
        //            {
        //                resp.MenuRoles = new();
        //                for (int i = 0; i < DsTable.Count; i++)
        //                {
        //                    MenuRol u = new();
        //                    u = CastData(DsTable[i]);
        //                    resp.MenuRoles.Add(u);
        //                }
        //            }
        //            else
        //            {
        //                resp.Success = false;
        //                resp.Message = "No Existen Menu-Rol.";
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
