using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Auxillo.Business;
using Auxillo.Contract.BusinessContract;
using Auxillo.Contract.DataAccessContract;
using Auxillo.DataAccess.Repository;
using Auxillo.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Auxillo.API.Extensions;
//using Auxillo.API.Filters;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
using Auxillo.API.Controllers;
using Auxillo.Common;

namespace Auxillo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddAzureAdBearer(options => Configuration.Bind("AzureAd", options));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            // services.AddAutoMapper(typeof(Startup));

            var connectionString = Configuration["AppSettings:ConnectionString"];

            services.AddScoped<ITestUserService, TestUserService>();
            services.AddScoped<ITestDBClient, TestDBClient>(_ => new TestDBClient(connectionString));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped<ResponseFilterAttribute>();
            //services.AddScoped<ExceptionFilterAttribute>();
            services.AddScoped<ActiveDirectoryService>();

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            //app.ConfigureHTTPClient();
            var httpClient = new HttpClient(
            new HttpClientHandler()
            {
                Proxy = new WebProxy("http://proxy:8080") { UseDefaultCredentials = true }
            });

            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
