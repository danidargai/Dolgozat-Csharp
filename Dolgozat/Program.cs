﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dolgozat
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
        

            // Egyéb szolgáltatások konfigurálása
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Middleware konfigurálása
        }
    }
}
