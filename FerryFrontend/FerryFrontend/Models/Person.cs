﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerryFrontend.Models
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}