using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoCyclist.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public decimal DestinationRating { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

        public decimal RouteRating { get; set; }

        public int CyclistId { get; set; }
        public Cyclist Cyclist { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}