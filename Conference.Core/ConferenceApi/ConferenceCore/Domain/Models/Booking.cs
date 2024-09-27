namespace ConferenceCore.Domain.Models
{
    public class Booking
    {
        public int RoomId { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }

        public List<string> SelectedServices { get; set; } = new List<string>();
    }
}
