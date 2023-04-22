using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Agent
{
    public class AgentDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public AgentResult Agent { get; set; }
    }

    public class AgentResult
    {
        public string agent_number { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
    }
}
