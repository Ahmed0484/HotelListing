using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Hotel
{
    public class GetHotelDto:BaseHotel
    {
        public int Id { get; set; }
        
    }
}
