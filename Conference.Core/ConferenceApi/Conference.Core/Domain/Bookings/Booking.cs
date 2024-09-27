
using Conference.Core.Domain.ConferenceRooms;
using Conference.Core.Domain.Services;

namespace Conference.Core.Domain.Bookings
{
    public class Booking
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public List<Service> Services { get; set; }

        public decimal TotalCost { get; set; }




    }
}
