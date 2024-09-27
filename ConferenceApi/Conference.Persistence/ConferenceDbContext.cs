using Microsoft.EntityFrameworkCore;
namespace Conference.Persistence
{
    public class ConferenceDbContext(DbContextOptions<ConferenceDbContext> options) : DbContext(options)
    {

    }
}
