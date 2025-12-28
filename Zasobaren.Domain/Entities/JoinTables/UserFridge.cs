namespace Zasobaren.Domain.Entities.JoinTables;

public class UserFridge
{
    // Foreign keys:
    
    public long UserId { get; set; }
    
    public long FridgeId { get; set; }
}