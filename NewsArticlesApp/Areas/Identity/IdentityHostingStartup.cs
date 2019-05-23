using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewsArticlesApp.Models;

[assembly: HostingStartup(typeof(NewsArticlesApp.Areas.Identity.IdentityHostingStartup))]
namespace NewsArticlesApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<NewsArticlesAppIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("NewsArticlesAppIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<NewsArticlesAppIdentityContext>();
            });
        }
    }
}