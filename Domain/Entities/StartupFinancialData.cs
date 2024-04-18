using Domain.Enum;
namespace Domain.Entities;

public class StartupFinancialData : BaseEntity
{
    public required int StartupId { get; set; }
    public required decimal CurrentValuation { get; set; } /*Текущая оценка*/
    public required string FundingRound { get; set; } /*ФинансированиеРаунд*/
    public required decimal TargetFundingAmount { get; set; } /*Целевая сумма финансирования*/
    public required decimal EquityOffered { get; set; } /*Предлагаемые акции*/
    public required StartupStage StageOfDevelopment { get; set; } /*СтадияРазвития*/
    public required DateTime FoundingDate { get; set; } /*Дата основания*/
    public required int RequiredInvestmentAmount { get; set; } /*Требуемая сумма инвестиций*/
}