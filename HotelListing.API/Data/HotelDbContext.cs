using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
            new Country { Id=1,Name="Egypt",ShortName="EG"},
            new Country { Id = 2,Name = "United Arab Emirates", ShortName = "AE" },
            new Country { Id = 3,Name = "Morocco", ShortName = "MA" }
                );
            modelBuilder.Entity<Hotel>().HasData(
              new Hotel { Id=1,Name="One Hotel",Address="Cairo",CountryId=1,Rating=5},
              new Hotel { Id = 2, Name = "Sky Hotel", Address = "Dubai", CountryId = 2, Rating = 4.5 },
              new Hotel { Id = 3, Name = "Sun Hotel", Address = "Tangier", CountryId = 3, Rating = 4 }
                );
        }
    }
}
