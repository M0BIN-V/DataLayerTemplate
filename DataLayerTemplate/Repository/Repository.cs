using DataLayerTemplate.ORM;
using DataLayerTemplate.Services.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayerTemplate.Repository;

internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    readonly MainDbContext _context = ServiceManager
        .ServiceProvider.GetRequiredService<MainDbContext>();

    readonly DbSet<TEntity> _table;

    public Repository()
    {
        _table = _context.Set<TEntity>();
    }
}
