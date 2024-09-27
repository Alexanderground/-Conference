using Conference.Core.Domain.ConferenceRooms;

namespace Conference.Infrastructure.Core.Domain.ConferenceRooms.Commom
{
    public interface IConferenceRoomRepository
    {
        void AddRoom(ConferenceRoom room);

        void UpdateRoom(ConferenceRoom room);

        void DeleteRoom(int roomId);

        ConferenceRoom GetRoom(int roomId);

        List<ConferenceRoom> GetAvailableRooms(DateTime date, int capacity);

    }
}