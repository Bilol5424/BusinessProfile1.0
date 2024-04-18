namespace Domain.Entities;

public class Startup : BaseEntity
{

    public Guid AddressId { get; set; }
    public bool IsActive { get; set; }
    public required string FirstName { get; set; }
    public string? Description { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? Organization { get; set; }
    public required string Phone { get; set; }
    public required string Website { get; set; }
    public required string LinkedinProfile { get; set; }
    public required string SocialMediaProfiles { get; set; }
    
    /*ZipCode (Fk)
     StartupFinancialData (Fk)
    AddressID (Fk)
    Founderid (Fk)
    CategoryId (Fk)
    StatusId (Fk)*/

}