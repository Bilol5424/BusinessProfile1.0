namespace Contracts.Responses;

public class GetAllInvestorResponse
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

    public SingleAddressResponse? Address { get; set; }
}