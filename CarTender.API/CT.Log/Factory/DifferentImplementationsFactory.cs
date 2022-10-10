using Microsoft.Extensions.DependencyInjection;

namespace CT.Log.Factory
{
    public static class DifferentImplementationsFactoryExtension
    {
        public static void AddVehicleFactory(this IServiceCollection services)
        {
            /*services.AddTransient<IVehicle, Car>();
            services.AddTransient<IVehicle, Van>();
            services.AddTransient<IVehicle, Truck>();
            services.AddSingleton<Func<IEnumerable<IVehicle>>>(x => () => x.GetService<IEnumerable<IVehicle>>()!);
            services.AddSingleton<IVehicleFactory, VehicleFactory>();*/
        }
    }
}
