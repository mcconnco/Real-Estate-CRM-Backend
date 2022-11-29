using CRMApi.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuUsuario
{
    public class MenuUsuarioData
    {
        //Consultas consultas = new();
        //mySqlQuery SQ;
        //public bool ConsultaEstado { get; set; }
        //public string ConsultaMensaje { get; set; }
        //public int ConsultaError { get; set; }
        //internal MenuUsuarioData()
        //{
        //    SQ = consultas.getMysqlConnection();
        //}

        //public DataSet CrudMenuUsuario(MenuUsuarioModel prm)
        //{

        //    DataSet ds = new();
        //    //SqlConnection conn = new(Cnn);
        //    //try
        //    //{
        //    //    conn.Open();
        //    //    SqlCommand cmd = new("crud_acc_menu_usuario", conn);
        //    //    cmd.CommandType = CommandType.StoredProcedure;
        //    //    cmd.Parameters.AddWithValue("@consulta", prm.Consulta);
        //    //    cmd.Parameters.AddWithValue("@usuario_id", prm.Usuario_id);
        //    //    cmd.Parameters.AddWithValue("@acc_menu_id", prm.Menu_id);
        //    //    cmd.Parameters.AddWithValue("@estado", prm.Estado);
        //    //    cmd.Parameters.AddWithValue("@crear", prm.Crear);
        //    //    cmd.Parameters.AddWithValue("@eliminar", prm.Eliminar);
        //    //    cmd.Parameters.AddWithValue("@editar", prm.Editar);
        //    //    cmd.Parameters.AddWithValue("@ver", prm.Ver);
        //    //    cmd.Parameters.AddWithValue("@principal", prm.Principal);
        //    //    cmd.Parameters.AddWithValue("@usu_accion", prm.Usu_accion);

        //    //    /* Parametros de salida para validar que el proceso se ejecuta correcto. */
        //    //    cmd.Parameters.Add("@out_error", SqlDbType.Int).Direction = ParameterDirection.Output;
        //    //    cmd.Parameters.Add("@out_estado", SqlDbType.Bit).Direction = ParameterDirection.Output;
        //    //    cmd.Parameters.Add("@out_mensaje", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;

        //    //    SqlDataAdapter da = new();
        //    //    da.SelectCommand = cmd;
        //    //    da.Fill(ds);

        //    //    ConsultaEstado = (bool)cmd.Parameters["@out_estado"].Value;
        //    //    ConsultaMensaje = cmd.Parameters["@out_mensaje"].Value.ToString();
        //    //}
        //    //catch (SqlException)
        //    //{
        //    //    throw;
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    throw;
        //    //}
        //    //finally
        //    //{
        //    //    conn.Close();
        //    //}
        //    return ds;
        //}
    }
}
