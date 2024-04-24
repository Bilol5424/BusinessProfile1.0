using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class StartupCategoryConfiguration : IEntityTypeConfiguration<StartupCategory>
{
    public void Configure(EntityTypeBuilder<StartupCategory> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}