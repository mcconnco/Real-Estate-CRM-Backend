using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoServicio
{
    public class TipoServicioModel
    {
        public string Consulta { get; set; }
        public string Mant_cod_servicio { get; set; }
        public string Mant_nombre { get; set; }
        public bool Mant_activo { get; set; }
        public int Mant_usr_id { get; set; }
    }
}
