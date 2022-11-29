using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Login
{
    public class LogInModel
    {
        public string User { get; set; }
        public string Pwd { get; set; }
        public int Id_user { get; set; }
        public int Id_role { get; set; }
    }
}
