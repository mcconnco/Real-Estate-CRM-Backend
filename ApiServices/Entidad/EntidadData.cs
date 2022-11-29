﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Entidad
{
    public class EntidadData
    {
        private readonly string Cnn = Environment.GetEnvironmentVariable("CnnOTSYSTEM");
        public bool ConsultaEstado { get; set; }
        public string ConsultaMensaje { get; set; }

        public DataSet Mant_Entidad(EntidadModel Prm)
        {
            DataSet ds = new();
            SqlConnection conn = new(Cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new("mant_Entidad", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@consulta", Prm.Consulta);
                cmd.Parameters.AddWithValue("@mant_cod", Prm.Mant_cod);
                cmd.Parameters.AddWithValue("@mant_nombre", Prm.Mant_nombre);
                cmd.Parameters.AddWithValue("@mant_activo", Prm.Mant_activo);
                cmd.Parameters.AddWithValue("@mant_usr_id", Prm.Mant_usr_id);
                cmd.Parameters.AddWithValue("@mant_ent_id", Prm.Mant_ent_id);
                cmd.Parameters.AddWithValue("@mant_tipoEnt", Prm.Mant_tipoEnt);

                /* Parametros de salida para validar que el proceso se ejecuta correcto. */
                cmd.Parameters.Add("@out_error", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@out_estado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@out_mensaje", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;

                SqlDataAdapter da = new();
                da.SelectCommand = cmd;
                da.Fill(ds);

                ConsultaEstado = (bool)cmd.Parameters["@out_estado"].Value;
                ConsultaMensaje = cmd.Parameters["@out_mensaje"].Value.ToString();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
    }
}
