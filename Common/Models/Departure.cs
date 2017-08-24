using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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

        #region Object List.     
        public static ObservableCollection<Departure> DepartureList = new ObservableCollection<Departure>
        {
            new Departure { Line = "7", DestinationName = "Tynnered" },
            new Departure { Line = "13", DestinationName = "CentralStation" },
            new Departure { Line = "10", DestinationName = "Brunnsparken" },
            new Departure { Line = "5", DestinationName = "Östra Sjukhuset" },
            new Departure { Line = "2", DestinationName = "Korsvägen" },
            new Departure { Line = "4", DestinationName = "Mölndal" },
            new Departure { Line = "10", DestinationName = "Guldheden" },
            new Departure { Line = "8", DestinationName = "Angered" },
            new Departure { Line = "6", DestinationName = "Sahlgenska" },
            new Departure { Line = "6", DestinationName = "Kortedala" },
        };
        #endregion

    }
}
