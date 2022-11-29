using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Usuario
{
    public class UsuarioDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
    public class Usuario
    {
        public int status { get; set; }
        public int usuario_id { get; set; }
        public int rol_id { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string rol { get; set; }
        public int sw_admin { get; set; }
    }
}
