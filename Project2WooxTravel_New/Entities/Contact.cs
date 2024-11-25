﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel_New.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MapLocation { get; set; } 
    }
}