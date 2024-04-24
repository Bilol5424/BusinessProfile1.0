using Domain.Enum;
namespace Domain.Entities;

public class StartupFile : BaseEntity
{
    public required string FileName { get; set; }
    public required string FilePath { get; set; }
    public FileType FileType { get; set; }
    
    public Guid StartupId { get; set; }
    public Startup? Startup { get; set; }
}