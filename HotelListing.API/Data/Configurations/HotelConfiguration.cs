using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { Id = 1, Name = "One Hotel", Address = "Cairo", CountryId = 1, Rating = 5 },
                new Hotel { Id = 2, Name = "Sky Hotel", Address = "Dubai", CountryId = 2, Rating = 4.5 },
                new Hotel { Id = 3, Name = "Sun Hotel", Address = "Tangier", CountryId = 3, Rating = 4 }
              );
        }
    }
}
