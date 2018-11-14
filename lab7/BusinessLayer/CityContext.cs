using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class CityContext : DbContext
    {
        public CityContext()
        {
        }

        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
    }
}
