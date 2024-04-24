using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class StartupConfiguration : IEntityTypeConfiguration<Startup>
{
    public void Configure(EntityTypeBuilder<Startup> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.StartupCategoryId)
            .IsRequired();

        builder.HasOne(p => p.StartupCategory)
            .WithMany()
            .HasForeignKey(x => x.StartupCategoryId);
    }
}