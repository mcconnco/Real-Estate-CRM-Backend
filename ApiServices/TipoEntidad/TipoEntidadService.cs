using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoEntidad
{
    public class TipoEntidadService
    {
        private TipoEntidadDto resp;
        private TipoEntidadData AccesoData;

        private static TipoEntidad CastData(DataRow dr)
        {
            TipoEntidad r = new();
            r.Sw_Activo = (bool)dr["Sw_Activo"];
            r.TPE_COD = (int)dr["TPE_COD"];
            r.TPE_Nombre = (string)dr["TPE_Nombre"];
            return r;
        }
        public TipoEntidadDto FindById(TipoEntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Gen_Tipo_entidad(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TipoEntidad = new();
                        resp.TipoEntidad = CastData(Ds.Tables[0].Rows[0]);
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
        public TipoEntidadDto Find(TipoEntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Gen_Tipo_entidad(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TiposEntidades = new();
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            TipoEntidad u = new();
                            u = CastData(Ds.Tables[0].Rows[i]);
                            resp.TiposEntidades.Add(u);
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

        public TipoEntidadDto Save(TipoEntidadModel Prm)
        {
            return Action(Prm);
        }
        public TipoEntidadDto Update(TipoEntidadModel Prm)
        {
            return Action(Prm);
        }
        public TipoEntidadDto Delete(TipoEntidadModel Prm)
        {
           return Action(Prm);
        }

        private TipoEntidadDto Action(TipoEntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Gen_Tipo_entidad(Prm);
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
