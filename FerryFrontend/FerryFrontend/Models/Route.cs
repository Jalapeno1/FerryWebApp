using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Route
    {
        public Departure RefDeparture { get; set; }
        public string Destination { get; set; }
        public TimeSpan Duration { get; set; }
    }
}