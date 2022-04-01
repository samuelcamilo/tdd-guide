using Desk.Booking.Core.Entities;
using Xunit;

namespace Desk.Booking.Core.Test
{
    public class DeskBookingBusinessTest
    {
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

            var business = new DeskBookingBusiness();

            // act...
            DeskBookingResult result = business.BookDesk(request);

            // assert...
            Assert.NotNull(result);
        }
    }
}