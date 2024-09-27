//using Microsoft.AspNetCore.Mvc;
//using Conference.Core.Domain.Bookings;
//using Conference.Persistence;
//using Conference.Core.Domain.ConferenceRooms;
//namespace ConferenceApi.Domain.Bookings
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class BookingsController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public BookingsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpPost]
//        public async Task<IActionResult> BookRoom(Booking booking)
//        {
//            var room = await _context.Rooms.FindAsync(booking.RoomId);
//            if (room == null) return NotFound();

//            booking.TotalPrice = CalculateTotalPrice(room, booking);
//            _context.Bookings.Add(booking);
//            await _context.SaveChangesAsync();

//            return Ok(new { BookingId = booking.Id, TotalPrice = booking.TotalPrice, Message = "Бронювання успішно створено" });
//        }

//        private decimal CalculateTotalPrice(ConferenceRoom room, Booking booking)
//        {
//            decimal totalPrice = room.BasePricePerHour * (decimal)(booking.EndTime - booking.StartTime).TotalHours;
//            foreach (var service in booking.Services)
//            {
//                totalPrice += service.Price;
//            }
//            return totalPrice;
//        }
//    }

//}
