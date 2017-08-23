using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class LocationList
    {
        public string noNamespaceSchemaLocation { get; set; }
        public string servertime { get; set; }
        public string serverdate { get; set; }
        public List<StopLocation> StopLocation { get; set; }
        public List<CoordLocation> CoordLocation { get; set; }
    }
}
