using Zasobaren.Domain.Entities.Base;

namespace Zasobaren.Domain.Entities;

public class Fridge : BaseEntity
{
    public required string Name { get; set; }
    
    public DateTime CreatedAt { get; init; }
    
    public DateTime? UpdatedAt { get; set; }
    
    
    // Foreign keys:
    
    public long OwnerId { get; set; }
    
    
    // Navigation properties:
    
    public User? Owner { get; set; }
}