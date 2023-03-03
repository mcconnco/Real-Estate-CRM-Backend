using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class AgentModel 
    {
        public int id_agent { get; set; }
        public int id_user { get; set; }
        public string agent_number { get; set; }

        public string sw_active { get; set; }
    }

    public class AgentClientModel
    {
        public int id_agent { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
    }
}
