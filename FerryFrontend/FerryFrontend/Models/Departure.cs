using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Departure
    {
        public Ferry SailingFerry { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}