using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Login
{
    public class LogInService
    {
        private LogInDto response;
        private static UserLogin CastDataLogIn(DataRow dr)
        {
            UserLogin r = new();
            r.First_name = (string)dr["first_name"];
            r.Sw_active = (int)dr["sw_active"];
            r.Sw_change_pass = (int)dr["sw_change_pass"];
            r.Sw_admin = (int)dr["sw_admin"];
            r.Id_user = (int)dr["id_user"];
            r.Id_role = (int)dr["id_role"];
            r.Role_desc = (string)dr["role_desc"];
            r.Role_level = (int)dr["role_level"];
            return r;
        }
        private static Permission CastDataPermission(DataRow dr)
        {
            Permission r = new();
            r.Idmenu = (int)dr["id_menu"];
            r.Sw_status = (int)dr["sw_status"];
            r.Sw_create = (int)dr["sw_create"];
            r.Sw_edit = (int)dr["sw_edit"];
            r.Sw_delete = (int)dr["sw_delete"];
            r.Sw_view = (int)dr["sw_view"];
            r.Sw_homepage = (int)dr["sw_main"];
            r.Menu = (string)dr["menu"];
            r.Menu_link = (string)dr["menu_link"];
            r.Sw_display = (int)dr["sw_display"];
            return r;
        }
        public LogInDto Authentication(LogInModel Prm)
        {
            response = new();
            try
            {
                LogInData DataLogIn = new();

                var UserData = DataLogIn.QueryLogIn(Prm); // Consulta todos los datos en la Bd.

                var User = UserData.Rows; // Datos del usuario que se autentica.
                if (User.Count > 0)
                {
                    response.User = new();
                    response.User = CastDataLogIn(User[0]);

                    if (response.User.Sw_active == 1)
                    {
                        response.Success = true;
                        response.Message = "User exists.";

                        Prm.Id_user = response.User.Id_user;
                        Prm.Id_role = response.User.Id_role;

                        var UserPermission = DataLogIn.QueryPermissions(Prm);
                        if (UserPermission.Rows.Count > 0)
                        {
                            response.Permissions = new();
                            for (int i = 0; i < UserPermission.Rows.Count; i++)
                            {
                                Permission p = new();
                                p = CastDataPermission(UserPermission.Rows[i]);
                                response.Permissions.Add(p);
                            }
                        }
                        else
                        {
                            response.Success = true;
                            response.Message = "El usuario no tiene permisos.";
                        }
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = $"El usuario {Prm.User} Se encuentra inactivo. Contacte al administrador.";
                    }
                }
                else
                {
                    response.Success = false;
                    response.Message = $"No existe usuario {Prm.User}. Debe validar usuario y contraseña.";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }
    }
}
