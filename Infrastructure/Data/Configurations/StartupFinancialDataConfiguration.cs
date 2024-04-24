using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class StartupFinancialDataConfiguration : IEntityTypeConfiguration<StartupFinancialData>
{
    public void Configure(EntityTypeBuilder<StartupFinancialData> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.StartupId)
            .IsRequired();

        builder.HasOne(p => p.Startup)
            .WithMany()
            .HasForeignKey(x => x.StartupId);
    }
}