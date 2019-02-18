using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudyTest.API.Areas.Identity.Data;
using StudyTest.API.Models;

[assembly: HostingStartup(typeof(StudyTest.API.Areas.Identity.IdentityHostingStartup))]
namespace StudyTest.API.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StudyTestAPIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("StudyTestAPIContextConnection")));

                services.AddDefaultIdentity<StudyTestAPIUser>()
                    .AddEntityFrameworkStores<StudyTestAPIContext>();
            });
        }
    }
}