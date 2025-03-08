using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Messenger.Persistance;

public static class PersistanceServicesRegistration
{
    public static IServiceCollection RegisterPersistanceServices(this IServiceCollection services,IConfiguration configuration)
    {
        return services;
    }
}
