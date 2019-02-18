using IdentityMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityMVC.Areas.Admin.AdminHostingStartup))]
namespace IdentityMVC.Areas.Admin
{
    public class AdminHostingStartup: IHostingStartup
    {

        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MYDataDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MYDataDBContextConnection")));

                //services.AddDefaultIdentity<Users>()
                //    .AddEntityFrameworkStores<MYDataDBContext>();
            });
        }
    }
}
