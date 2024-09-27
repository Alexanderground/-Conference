using ConferenceCore.Domain.Models;

namespace Conference.Infrastructure.Core.Domain.ConferenceRooms.Common
{
    public interface IConferenceRoomRepository
    {
        Task<ConferenceRoom> AddRoom(ConferenceRoom room);
        Task<bool> UpdateRoom(int id, ConferenceRoom room);
        Task<bool> DeleteRoom(int id);
        Task<List<ConferenceRoom>> SearchAvailableRooms(DateTime date, TimeSpan startTime, TimeSpan endTime, int capacity);
        Task<(bool IsSuccess, decimal TotalCost)> BookRoom(Booking booking);
    }
}