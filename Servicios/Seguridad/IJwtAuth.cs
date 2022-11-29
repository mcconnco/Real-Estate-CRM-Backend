using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.Servicios.Seguridad
{
    public interface IJwtAuth
    {
        string Authentication(string username, int idUser, int idRol);
    }
}
