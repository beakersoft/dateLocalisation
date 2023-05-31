using System;
using System.IO;
using System.Reflection;
using DateTimeLocalisation.Data;
using DateTimeLocalisation.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DateTimeLocalisation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("SavantDatabase");

            services.AddDbContext<DataContext>(
                options =>
                {
                    options.UseSqlServer(
                        connectionString,
                        opts =>
                        {
                            opts.CommandTimeout(30);
                            opts.EnableRetryOnFailure(3, TimeSpan.FromSeconds(2), null);
                        });
                });

            services.AddSwaggerGen(
                s =>
                {
                    s.SwaggerDoc(
                        "v1",
                        new OpenApiInfo
                        {
                            Title = "Test Date localisation",
                            Version = "v1",
                            Description = "Test Date localisation"
                        });
                    s.IncludeXmlComments(
                        Path.Combine(
                            AppContext.BaseDirectory,
                            Assembly.GetExecutingAssembly().GetName().Name + ".xml"));
                    s.SchemaGeneratorOptions.SchemaIdSelector = type => type.FullName;
                });

            services.AddControllers();


            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DateTimeLocalisation v1"));

            app.UseRouting();

            app.UseEndpoints(
                endpoints => { endpoints.MapControllers(); });
        }
    }
}