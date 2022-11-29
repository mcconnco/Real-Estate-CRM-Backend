using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.MenuRol
{
    public class MenuRolDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public MenuRol MenuRol { get; set; }
        public List<MenuRol> MenuRoles { get; set; }
    }
    public class MenuRol
    {
        public string Menu { get; set; }
        public string Nombre_rol { get; set; }
        public int Acc_menu_id { get; set; }
        public int Rol_id { get; set; }
        public int Estado { get; set; }
        public int Crear { get; set; }
        public int Editar { get; set; }
        public int Eliminar { get; set; }
        public int Ver { get; set; }
        public int Principal { get; set; }
        public int Padre { get; set; }
    }
}
