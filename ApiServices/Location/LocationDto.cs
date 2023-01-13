using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Location
{
    public class LocationDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Location Location { get; set; }
        public List<Location> Locations { get; set; }
    }
    public class Location
    {
        public int id_location { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string x_coordinate { get; set; }
        public string y_coordinate { get; set; }
        public int location_sales { get; set; }
        public decimal location_revenue { get; set; }
    }

}
