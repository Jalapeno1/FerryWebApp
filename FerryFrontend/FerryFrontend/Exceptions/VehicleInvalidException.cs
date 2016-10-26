using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Exceptions
{
    [Serializable]
    public class VehicleInvalidException : ArgumentException
    {
        public VehicleInvalidException(string message) : base(message)
        {

        }
    }
}