using CarTender.Business.Abstract;
using CarTender.Business.Concrete;
using CarTender.Core.Security.JWT;
using CarTender.DataAccess.Abstract;
using CarTender.DataAccess.Concrete.Dapper;
using CT.Common.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CT.Business
{
    public static class ServiceRegistration
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDAL, UserDAL>();
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddTransient<IQueueService, QueueService>();
        }
    }
}
