using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class TicketType
    {
        public Price PriceOfTicket { get; set; }
    }
}