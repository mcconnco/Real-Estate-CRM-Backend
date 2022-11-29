using MySql.Data.MySqlClient;
using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuRol
{
    public class MenuRolData
    {
        //Consultas consultas = new();
        //mySqlQuery SQ;
        //public bool ConsultaEstado { get; set; }
        //public string ConsultaMensaje { get; set; }
        //public int ConsultaError { get; set; }
        //internal MenuRolData()
        //{
        //    SQ = consultas.getMysqlConnection();
        //}

        //public DataTable CrudMenuRol(MenuRolModel prm)
        //{
        //    DataTable DT = new DataTable();

        //    SQ._spConsulta("crud_acc_menu_rol");
        //    if (SQ.estado_cn == true)
        //    {
        //        SQ._spParametros("_consulta", MySqlDbType.VarChar, prm.Consulta);
        //        SQ._spParametros("_rol_id", MySqlDbType.VarChar, prm.Rol_id);
        //        SQ._spParametros("_acc_menu_id", MySqlDbType.VarChar, prm.Menu_id);
        //        SQ._spParametros("_estado", MySqlDbType.VarChar, prm.Estado);
        //        SQ._spParametros("_crear", MySqlDbType.Int32, prm.Crear);
        //        SQ._spParametros("_eliminar", MySqlDbType.Int32, prm.Eliminar);
        //        SQ._spParametros("_editar", MySqlDbType.Int32, prm.Editar);
        //        SQ._spParametros("_ver", MySqlDbType.Int32, prm.Ver);
        //        SQ._spParametros("_principal", MySqlDbType.Int32, prm.Principal);
        //        SQ._spParametros("_usu_accion", MySqlDbType.Int32, prm.Usu_accion);

        //        /* Parametros de salida para validar que el proceso se ejecuta correcto. */
        //        SQ._spParametroOut("_out_estado", MySqlDbType.Int32, ConsultaEstado);
        //        SQ._spParametroOut("_out_error", MySqlDbType.Int32, ConsultaError);
        //        SQ._spParametroOut("_out_mensaje", MySqlDbType.VarChar, ConsultaMensaje);

        //        DT = SQ._spTable();

        //        int estado = (int)SQ._SpRetorno("_out_estado");
        //        string mensaje = (string)SQ._SpRetorno("_out_mensaje");

        //        ConsultaEstado = (estado == 1) ? true : false;
        //        ConsultaMensaje = mensaje;

        //        if (SQ.error != "")
        //        {
        //            //empaqueta_error_consulta(SQ.error, SQ.NumError);
        //        }
        //    }
        //    else
        //    {
        //        //DB = "SQ";
        //        //empaqueta_error_consulta();
        //    }
        //    return DT;
        //}

    }
}
