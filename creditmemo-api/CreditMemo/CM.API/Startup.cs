using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CM.Business;
using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.DataAccess.Repository;
using CM.Model;
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
using CM.API.Extensions;
using CM.API.Filters;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
using CM.API.Controllers;
using CM.Common;

namespace CreditMemo
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

            services.AddScoped<IRecordStatusService, RecordStatusService>();
            services.AddScoped<IRecordStatusDBClient, RecordStatusDBClient>(_ => new RecordStatusDBClient(connectionString));

            services.AddScoped<IUserRolesService, UserRolesService>();
            services.AddScoped<IUserRolesDBClient, UserRolesDBClient>(_ => new UserRolesDBClient(connectionString));

            services.AddScoped<IYearMasterService, YearMasterService>();
            services.AddScoped<IYearMasterDBClient, YearMasterDBClient>(_ => new YearMasterDBClient(connectionString));

            services.AddScoped<IUserAccessRequestService, UserAccessRequestService>();
            services.AddScoped<IUserAccessRequestDBClient, UserAccessRequestDBClient>(_ => new UserAccessRequestDBClient(connectionString));

            services.AddScoped<IDepartment, Departments>();
            services.AddScoped<IDepartmentDBClient, DepartmentDBClient>(_ => new DepartmentDBClient(connectionString));

            services.AddScoped<ICreditApprovalLevel, CreditApprovalLevels>();
            services.AddScoped<ICreditApprovalLevelDBClient, CreditApprovalLevelDBClient>(_ => new CreditApprovalLevelDBClient(connectionString));

            services.AddScoped<IManageUser, ManageUser>();
            services.AddScoped<IManageUserDBClient, ManageUserDBClient>(_ => new ManageUserDBClient(connectionString));

            services.AddScoped<ILogActivityService, LogActivityService>();
            services.AddScoped<ILogActivityDBClient, LogActivityDBClient>(_ => new LogActivityDBClient(connectionString));

            services.AddScoped<ILogErrorService, LogErrorService>();
            services.AddScoped<ILogErrorDBClient, LogErrorDBClient>(_ => new LogErrorDBClient(connectionString));

            services.AddScoped<ICreditMemoInfoService, CreditMemoInfoService>();
            services.AddScoped<ICreditMemoInfoDBClient, CreditMemoInfoDBClient>(_ => new CreditMemoInfoDBClient(connectionString));

            services.AddScoped<ICreditMemoModelDetailsService, CreditMemoModelDetailsSerivce>();
            services.AddScoped<ICreditMemoModelDetailsDBClient, CreditMemoModelDetailsDBClient>(_ => new CreditMemoModelDetailsDBClient(connectionString));

            services.AddScoped<ICreditMemoProductDetailsService, CreditMemoProductDetailsSerivce>();
            services.AddScoped<ICreditMemoProductDetailsDBClient, CreditMemoProductDetailsDBClient>(_ => new CreditMemoProductDetailsDBClient(connectionString));

            services.AddScoped<ICreditMemoAttachmentDetailsService, CreditMemoAttachmentDetailsSerivce>();
            services.AddScoped<ICreditMemoAttachmentDetailsDBClient, CreditMemoAttachmentDetailsDBClient>(_ => new CreditMemoAttachmentDetailsDBClient(connectionString));

            services.AddScoped<IPlant, Plants>();
            services.AddScoped<IPlantDBClient, PlantDBClient>(_ => new PlantDBClient(connectionString));

            services.AddScoped<ICreditMemoTrackingRecord, CreditMemoTrackingRecord>();
            services.AddScoped<ICreditMemoTrackingDBClient, CreditMemoTrackingDBClient>(_ => new CreditMemoTrackingDBClient(connectionString));

            services.AddScoped<ICreditMemoAmountDivisionDetail, CreditMemoAmountDivisionDetails>();
            services.AddScoped<ICreditMemoAmountDivisionDetailDBClient, CreditMemoAmountDivisionDetailDBClient>(_ => new CreditMemoAmountDivisionDetailDBClient(connectionString));

            services.AddScoped<ICreditMemoReason, CreditMemoReason>();
            services.AddScoped<ICreditMemoReasonDBClient, CreditMemoReasonDBClient>(_ => new CreditMemoReasonDBClient(connectionString));

            services.AddScoped<ICreditMemoErrorCode, CreditMemoErrorCode>();
            services.AddScoped<ICreditMemoErrorCodeDBClient, CreditMemoErrorCodeDBClient>(_ => new CreditMemoErrorCodeDBClient(connectionString));

            services.AddScoped<IMacPacErrorCode, MacPacErrorCodes>();
            services.AddScoped<IMacPacErrorCodeDBClient, MacPacErrorCodeDBClient>(_ => new MacPacErrorCodeDBClient(connectionString));

            services.AddScoped<ICreditMemoApprovalStatus, CreditMemoApprovalsStatus>();
            services.AddScoped<ICreditMemoApprovalStatusDBClient, CreditMemoApprovalStatusDBClient>(_ => new CreditMemoApprovalStatusDBClient(connectionString));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ResponseFilterAttribute>();
            services.AddScoped<ExceptionFilterAttribute>();
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
