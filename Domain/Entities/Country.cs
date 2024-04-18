namespace Domain.Entities;

public class Country : BaseEntity
{
    public required string Name { get; set; }
    public required int Code { get; set; }
    public required string Note { get; set; }
}