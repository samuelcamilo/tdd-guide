using Desk.Booking.Core.Entities;
using Desk.Booking.Core.Interfaces;

namespace Desk.Booking.Core
{
    public class DeskBookingBusiness
    {
        private readonly IDeskBookingData _deskBookingData;

        public DeskBookingBusiness(IDeskBookingData deskBookingData)
            => _deskBookingData = deskBookingData;

        public DeskBookingResult BookDesk(DeskBookingRequest request)
        {
            if (request is null)
                throw new ArgumentNullException(nameof(request));

            _deskBookingData.Save(Create<DeskBooking>(request));

            return Create<DeskBookingResult>(request);
        }

        private static T Create<T>(DeskBookingRequest request) where T : DeskBookingBase, new()
        {
            return new T
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                DateRequest = request.DateRequest
            };
        }
    }
}
