namespace Domain.Entities;

public class Startup : BaseEntity
{
    public Guid AddressId { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string? Organization { get; set; }
    public required string Phone { get; set; }
    public string? Website { get; set; }
    public string? LinkedinProfile { get; set; }
    public string? SocialMediaProfiles { get; set; }
    public Guid StartupCategoryId { get; set; }

    public Address? Address { get; set; }
    public StartupCategory? StartupCategory { get; set; }
    public List<Investment>? Investments { get; set; }
}