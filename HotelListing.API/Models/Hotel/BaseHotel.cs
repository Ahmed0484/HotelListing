﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Hotel
{
    public abstract class BaseHotel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double? Rating { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
