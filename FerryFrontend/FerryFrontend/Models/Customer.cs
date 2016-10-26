using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Customer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //Three properties above wasn't in Data Model, but added because we've obviously missed something important here :)
        public enum ForeignerOrLocal { Foreigner, Local }
        public bool IsLocal { get; set; }

        public Customer(ForeignerOrLocal foreignerOrLocal)
        {
            if (foreignerOrLocal == ForeignerOrLocal.Local)
                IsLocal = true;
            else
                IsLocal = false; // Redundant, but reads more easily.
        }
    }
}