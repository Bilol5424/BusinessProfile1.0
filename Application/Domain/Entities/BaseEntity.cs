namespace Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
}