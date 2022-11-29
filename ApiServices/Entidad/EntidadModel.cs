using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Entidad
{
    public class EntidadModel
    {
        public string Consulta { get; set; }
        public string Mant_cod { get; set; }
        public string Mant_nombre { get; set; }
        public int Mant_activo { get; set; }
        public int Mant_usr_id { get; set; }
        public int Mant_ent_id { get; set; }
        public int Mant_tipoEnt { get; set; }
    }
}
