using Microsoft.EntityFrameworkCore;
using RelationalesSample.Models;

namespace RelationalesSample.Data
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext(DbContextOptions<GeoDbContext> options)
            : base(options)
        {

        }

        public DbSet<Continent> Continents { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<LanguageInCountry> LagnaugesInCountries { get; set; }
    }
}
