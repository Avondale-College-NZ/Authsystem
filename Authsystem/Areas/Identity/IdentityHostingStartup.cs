using System;
using Authsystem.Areas.Identity.Data;
using Authsystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Authsystem.Areas.Identity.IdentityHostingStartup))]
namespace Authsystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthsystemDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthsystemDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                })
                    .AddEntityFrameworkStores<AuthsystemDbContext>();

        });
        }
    }
}