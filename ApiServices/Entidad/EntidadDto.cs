using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Entidad
{
    public class EntidadDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Entidad Entidad { get; set; }
        public List<Entidad> Entidades { get; set; }
    }
    public class Entidad
    {
        public int ENT_ID { get; set; }
        public string ENT_cod { get; set; }
        public int ENT_TPE_COD { get; set; }
        public string ENT_Nombre { get; set; }
        public bool Sw_Activo { get; set; }
        public int Usu_crea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int Usu_modifica { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
