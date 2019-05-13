using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using foodDeliveryBack.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace fooddeliveryback
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var cc= _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<FoodDeliveryContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddCors(options => 
            {
                options.AddPolicy("CorsConfig",
                    builder => builder.WithOrigins(_configuration["AllowedCorsOrigins"])
                                        .AllowAnyHeader()
                                        .AllowAnyMethod());
            });

            services.AddScoped<IFoodDeliveryRepository,FoodDeliveryRepository>();
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // app.UseHsts();
            }

            app.UseCors("CorsConfig");
            // app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
