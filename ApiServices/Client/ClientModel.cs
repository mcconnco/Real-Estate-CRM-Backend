using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Client
{
    public class ClientModel
    {
        public int id_agent { get; set; }
        public int id_client { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phone_num { get; set; }
        public int sw_active { get; set; }
    }
}
