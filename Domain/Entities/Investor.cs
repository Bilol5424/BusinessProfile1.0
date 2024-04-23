namespace Domain.Entities;

public class Investor : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string Email { get; set; }
    public Guid AddressId { get; set; }
    public bool IsActive { get; set; }
    public required string Organization { get; set; }
    public string? AboutMe { get; set; }
    public DateOnly BirthDate { get; set; }

    public Address? Address { get; set; }
    public List<Investment>? Investments { get; set; }
}