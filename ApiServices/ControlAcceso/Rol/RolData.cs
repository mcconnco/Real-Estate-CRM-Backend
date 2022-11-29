using MySql.Data.MySqlClient;
using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Rol
{
    public class RolData
    {
        //Consultas consultas = new();
        //mySqlQuery SQ;
        //public bool ConsultaEstado { get; set; }
        //public string ConsultaMensaje { get; set; }
        //public int ConsultaError { get; set; }
        //internal RolData()
        //{
        //    SQ = consultas.getMysqlConnection();
        //}
        //public DataTable CrudRol(RolModel prm)
        //{
        //    DataTable DT = new DataTable();

        //    SQ._spConsulta("crud_rol");
        //    if (SQ.estado_cn == true)
        //    {
        //        SQ._spParametros("_consulta", MySqlDbType.VarChar, prm.Consulta);
        //        SQ._spParametros("_nivel", MySqlDbType.Int32, prm.Nivel);
        //        SQ._spParametros("_descripcion", MySqlDbType.VarChar, prm.Descripcion);
        //        SQ._spParametros("_status", MySqlDbType.Int32, prm.Status);
        //        SQ._spParametros("_sw_admin", MySqlDbType.Int32, prm.Sw_admin);
        //        SQ._spParametros("_usu_accion", MySqlDbType.Int32, prm.Usu_accion);
        //        SQ._spParametros("_rol_id", MySqlDbType.Int32, prm.Rol_id);
        //        SQ._spParametros("_dependiente", MySqlDbType.Int32, prm.Dependiente);

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
