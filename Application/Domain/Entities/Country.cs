namespace Domain.Entities;

public class Country : BaseEntity
{
    public required string Code { get; set; }
    public required string Name { get; set; }
}