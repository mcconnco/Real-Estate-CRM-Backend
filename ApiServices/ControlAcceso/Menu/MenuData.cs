using MySql.Data.MySqlClient;
using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Menu
{
    public class MenuData
    {
        //Consultas consultas = new();
        //mySqlQuery SQ;
        //public bool ConsultaEstado { get; set; }
        //public int ConsultaError { get; set; }
        //public string ConsultaMensaje { get; set; }

        //internal MenuData()
        //{
        //    SQ = consultas.getMysqlConnection();
        //}
        //public DataTable CrudMenu(MenuModel prm)
        //{
        //    DataTable DT = new DataTable();

        //    SQ._spConsulta("crud_acc_menu");
        //    if (SQ.estado_cn == true)
        //    {
        //        SQ._spParametros("_consulta", MySqlDbType.VarChar, prm.Consulta);
        //        SQ._spParametros("_nombre", MySqlDbType.VarChar, prm.Nombre);
        //        SQ._spParametros("_link", MySqlDbType.VarChar, prm.Link);
        //        SQ._spParametros("_descripcion", MySqlDbType.VarChar, prm.Descripcion);
        //        SQ._spParametros("_status", MySqlDbType.Int32, prm.Status);
        //        SQ._spParametros("_sw_admin", MySqlDbType.Int32, prm.Sw_admin);
        //        SQ._spParametros("_sw_display", MySqlDbType.Int32, prm.Sw_display);
        //        SQ._spParametros("_id_menu", MySqlDbType.Int32, prm.Id_menu);
        //        SQ._spParametros("_orden", MySqlDbType.Int32, prm.Orden);
        //        SQ._spParametros("_nivel", MySqlDbType.Int32, prm.Nivel);
        //        SQ._spParametros("_padre", MySqlDbType.Int32, prm.Padre);

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
