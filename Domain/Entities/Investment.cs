using Domain.Enum;
namespace Domain.Entities;

public class Investment : BaseEntity
{
    public required decimal Amount { get; set; }
    public DateTime InvestmentDate { get; set; }
    public required InvestmentStatus Status { get; set; }/**/
    public string Description { get; set; }
    public string? Notes { get; set; }
    public required InvestmentType Type { get; set; }

    /*public Startup Startup { get; set; }
    public Investor Investor { get; set; }*/
}