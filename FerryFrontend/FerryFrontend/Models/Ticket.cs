using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Ticket
    {
        public Reservation ReservationForTicket { get; set; }
        public TicketType Type { get; set; }
        public Vehicle Transportation { get; set; }
        public Customer RefCustomer { get; set; }


    }
}