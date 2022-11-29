using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Entidad
{
    public class EntidadService
    {
        private EntidadDto resp;
        private EntidadData AccesoData;

        private static Entidad CastData(DataRow dr)
        {
            Entidad r = new();
            r.ENT_ID = (int)dr["ENT_ID"];
            r.ENT_cod = (string)dr["ENT_cod"];
            r.ENT_TPE_COD = (int)dr["ENT_TPE_COD"];
            r.ENT_Nombre = (string)dr["ENT_Nombre"];
            r.Sw_Activo = (bool)dr["Sw_Activo"];
            r.Usu_crea = (int)dr["Usu_crea"];
            r.FechaCrea = (DateTime)dr["FechaCrea"];
            r.Usu_modifica = (int)dr["Usu_modifica"];
            r.FechaModifica = (DateTime)dr["FechaModifica"];
            return r;
        }
        public EntidadDto FindById(EntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Entidad(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.Entidad = new();
                        resp.Entidad = CastData(Ds.Tables[0].Rows[0]);
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Entidade.";
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
        public EntidadDto Find(EntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Entidad(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.Entidades = new();
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Entidad u = new();
                            u = CastData(Ds.Tables[0].Rows[i]);
                            resp.Entidades.Add(u);
                        }
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Entidades.";
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

        public EntidadDto Save(EntidadModel Prm)
        {
            return Action(Prm);
        }
        public EntidadDto Update(EntidadModel Prm)
        {
            return Action(Prm);
        }
        public EntidadDto Delete(EntidadModel Prm)
        {
            return Action(Prm);
        }

        private EntidadDto Action(EntidadModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Entidad(Prm);
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
