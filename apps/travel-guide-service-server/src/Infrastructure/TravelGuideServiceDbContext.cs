using Microsoft.EntityFrameworkCore;

namespace TravelGuideService.Infrastructure;

public class TravelGuideServiceDbContext : DbContext
{
    public TravelGuideServiceDbContext(DbContextOptions<TravelGuideServiceDbContext> options)
        : base(options) { }
}
