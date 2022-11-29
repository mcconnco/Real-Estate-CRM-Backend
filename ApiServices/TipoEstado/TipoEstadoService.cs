using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoEstado
{
    public class TipoEstadoService
    {
        private TipoEstadoDto resp;
        private TipoEstadoData AccesoData;

        private static TipoEstado CastData(DataRow dr)
        {
            TipoEstado r = new();
            r.TP_ES_ID = (int)dr["TP_ES_ID"];
            r.TP_ES_Nombre = (string)dr["TP_ES_Nombre"];
            r.Sw_Activo = (bool)dr["Sw_Activo"];
            r.Usu_crea = (int)dr["usu_crea"];
            r.FechaCrea = (DateTime)dr["FechaCrea"];
            r.Usu_modifica = (int)dr["usu_modifica"];
            r.FechaModifica = (DateTime)dr["FechaModifica"];
            return r;
        }
        public TipoEstadoDto FindById(TipoEstadoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoEstado(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TipoEstado = new();
                        resp.TipoEstado = CastData(Ds.Tables[0].Rows[0]);
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Tipo Entidade.";
                    }
                }
                else
                {
                    resp.Success = false;
                    resp.Message = AccesoData.ConsultaMensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
        public TipoEstadoDto Find(TipoEstadoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoEstado(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TipoEstados = new();
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            TipoEstado u = new();
                            u = CastData(Ds.Tables[0].Rows[i]);
                            resp.TipoEstados.Add(u);
                        }
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Tipos Entidades.";
                    }
                }
                else
                {
                    resp.Success = false;
                    resp.Message = AccesoData.ConsultaMensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }

        public TipoEstadoDto Save(TipoEstadoModel Prm)
        {
            return Action(Prm);
        }
        public TipoEstadoDto Update(TipoEstadoModel Prm)
        {
            return Action(Prm);
        }
        public TipoEstadoDto Delete(TipoEstadoModel Prm)
        {
            return Action(Prm);
        }

        private TipoEstadoDto Action(TipoEstadoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoEstado(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;
                }
                else
                {
                    resp.Success = false;
                    resp.Message = AccesoData.ConsultaMensaje;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resp;
        }
    }
}
