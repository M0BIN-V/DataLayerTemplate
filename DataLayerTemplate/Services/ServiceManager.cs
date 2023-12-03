using Microsoft.Extensions.DependencyInjection;
using DataLayerTemplate.ORM;

namespace DataLayerTemplate.Services.Data;

internal static class ServiceManager
{
    public static ServiceProvider ServiceProvider
    {
        get
        {
            if (_serviceProvider is null)
                BuildServiceProvider();
            return _serviceProvider!;
        }
    }
    static ServiceProvider _serviceProvider = null!;

    static void BuildServiceProvider()
    {
        var services = GetServices();

        _serviceProvider = services.BuildServiceProvider();
    }

    public static ServiceCollection GetServices()
    {
        var services = new ServiceCollection();

        //Add services

        services.AddDbContext<MainDbContext>();

        return services;
    }
}
