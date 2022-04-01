﻿using Desk.Booking.Core.Entities;

namespace Desk.Booking.Core
{
    public class DeskBookingBusiness
    {
        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            return new DeskBookingResult
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                DateRequest = request.DateRequest
            };
        }
    }
}
