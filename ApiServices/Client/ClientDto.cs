using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Client
{
    public class ClientDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public AgentClient AgentClient { get; set; }
        public List<AgentClient> AgentClients { get; set; }

    }
    public class Client
    {
        public int id_client { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
        public int sw_active { get; set; }
    }

    public class AgentClient
    {
        public int id_client { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
        public DateTime last_contact { get; set; }
        public int contact_threshold_days { get; set; }
        public int sw_active { get; set; }
    }
}
