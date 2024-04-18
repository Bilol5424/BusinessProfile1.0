using Domain.Enum;
namespace Domain.Entities;

public class StartupFile : BaseEntity
{
    public required string FileName { get; set; }
    public required string FilePath { get; set; } /*Путь к файлу*/
    public required FileType FileType { get; set; }
}



/*
 public  int StartupId { get; set; }
 Founderid (Fk)
 */