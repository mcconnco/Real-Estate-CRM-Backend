using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoEstado
{
    public class TipoEstadoDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TipoEstado TipoEstado { get; set; }
        public List<TipoEstado> TipoEstados { get; set; }
    }
    public class TipoEstado
    {
        public int TP_ES_ID { get; set; }
        public string TP_ES_Nombre { get; set; }
        public bool Sw_Activo { get; set; }
        public int Usu_crea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int Usu_modifica { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
