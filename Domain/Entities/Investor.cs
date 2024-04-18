namespace Domain.Entities;

public class Investor : BaseEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    /*public Guid AddressId { get; set; }*/
    public bool IsActive { get; set; }
    public required string Organization { get; set; }
    public string? AboutMe { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateOnly DateOfBirth { get; set; }

}
/*Investor
    Startup
Addres
Investment
InvestmentStatus
StartupCategory
StartupFile
StartupFinancialData
User
*/