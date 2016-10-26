using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Reservation
    {
        public Departure RefDeparture { get; set; }
        public int ReservationNumber { get; set; }
        public bool HasArrived { get; set; }

    }
}