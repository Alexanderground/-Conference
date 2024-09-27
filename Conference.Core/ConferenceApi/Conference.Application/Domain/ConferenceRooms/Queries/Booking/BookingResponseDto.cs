namespace Conference.Persistence.ApplicationDbContext
{
    public record BookingResponseDto
    {
        public Guid BookingId { get; set; }

        public decimal TotalCost { get; set; }
    }
}
