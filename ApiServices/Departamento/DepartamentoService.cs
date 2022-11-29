using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Departamento
{
    public class DepartamentoService
    {
        private DepartamentoDto resp;
        private DepartamentoData AccesoData;

        private static Departamento CastData(DataRow dr)
        {
            Departamento r = new();
            r.Dep_Id = (int)dr["dep_Id"];
            r.Dep_Cia_Id = (int)dr["dep_Cia_Id"];
            r.Dep_nombre = (string)dr["dep_nombre"];
            r.Dep_UsrCrea = (int)dr["dep_UsrCrea"];
            r.Dep_FechaCreacion = (DateTime)dr["dep_FechaCreacion"];
            r.Dep_UsrModifica = (int)dr["dep_UsrModifica"];
            r.Dep_FechaModifica = (DateTime)dr["dep_FechaModifica"];
            r.Dep_SwActivo = (bool)dr["dep_SwActivo"];
            return r;
        }
        public DepartamentoDto FindById(DepartamentoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Departamento(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.Departamento = new();
                        resp.Departamento = CastData(Ds.Tables[0].Rows[0]);
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Departamento.";
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
        public DepartamentoDto Find(DepartamentoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Departamento(Prm);
                if (AccesoData.ConsultaEstado)
                {
                    resp.Success = AccesoData.ConsultaEstado;
                    resp.Message = AccesoData.ConsultaMensaje;

                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        resp.Departamentos = new();
                        for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                        {
                            Departamento u = new();
                            u = CastData(Ds.Tables[0].Rows[i]);
                            resp.Departamentos.Add(u);
                        }
                    }
                    else
                    {
                        resp.Success = false;
                        resp.Message = "No Existe Departamento.";
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

        public DepartamentoDto Save(DepartamentoModel Prm)
        {
            return Action(Prm);
        }
        public DepartamentoDto Update(DepartamentoModel Prm)
        {
            return Action(Prm);
        }
        public DepartamentoDto Delete(DepartamentoModel Prm)
        {
            return Action(Prm);
        }

        private DepartamentoDto Action(DepartamentoModel Prm)
        {
            resp = new();
            try
            {
                AccesoData = new();
                var Ds = AccesoData.Mant_Departamento(Prm);
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
