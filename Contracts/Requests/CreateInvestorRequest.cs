using System.Text.Json.Serialization;

namespace Contracts.Requests;

public class CreateInvestorRequest
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string Email { get; set; }
    [JsonIgnore] public Guid AddressId { get; set; }
    public bool IsActive { get; set; }
    public required string Organization { get; set; }
    public string? AboutMe { get; set; }
    public DateOnly BirthDate { get; set; }

    public CreateAddressRequest Address { get; set; }
}