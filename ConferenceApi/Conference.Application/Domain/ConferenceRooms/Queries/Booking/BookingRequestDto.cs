using Conference.Application.Domain.ConferenceRooms.Queries.ConferenceRooms;

namespace Conference.Persistence.ApplicationDbContext
{
    public record BookingRequestDto
    {
        public Guid RoomId { get; set; }

        public DateTime Date { get; set; }

        public int Duration { get; set; }

        public List<ServiceDto> Services { get; set; }
    }
}
