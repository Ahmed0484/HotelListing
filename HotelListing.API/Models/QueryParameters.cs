namespace HotelListing.API.Models
{
    public class QueryParameters
    {
        public int PageSize { get; set; } = 15;
        public int StartIndex { get; set; }
        public int PageNumber { get; set; }
    }
}
