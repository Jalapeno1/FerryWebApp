using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Exceptions
{
    [Serializable]
    class VehicleCapacityException : ArgumentOutOfRangeException
    {
        public VehicleCapacityException(string message) : base(message)
        {

        }
    }
}