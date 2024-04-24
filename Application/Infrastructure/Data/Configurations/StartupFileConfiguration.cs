using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class StartupFileConfiguration : IEntityTypeConfiguration<StartupFile>
{
    public void Configure(EntityTypeBuilder<StartupFile> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.FilePath)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.FileName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.StartupId)
            .IsRequired();

        builder.HasOne(p => p.Startup)
            .WithMany()
            .HasForeignKey(p => p.StartupId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}