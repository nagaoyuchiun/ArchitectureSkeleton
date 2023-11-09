using ArchitectureSkeleton.Contract.Handler;

namespace ArchitectureSkeleton.Expansion
{
    public static class ServiceHandlerExpansion
    {
        public static IServiceCollection AddHandler(this IServiceCollection services)
        {
            return services;
        }
    }
}
