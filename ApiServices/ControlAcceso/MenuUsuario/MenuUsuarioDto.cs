using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuUsuario
{
    public class MenuUsuarioDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public MenuUsuario MenuUsuario { get; set; }
        public List<MenuUsuario> MenusUsuario { get; set; }
    }
    public class MenuUsuario
    {
        public string Menu { get; set; }
        public int Acc_menu_id { get; set; }
        public int Estado { get; set; }
        public int Crear { get; set; }
        public int Editar { get; set; }
        public int Eliminar { get; set; }
        public int Ver { get; set; }
        public int Principal { get; set; }
        public int Padre { get; set; }
    }
}
