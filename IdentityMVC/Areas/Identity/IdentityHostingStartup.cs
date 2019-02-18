using System;
using IdentityMVC.Areas.Identity.Data;
using IdentityMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: HostingStartup(typeof(IdentityMVC.Areas.Identity.IdentityHostingStartup))]
namespace IdentityMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<IdentityMVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityMVCContextConnection")));

                services.AddDefaultIdentity<IdentityMVCUser>()
                    .AddEntityFrameworkStores<IdentityMVCContext>();

            });

        }
    }
}