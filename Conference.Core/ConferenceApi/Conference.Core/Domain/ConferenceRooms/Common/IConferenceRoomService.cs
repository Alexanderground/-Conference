using Conference.Core.Domain.Bookings;
using Conference.Core.Domain.Services;
namespace Conference.Core.Domain.ConferenceRooms.Common
{
    public interface IConferenceRoomService
    {
        void AddRoom(ConferenceRoom room);
        void UpdateRoom(ConferenceRoom room);
        void DeleteRoom(int roomId);
        List<ConferenceRoom> GetAvailableRooms(DateTime date, int capacity);
        Booking BookRoom(int roomId, DateTime startTime, DateTime endTime, List<Service> services);

    }
}
