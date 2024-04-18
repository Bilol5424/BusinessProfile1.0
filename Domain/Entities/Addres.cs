namespace Domain.Entities;

public class Addres : BaseEntity
{
    public required string Country { get; set; }
    public required string City { get; set; }
    public string? House { get; set; }
    public required string Street { get; set; }
    public string? ApartmentNumber { get; set; }
    public required string Note { get; set; }
}