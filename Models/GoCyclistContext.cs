using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoCyclist.Models
{
    public class GoCyclistContext : DbContext
    {
        public GoCyclistContext (DbContextOptions<GoCyclistContext> options)
            : base(options)
        {
        }

        public DbSet<GoCyclist.Models.Destination> Destinations { get; set; }
    }
}