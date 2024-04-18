namespace Domain.Entities;

public class City : BaseEntity
{
    public required string Country { get; set; }
    public required string Name { get; set; }
    public required int Code { get; set; }
    public required string Note { get; set; }
}