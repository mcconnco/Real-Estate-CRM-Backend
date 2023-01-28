using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCRM.ApiServices.Interests
{
    public class InterestsDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Interest Interest { get; set; }
        public List<Interest> Interests { get; set; }
    }
    public class Interest
    {
        public int id_interest { get; set; }
        public string interest_desc { get; set; }
        public int sw_active { get; set; }
    }
}

