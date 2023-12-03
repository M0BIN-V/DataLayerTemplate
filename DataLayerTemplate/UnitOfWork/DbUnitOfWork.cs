using DataLayerTemplate.ORM;
using DataLayerTemplate.Services.Data;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayerTemplate.UnitOfWork;

internal class DbUnitOfWork() : IDbUnitOfWork
{
    readonly MainDbContext _dbContext = ServiceManager.ServiceProvider.GetRequiredService<MainDbContext>();

    public void SaveChanges()
    {
        _dbContext.SaveChanges();
    }
}
