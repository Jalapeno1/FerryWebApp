using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Price
    {
        public double Amount { get; set; }
        public Route ConnectedRoute { get; set; }
    }
}