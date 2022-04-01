﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Booking.Core.Entities
{
    public class DeskBookingRequest
    {
        public long Id { get; set; }
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? Email { get; set;}
        public DateTime DateRequest { get; set; }
    }
}
