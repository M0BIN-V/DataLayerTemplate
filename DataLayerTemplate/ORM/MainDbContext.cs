using Microsoft.EntityFrameworkCore;

namespace DataLayerTemplate.ORM;

internal class MainDbContext : DbContext
{
    #region DbSets

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
