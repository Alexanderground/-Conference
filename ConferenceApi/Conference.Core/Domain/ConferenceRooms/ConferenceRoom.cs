using Conference.Core.Domain.Services;

namespace Conference.Core.Domain.ConferenceRooms
{
    public class ConferenceRoom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Service> Services { get; set; }

        public decimal BaseRate { get; set; }

    }
}
