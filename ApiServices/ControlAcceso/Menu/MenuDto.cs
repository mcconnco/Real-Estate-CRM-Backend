using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Menu
{
    public class MenuDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Menu Menu { get; set; }
        public List<Menu> Menus { get; set; }
    }
    public class Menu
    {
        public int Id_menu { get; set; }
        public string Nombre { get; set; }
        public string Link { get; set; }
        public int Status { get; set; }
        public int Sw_display { get; set; }
        public int Orden { get; set; }
        public string Descripcion { get; set; }
        public int Sw_admin { get; set; }
        public int Nivel { get; set; }
        public int Padre { get; set; }
    }
}
