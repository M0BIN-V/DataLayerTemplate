using DataLayerTemplate.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayerTemplate;

public static class DbUnitOfWorkBuilder
{
    public static IDbUnitOfWork Build()
    {
        return new DbUnitOfWork();
    }

    public static IServiceCollection AddDbUnitOfWork(this IServiceCollection services)
    {
        services.AddSingleton<IDbUnitOfWork, DbUnitOfWork>();
        return services;
    }
}
