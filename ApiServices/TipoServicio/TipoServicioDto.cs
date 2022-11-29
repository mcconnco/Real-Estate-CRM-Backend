using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.TipoServicio
{
    public class TipoServicioDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public List<TipoServicio> TipoServicios { get; set; }
    }
    public class TipoServicio
    {
        public char Serv_Cod { get; set; }
        public string Serv_Nombre { get; set; }
        public bool Sw_Activo { get; set; }
    }
}
