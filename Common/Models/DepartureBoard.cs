using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Common.Models
{
    public class DepartureBoard
    {
        public string ServerDate { get; set; }
        public string ServerTime { get; set; }
        public IEnumerable<Departure> Departures { get; set; }
    }
}
