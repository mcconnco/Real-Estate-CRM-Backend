using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuUsuario
{
    public class MenuUsuarioModel
    {
        public string Consulta { get; set; }
        public int Usuario_id { get; set; }
        public int Usu_accion { get; set; }
        public int Menu_id { get; set; }
        public int Estado { get; set; }
        public int Crear { get; set; }
        public int Eliminar { get; set; }
        public int Editar { get; set; }
        public int Ver { get; set; }
        public int Principal { get; set; }
    }
}
