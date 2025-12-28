namespace Zasobaren.Domain.Entities;

public class FridgeInvite
{
    public DateTime CreatedAt { get; init; }
    
    public DateTime? AcceptedAt { get; set; }
    
    
    // Foreign keys:
    
    public long OwnerId { get; init; }
    
    public long InvitedUserId { get; init; }

    public long FridgeId { get; init; }
    

    // Navigation properties:
    
    public User? Owner { get; set; }

    public User? InvitedUser { get; set; }
    
    public Fridge? Fridge { get; set; }
}