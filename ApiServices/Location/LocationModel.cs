using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Location
{
    public class LocationModel
    {
        public string operation { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string x_coordinate { get; set; }
        public string y_coordinate { get; set; }
    }
}
