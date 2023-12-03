using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataLayerTemplate.Entities;

namespace DataLayerTemplate.ORM.EntityConfigurations;

internal class ProductConfiguration : IEntityTypeConfiguration<MyEntity>
{
    public void Configure(EntityTypeBuilder<MyEntity> builder)
    {

    }
}
