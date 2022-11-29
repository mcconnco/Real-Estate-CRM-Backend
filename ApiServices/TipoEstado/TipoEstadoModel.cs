using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoEstado
{
    public class TipoEstadoModel
    {
        public string Consulta { get; set; }
        public int Mant_tp_estado { get; set; }
        public string Mant_nombre { get; set; }
        public bool Mant_activo { get; set; }
        public int Mant_usr_id { get; set; }
    }
}
