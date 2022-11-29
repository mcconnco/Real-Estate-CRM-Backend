using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Departamento
{
    public class DepartamentoDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Departamento Departamento { get; set; }
        public List<Departamento> Departamentos { get; set; }
    }
    public class Departamento
    {
        public int Dep_Id { get; set; }
        public int Dep_Cia_Id { get; set; }
        public string Dep_nombre { get; set; }
        public int Dep_UsrCrea { get; set; }
        public DateTime Dep_FechaCreacion { get; set; }
        public int Dep_UsrModifica { get; set; }
        public DateTime Dep_FechaModifica { get; set; }
        public bool Dep_SwActivo { get; set; }
    }
}
