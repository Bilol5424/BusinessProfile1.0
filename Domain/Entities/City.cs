namespace Domain.Entities;

public class City : BaseEntity
{
    public required string Code { get; set; }
    public Guid CountryId { get; set; }
    public required string Name { get; set; }
    
    public Country? Country { get; set; }
}