using Desk.Booking.Core.Entities;
using Desk.Booking.Core.Interfaces;
using NSubstitute;
using System;
using Xunit;

namespace Desk.Booking.Core.Test
{
    public class DeskBookingBusinessTest
    {
        private readonly DeskBookingBusiness _business;
        private readonly DeskBookingRequest _request;

        private readonly IDeskBookingData _deskBookingData;

        public DeskBookingBusinessTest()
        {
            _request = new DeskBookingRequest
            {
                FirstName = "Samuel",
                LastName = "Camilo",
                Email = "samuelcamilo@example.com",
                DateRequest = System.DateTime.Now
            };

            _deskBookingData = Substitute.For<IDeskBookingData>();
            _business = new DeskBookingBusiness(_deskBookingData);
        }

        [Fact]
        public void ShouldReturnDeskBookingResult()
        {
            // act...
            DeskBookingResult result = _business.BookDesk(_request);

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

        [Fact]
        public void ShouldSaveDeskBooking()
        {
            // act...
            _business.BookDesk(_request);

            // assert...
            _deskBookingData.Received().Save(Arg.Any<DeskBooking>());
        }
    }
}