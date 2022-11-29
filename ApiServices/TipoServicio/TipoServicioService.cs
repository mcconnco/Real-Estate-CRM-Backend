using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoServicio
{
    public class TipoServicioService
    {
        private TipoServicioDto resp;
        private TipoServicioData AccesoData;

        private static TipoServicio CastData(DataRow dr)
        {
            TipoServicio r = new();
            r.Serv_Cod = (char)dr["Serv_Cod"];
            r.Serv_Nombre = (string)dr["Serv_Nombre"];
            r.Sw_Activo = (bool)dr["Sw_Activo"];
            return r;
        }
        public TipoServicioDto FindById(TipoServicioModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoServicio(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TipoServicio = new();
                        resp.TipoServicio = CastData(Ds.Tables[0].Rows[0]);
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
        public TipoServicioDto Find(TipoServicioModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoServicio(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.TipoServicios = new();
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            TipoServicio u = new();
                            u = CastData(Ds.Tables[0].Rows[i]);
                            resp.TipoServicios.Add(u);
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

        public TipoServicioDto Save(TipoServicioModel Prm)
        {
            return Action(Prm);
        }
        public TipoServicioDto Update(TipoServicioModel Prm)
        {
            return Action(Prm);
        }
        public TipoServicioDto Delete(TipoServicioModel Prm)
        {
            return Action(Prm);
        }

        private TipoServicioDto Action(TipoServicioModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_TipoServicio(Prm);
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
