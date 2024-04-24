using Domain.Enum;

namespace Domain.Entities;

public class Investment : BaseEntity
{
    public Guid StartupId { get; set; }
    public Guid InvestorId { get; set; }
    public decimal Amount { get; set; }
    public DateTime InvestmentDate { get; set; }
    public InvestmentStatus Status { get; set; }
    public required InvestmentType Type { get; set; }
    public string? Description { get; set; }

    public Startup? Startup { get; set; }
    public Investor? Investor { get; set; }
}