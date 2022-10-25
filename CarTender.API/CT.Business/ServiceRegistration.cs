using CarTender.Business.Abstract;
using CarTender.Business.Concrete;
using CarTender.Core.Security.JWT;
using CarTender.DataAccess.Abstract;
using CarTender.DataAccess.Concrete.Dapper;
using CT.Business.Abstract;
using CT.Business.Concrete;
using CT.Common.Service;
using CT.DataAccess.Abstract;
using CT.DataAccess.Concrete.Dapper;
using CT.DataAccess.Context;
using Microsoft.Extensions.DependencyInjection;

namespace CT.Business
{
    public static class ServiceRegistration
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddScoped<IAdvertService, AdvertManager>();
            services.AddScoped<IAdvertStatusHistoryService, AdvertStatusHistoryManager>();
            services.AddScoped<IAuthorizationService, AuthorizationManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IBidService, BidManager>();
            services.AddScoped<IBrandModelService, BrandModelManager>();
            services.AddScoped<ICarImageService, CarImageManager>();
            services.AddScoped<ICarSaleHistoryService, CarSaleHistoryManager>();
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarStatusHistoryService, CarStatusHistoryManager>();
            services.AddScoped<ICommissionService, CommissionManager>();
            services.AddScoped<ICorporateService, CorporateManager>();
            services.AddScoped<IExpertiseService, ExpertiseManager>();
            services.AddScoped<IMessageContentService, MessageContentManager>();
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<INeighborhoodService, NeighborhoodManager>();
            services.AddScoped<INotificationService, NotificationManager>();
            services.AddScoped<IPackageService, PackageManager>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IStatusService, StatusManager>();
            services.AddScoped<ITownService, TownManager>();
            services.AddScoped<ITramerService, TramerManager>();
            services.AddScoped<IUserService, UserManager>();


            services.AddScoped<IAdvertDAL, AdvertDAL>();
            services.AddScoped<IAdverStatusHistoryDAL, AdvertStatusHistoryDAL>();
            services.AddScoped<IAuthorizationDAL, AuthorizationDAL>();
            services.AddScoped<IBidDAL, BidDAL>();
            services.AddScoped<IBrandModelDAL, BrandModelDAL>();
            services.AddScoped<ICarDAL, CarDAL>();
            services.AddScoped<ICarImageDAL, CarImageDAL>();
            services.AddScoped<ICarSaleHistoryDAL, CarSaleHistoryDAL>();
            services.AddScoped<ICarStatusHistoryDAL, CarStatusHistoryDAL>();
            services.AddScoped<ICommissionDAL, CommissionDAL>();
            services.AddScoped<ICorporateDAL, CorporateDAL>();
            services.AddScoped<IExpertiseDAL, ExpertiseDAL>();
            services.AddScoped<IMessageContentDAL, MessageContentDAL>();
            services.AddScoped<IMessageDAL, MessageDAL>();
            services.AddScoped<INeighborhoodDAL, NeighborhoodDAL>();
            services.AddScoped<IPackageDAL, PackageDAL>();
            services.AddScoped<IRoleDAL, RoleDAL>();
            services.AddScoped<IStatusDAL, StatusDAL>();
            services.AddScoped<ITownDAL, TownDAL>();
            services.AddScoped<ITramerDAL, TramerDAL>();
            services.AddScoped<IUserDAL, UserDAL>();

            services.AddSingleton<CarTenderDbContext>();
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddTransient<IQueueService, QueueService>();
        }
    }
}
