namespace Domain.Entities;

public class StartupCategory : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}