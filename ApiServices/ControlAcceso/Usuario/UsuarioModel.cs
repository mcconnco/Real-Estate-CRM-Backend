using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Usuario
{
    public class UsuarioModel
    {
        public string Consulta { get; set; }
        public string Nombre { get; set; }
        public int Usu_accion { get; set; }
        public int Status { get; set; }
        public int Sw_admin { get; set; }
        public int Usuario_id { get; set; }
        public int Rol_id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
