using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoCyclist.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Route { get; set; }

        [Display(Name = "Rating")]
        public decimal DestinationRatingAvg { get; set; }

        [Display(Name = "Route Difficulty")]
        public decimal RouteRatingAvg { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Description { get; set; }

        public ICollection<Review> Reviews { get; set; }

    }
}