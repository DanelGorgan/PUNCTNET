using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class PoiContext : DbContext
    {
        public PoiContext()
        {
        }

        public PoiContext(DbContextOptions<CityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Poi> Pois { get; set; }
    }
}
