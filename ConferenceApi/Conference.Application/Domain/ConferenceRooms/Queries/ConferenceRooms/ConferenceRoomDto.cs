namespace Conference.Application.Domain.ConferenceRooms.Queries.ConferenceRooms
{
    public record ConferenceRoomDto
    {
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<ServiceDto> Services { get; set; }

        public decimal BaseRate { get; set; }
    }
}
