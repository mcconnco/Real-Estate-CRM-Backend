using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Rol
{
    public class RolModel
    {
        public string Consulta { get; set; }
        public int Usu_accion { get; set; }
        public int Status { get; set; }
        public int Sw_admin { get; set; }
        public int Rol_id { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public int Dependiente { get; set; }
    }
}
