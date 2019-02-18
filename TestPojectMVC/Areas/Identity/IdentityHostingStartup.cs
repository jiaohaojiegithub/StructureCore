using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestPojectMVC.Models;

[assembly: HostingStartup(typeof(TestPojectMVC.Areas.Identity.IdentityHostingStartup))]
namespace TestPojectMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<TestPojectDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TestPojectDBContextConnection")));

                services.AddIdentity<Users,IdentityRole>()
                    .AddEntityFrameworkStores<TestPojectDBContext>()
                    .AddDefaultTokenProviders();

            });
        }
    }
}
