using Desk.Booking.Core.Entities;
using System;
using Xunit;

namespace Desk.Booking.Core.Test
{
    public class DeskBookingBusinessTest
    {
        private readonly DeskBookingBusiness _business;

        public DeskBookingBusinessTest() 
            => _business = new DeskBookingBusiness();

        [Fact]
        public void ShouldReturnDeskBookingResult()
        {
            // arrange...
            var request = new DeskBookingRequest
            {
                FirstName = "Samuel",
                LastName = "Camilo",
                Email = "samuelcamilo@example.com",
                DateRequest = System.DateTime.Now
            };

            // act...
            DeskBookingResult result = _business.BookDesk(request);

            // assert...
            Assert.NotNull(result);
        }

        [Fact]
        public void ShouldThrowExceptionIfRequestisNull()
        {
            // act...
            var exception = Assert.Throws<ArgumentNullException>(() => _business.BookDesk(null));

            // assert...
            Assert.Equal("request", exception.ParamName);
        }
    }
}