using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class UserDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public UserResult User { get; set; }
        public List<UserResult> Users { get; set; }
    }
    public class UserResult
    {
        public int id_user { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int sw_active { get; set; }
        public int sw_admin { get; set; }
        public int sw_agent { get; set; }
        public int id_user_create { get; set; }
        public DateTime datetime_create { get; set; }
    }


}
