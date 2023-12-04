using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataLayerTemplate.Entities;

namespace DataLayerTemplate.ORM.EntityConfigurations;

internal class MyDtoConfiguration : IEntityTypeConfiguration<MyDto>
{
    public void Configure(EntityTypeBuilder<MyDto> builder)
    {

    }
}
