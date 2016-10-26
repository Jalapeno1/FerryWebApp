using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Exceptions
{
    [Serializable]
    public class WeightCapacityException : ArgumentOutOfRangeException
    {
        public WeightCapacityException(string message) : base(message)
        {

        }
    }
}