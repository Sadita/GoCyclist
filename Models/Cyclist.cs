using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;



namespace GoCyclist.Models
{
    public class Cyclist : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // public ICollection<Review> Reviews { get; set; }

    }
}