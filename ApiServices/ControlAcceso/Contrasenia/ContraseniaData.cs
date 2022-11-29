using MySql.Data.MySqlClient;
using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Contrasenia
{
    public class ContraseniaData
    {
        //mySqlQuery SQ;
        //public bool ConsultaEstado { get; set; }
        //public string ConsultaMensaje { get; set; }
        //public int ConsultaError { get; set; }
        //internal ContraseniaData()
        //{
        //    SQ = consultas.getMysqlConnection();
        //}

        //public DataTable CrudContrasena(ContraseniaModel prm)
        //{
        //    DataTable DT = new DataTable();

        //    SQ._spConsulta("crud_contrasena");
        //    if (SQ.estado_cn == true)
        //    {
        //        SQ._spParametros("_consulta", MySqlDbType.VarChar, prm.Consulta);
        //        SQ._spParametros("_contrasena", MySqlDbType.VarChar, prm.Contrasena);
        //        SQ._spParametros("_usu_accion", MySqlDbType.Int32, prm.Usu_accion);
        //        SQ._spParametros("_usuario_id", MySqlDbType.Int32, prm.Usuario_id);

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
