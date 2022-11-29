using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Departamento
{
    public class DepartamentoModel
    {
        public string Consulta { get; set; }
        public string Mant_cod_entidad { get; set; }
        public string Mant_nombre { get; set; }
        public int Mant_activo { get; set; }
        public int Mant_usr_id { get; set; }
        public int Mant_dep_id { get; set; }
    }
}
