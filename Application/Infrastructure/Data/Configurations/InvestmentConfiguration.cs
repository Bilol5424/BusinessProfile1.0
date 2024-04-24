using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
{
    public void Configure(EntityTypeBuilder<Investment> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Amount)
            .IsRequired();

        builder.Property(x => x.StartupId)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(255);

        builder.HasOne(p => p.Startup)
            .WithMany()
            .HasForeignKey(x => x.StartupId);

        builder.Property(x => x.InvestorId)
            .IsRequired();

        builder.HasOne(p => p.Investor)
            .WithMany()
            .HasForeignKey(x => x.InvestorId);
    }
}