using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.AggregatorService.Models
{
    public class AggregatedResponse
    {
        public object UserDetails { get; set; }
        public object Orders { get; set; }
    }
}
