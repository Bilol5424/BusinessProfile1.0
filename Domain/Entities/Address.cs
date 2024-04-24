namespace Domain.Entities;

public class Address : BaseEntity
{
    public Guid CountryId { get; set; }
    public Guid CityId { get; set; }
    public string? House { get; set; }
    public required string Street { get; set; }
    public string? ApartmentNumber { get; set; }

    public Country? Country { get; set; }
    public City? City { get; set; }
}