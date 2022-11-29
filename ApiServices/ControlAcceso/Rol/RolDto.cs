using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Rol
{
    public class RolDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Rol Rol { get; set; }
        public List<Rol> Roles { get; set; }
    }
    public class Rol
    {
        public int Rol_id { get; set; }
        public string Nombre { get; set; }
        public int Status { get; set; }
        public int Nivel { get; set; }
        public int Sw_admin { get; set; }
        public int Dependiente { get; set; }
    }
}
