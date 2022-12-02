﻿using System;
using ASP.NET_Core_Web_App_MVC_.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ASP.NET_Core_Web_App_MVC_.Areas.Identity.IdentityHostingStartup))]
namespace ASP.NET_Core_Web_App_MVC_.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityApplicationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityApplicationDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityApplicationDbContext>();
            });
        }
    }
}