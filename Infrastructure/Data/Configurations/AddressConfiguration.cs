using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.CityId)
            .IsRequired();

        builder.Property(x => x.House)
            .HasMaxLength(100);

        builder.Property(x => x.ApartmentNumber)
            .HasMaxLength(100);

        builder.Property(x => x.CountryId)
            .IsRequired();

        builder.HasOne(a => a.City)
            .WithMany()
            .HasForeignKey(a => a.CityId);

        builder.HasOne(x => x.Country)
            .WithMany()
            .HasForeignKey(x => x.CountryId);
    }
}