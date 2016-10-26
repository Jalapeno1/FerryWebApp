using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Exceptions
{
    [Serializable]
    public class PersonCapacityException : ArgumentOutOfRangeException
    {
        public PersonCapacityException(string message) : base(message)
        {

        }
    }
}