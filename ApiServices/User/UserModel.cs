using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class UserModel
    {
        public string agent_number { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_user_create { get; set; }
        public int sw_admin { get; set; }
        public int sw_agent { get; set; }
    }
    public class User
    {
        public int id_user { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int sw_active { get; set; }
        public int sw_change_pass { get; set; }
        public int id_user_mod { get; set; }
    }
    public class UserDelete
    {
        public int id_user { get; set; }
        public int id_user_mod { get; set; }
    }
}
