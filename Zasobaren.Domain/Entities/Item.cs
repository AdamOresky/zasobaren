using Zasobaren.Domain.Entities.Base;
using Zasobaren.Domain.Enums;

namespace Zasobaren.Domain.Entities;

public class Item : BaseEntity
{
    public required string Name { get; set; }
    
    public int Quantity { get; set; }
    
    public DateTime AddedAt { get; init; }
    
    public DateTime? ExpiresAt { get; init; }

    public ItemStateEnum State { get; set; }
    
    
    // Foreign keys:
    
    public long FridgeId { get; set; }
    
    public long AddedById { get; init; }
}