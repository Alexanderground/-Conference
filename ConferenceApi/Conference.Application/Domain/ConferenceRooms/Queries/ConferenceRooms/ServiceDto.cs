namespace Conference.Application.Domain.ConferenceRooms.Queries.ConferenceRooms
{
    public record ServiceDto
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }


        public static explicit operator ServiceDto(List<ServiceDto> v)
        {
            throw new NotImplementedException();
        }
    }
}
