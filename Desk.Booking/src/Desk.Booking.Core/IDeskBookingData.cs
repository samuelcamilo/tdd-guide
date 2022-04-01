using Desk.Booking.Core.Entities;

namespace Desk.Booking.Core
{
    public interface IDeskBookingData
    {
        void Save(DeskBooking deskBooking);
    }
}
