using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Code)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(p => p.Country)
            .WithMany()
            .HasForeignKey(p => p.CountryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(new City
            {
                Id = new Guid("30395D79-364F-4443-9EF7-A6F2B0DBF48F"),
                Name = "Dushanbe",
                Code = "DUS",
                CountryId = new Guid("2757E51B-80F6-4AEB-86DA-9369CCD9B8A1")
            },
            new City
            {
                Id = new Guid("4BDC5646-122F-425D-81B4-5A0E365366E8"),
                Name = "Khujand",
                Code = "KHU",
                CountryId = new Guid("2757E51B-80F6-4AEB-86DA-9369CCD9B8A1")
            });
    }
}