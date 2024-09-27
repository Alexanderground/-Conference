using Conference.Core.Domain.ConferenceRooms;
using Conference.Infrastructure.Core.Domain.ConferenceRooms.Commom;
namespace Conference.Infrastructure.Core.Domain.ConferenceRooms.Common
{
    public class ConferenceRoomRepository : IConferenceRoomRepository
    {
        private readonly List<ConferenceRoom> _rooms = new List<ConferenceRoom>();

        public void AddRoom(ConferenceRoom room)
        {
            room.Id = _rooms.Count + 1;
            _rooms.Add(room);
        }

        public void UpdateRoom(ConferenceRoom room)
        {
            var existingRoom = _rooms.FirstOrDefault(r => r.Id == room.Id);
            if (existingRoom != null)
            {
                existingRoom.Name = room.Name;
                existingRoom.Capacity = room.Capacity;
                existingRoom.BaseRate = room.BaseRate;
                existingRoom.Services = room.Services;
            }
        }

        public void DeleteRoom(int roomId)
        {
            var room = _rooms.FirstOrDefault(r => r.Id == roomId);
            if (room != null)
            {
                _rooms.Remove(room);
            }
        }

        public ConferenceRoom GetRoom(int roomId)
        {
            return _rooms.FirstOrDefault(r => r.Id == roomId);
        }

        public List<ConferenceRoom> GetAvailableRooms(DateTime date, int capacity)
        {
            return _rooms.Where(r => r.Capacity >= capacity).ToList();
        }
    }
}

