namespace Contracts.Responses;

public class SingleAddressResponse
{
    public Guid CountryId { get; set; }
    public Guid CityId { get; set; }
    public string? House { get; set; }
    public required string Street { get; set; }
    public string? ApartmentNumber { get; set; }
}