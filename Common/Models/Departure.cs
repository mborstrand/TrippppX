using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Departure
    {
        public string Name { get; set; }
        public string Line { get; set; }
        public string VehicleType { get; set; }
        public string StopID { get; set; }
        public string StopName { get; set; }
        public string DepartureTime { get; set; }
        public string DestinationName { get; set; }
        public string Track { get; set; }
        public string ForeGroundColor { get; set; }
        public string BackgroundColor { get; set; }
        public string JourneyID { get; set; }
    }
}
