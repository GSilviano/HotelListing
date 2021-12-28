using HotelListing.Controllers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 80, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }
        [Required]
        [Range(1, 5)]
        public float Rating { get; set; }
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "Address is too long")]
        public string Address { get; set; }
        [Required]
        public int CountryId { get; set; }
    }

    public class HotelDTO:CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
