using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApi.ApiServices.Login
{
    public class LogInDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public UserLogin User { get; set; }
        public string Token { get; set; }
        public List<Permission> Permissions { get; set; }
    }
    public class UserLogin
    {
        public string First_name { get; set; }
        public int Sw_active { get; set; }
        public int Sw_change_pass { get; set; }
        public int Sw_admin { get; set; }
        public int Id_user { get; set; }
        public int Id_role { get; set; }
        public string Role_desc { get; set; }
        public int Role_level { get; set; }
        public int Id_agent { get; set; }
        public string Agent_Number { get; set; }
    }

    public class Permission
    {
        public int Idmenu { get; set; }
        public int Sw_status { get; set; }
        public int Sw_create { get; set; }
        public int Sw_edit { get; set; }
        public int Sw_delete { get; set; }
        public int Sw_view { get; set; }
        public int Sw_homepage { get; set; }
        public string Menu { get; set; }
        public string Menu_link { get; set; }
        public int Sw_display { get; set; }
    }
}
