using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDetailsDto :BaseCountry
    {
        public int Id { get; set; }

        public virtual IList<GetHotelDto> Hotels { get; set; }
    }
}
