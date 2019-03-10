using System;
using GoCyclist.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GoCyclist.Areas.Identity.IdentityHostingStartup))]
namespace GoCyclist.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GoCyclistIdentityDbContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("GoCyclistIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<GoCyclistIdentityDbContext>();
            });
        }
    }
}