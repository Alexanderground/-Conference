using Conference.Core.Domain.Bookings;
using Conference.Core.Domain.ConferenceRooms;
using Conference.Core.Domain.ConferenceRooms.Common;
using Conference.Core.Domain.Services;
namespace Conference.Infrastructure.Core.Domain.ConferenceRooms.Commom
{

    public class ConferenceRoomService : IConferenceRoomService
    {
        private readonly IConferenceRoomRepository _repository;

        public ConferenceRoomService(IConferenceRoomRepository repository)
        {
            _repository = repository;
        }

        public void AddRoom(ConferenceRoom room)
        {
            _repository.AddRoom(room);
        }

        public void UpdateRoom(ConferenceRoom room)
        {
            _repository.UpdateRoom(room);
        }

        public void DeleteRoom(int roomId)
        {
            _repository.DeleteRoom(roomId);
        }

        public List<ConferenceRoom> GetAvailableRooms(DateTime date, int capacity)
        {
            return _repository.GetAvailableRooms(date, capacity);
        }

        public Booking BookRoom(int roomId, DateTime startTime, DateTime endTime, List<Service> services)
        {
            var room = _repository.GetRoom(roomId);
            if (room == null)
            {
                throw new Exception("Room not found");
            }
            var totalCost = room.BaseRate * (decimal)(endTime - startTime).TotalHours;
            totalCost += services.Sum(s => s.Cost);

            var booking = new Booking
            {
                RoomId = roomId,
                StartTime = startTime,
                EndTime = endTime,
                Services = services,
                TotalCost = totalCost
            };
            return booking;
        }

    }
}

