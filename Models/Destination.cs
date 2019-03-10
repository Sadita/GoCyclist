using System;
using System.ComponentModel.DataAnnotations;

namespace GoCyclist.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string DestinationName { get; set; }

        // [DataType(DataType.Date)]
        // public DateTime ReleaseDate { get; set; }
        public string Route { get; set; }

        [Display(Name = "Rating")]
        public decimal DestinationRating { get; set; }

        [Display(Name = "Route Difficulty")]
        public decimal RouteRating { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Description { get; set; }

    }
}