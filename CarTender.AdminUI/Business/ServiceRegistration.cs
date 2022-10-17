using Business.Abstract;
using Business.Concrete;
using Common.Abstract;
using Common.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class ServiceRegistration
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<IBaseAPIService, BaseAPIService>();
            services.AddSingleton<IMappingService, MappingService>();
            services.AddSingleton<IApiService, ApiManager>();
            services.AddSingleton<IApiRoutes, ApiRoutes>();
        }
    }
}
