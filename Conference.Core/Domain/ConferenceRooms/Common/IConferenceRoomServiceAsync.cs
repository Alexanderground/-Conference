namespace Conference.Core.Domain.ConferenceRooms.Common
{
    internal interface IConferenceRoomServiceAsync
    {
        Task<ConferenceRoomDto> AddRoomAsync(ConferenceRoomDto roomDto);

        Task<ConferenceRoomDto> UpdateRoomAsync(Guid id, ConferenceRoomDto roomDto);

        Task<bool> DeleteRoomAsync(Guid id);

        Task<IEnumerable<ConferenceRoomDto>> SearchRoomsAdosasync(DateTime date, int capacity);

        Task<BookingResultDto> BookRoomAsync(BookingRequestDto requestDto);


    }
}
