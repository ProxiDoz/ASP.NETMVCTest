using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Reports
    { 
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool FirstParameter { get; set; }
        public bool SecondParameter { get; set; }
        public bool ThirdParameter { get; set; }
    }
}
