using Conference.Application.Domain.ConferenceRooms.Queries.ConferenceRooms;
using Conference.Core.Domain.ConferenceRooms.Common;
using Conference.Persistence.ApplicationDbContext;
using Microsoft.AspNetCore.Mvc;
namespace ConferenceApi.Domain.ConferenceRooms
{


    [ApiController]
    [Route("[controller]")]
    public class ConferenceRoomsController : ControllerBase
    {
        private readonly IConferenceRoomService _conferenceRoomService;

        public ConferenceRoomsController(IConferenceRoomService conferenceRoomService)
        {
            _conferenceRoomService = conferenceRoomService;
        }

        [HttpPost("addRoom")]
        public async Task<IActionResult> AddRoom([FromBody] ConferenceRoomDto roomDto)
        {
            var result = await _conferenceRoomService.AddRoomAsync(roomDto);
            return Ok(result);
        }

        [HttpPut("updateRoom/{id}")]
        public async Task<IActionResult> UpdateRoom(Guid id, [FromBody] ConferenceRoomDto roomDto)
        {
            var result = await _conferenceRoomService.UpdateRoomAsync(id, roomDto);
            return Ok(result);
        }

        [HttpDelete("deleteRoom/{id}")]
        public async Task<IActionResult> DeleteRoom(Guid id)
        {
            var result = await _conferenceRoomService.DeleteRoomAsync(id);
            return Ok(result);
        }

        [HttpGet("searchRooms")]
        public async Task<IActionResult> SearchRooms(DateTime date, int capacity)
        {
            var rooms = await _conferenceRoomService.SearchRoomsAsync(date, capacity);
            return Ok(rooms);
        }

        [HttpPost("bookRoom")]
        public async Task<IActionResult> BookRoom([FromBody] BookingRequestDto requestDto)
        {
            var result = await _conferenceRoomService.BookRoomAsync(requestDto);
            return Ok(result);
        }
    }
}
