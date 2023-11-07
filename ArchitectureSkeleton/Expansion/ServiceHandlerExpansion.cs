using ArchitectureSkeleton.Contract;
using ArchitectureSkeleton.Handler;

namespace ArchitectureSkeleton.Expansion
{
    public static class ServiceHandlerExpansion
    {
        public static IServiceCollection AddHandler(this IServiceCollection services)
        {
            services.AddScoped<IProductHandler, ProductHandler>();
            return services;
        }
    }
}
