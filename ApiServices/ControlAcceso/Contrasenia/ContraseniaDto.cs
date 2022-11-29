using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.ControlAcceso.Contrasenia
{
    public class ContraseniaDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Contrasenia Contrasenia { get; set; }
    }
    public class Contrasenia
    {
        public int Sw_change_pass { get; set; }
    }
}
