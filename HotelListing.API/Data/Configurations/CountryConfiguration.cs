using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, Name = "Egypt", ShortName = "EG" },
                new Country { Id = 2, Name = "United Arab Emirates", ShortName = "AE" },
                new Country { Id = 3, Name = "Morocco", ShortName = "MA" }
             );
        }
    }
}
