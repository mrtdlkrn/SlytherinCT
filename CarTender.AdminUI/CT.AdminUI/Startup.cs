using Business.Abstract;
using Business.Concrete;
using CarTender.FluentValidation.DAL.AdminDAL.Login;
using Common.Abstract;
using Common.Concrete;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using CT.AdminUI.ExceptionHandler.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CarTender.AdminUI
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
            services.AddControllersWithViews();

            services.AddSingleton<IBaseAPIService, BaseAPIService>();
            services.AddSingleton<IMappingService, MappingService>();
            services.AddSingleton<IApiService, ApiManager>();
            services.AddSingleton<IApiRoutes, ApiRoutes>();

            services.AddHttpClient<BaseAPIService>(opt =>
            {
                opt.BaseAddress = new Uri(Configuration["apiAddress"]);
            });

            services.AddDependencyResolvers(new ICoreModule[]
             {
                new CoreModule()
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseStatusCodePagesWithRedirects("/Admin/Error");
            //    app.UseExceptionHandler("/Admin/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.ConfigureExceptionHandler();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Admin}/{action=Index}/{id?}");
            });
        }
    }
}
