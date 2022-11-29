using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoEntidad
{
    public class TipoEntidadDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TipoEntidad TipoEntidad { get; set; }
        public List<TipoEntidad> TiposEntidades { get; set; }
    }
    public class TipoEntidad
    {
        public int TPE_COD { get; set; }
        public string TPE_Nombre { get; set; }
        public bool Sw_Activo { get; set; }
    }
}
