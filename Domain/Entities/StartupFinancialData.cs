using Domain.Enum;

namespace Domain.Entities;

public class StartupFinancialData : BaseEntity
{
    public Guid StartupId { get; set; }
    public decimal CurrentValuation { get; set; }
    public required string FundingRound { get; set; }
    public required StartupStage StageOfDevelopment { get; set; }
    public int RequiredInvestmentAmount { get; set; }
    
    public Startup? Startup { get; set; }
}