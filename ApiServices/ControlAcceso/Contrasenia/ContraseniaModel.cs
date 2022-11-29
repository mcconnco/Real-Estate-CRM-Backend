using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Contrasenia
{
    public class ContraseniaModel
    {
        public string Consulta { get; set; }
        public string Contrasena { get; set; }
        public int Usu_accion { get; set; }
        public int Usuario_id { get; set; }
    }
}
