using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Menu
{
    public class MenuModel
    {
        public string Consulta { get; set; }
        public int Usu_accion { get; set; }
        public string Nombre { get; set; }
        public int Status { get; set; }
        public int Sw_admin { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }
        public string Link { get; set; }
        public int Sw_display { get; set; }
        public int Id_menu { get; set; }
        public int Orden { get; set; }
        public int Padre { get; set; }
    }
}
