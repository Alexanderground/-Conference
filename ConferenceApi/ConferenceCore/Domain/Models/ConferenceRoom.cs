namespace Conference.Infrastructure.Core.Domain.ConferenceRooms.Common
{
    internal class ConferenceRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int BaseHourlyRate { get; set; }
    }
}