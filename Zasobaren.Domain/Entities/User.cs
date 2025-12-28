using Zasobaren.Domain.Entities.Base;

namespace Zasobaren.Domain.Entities;

public class User : BaseEntity
{
    public required string Username { get; set; }
    
    public required string Email { get; set; }
    
    public required byte[] Password { get; set; }
    
    public required byte[] Salt { get; set; }
    
    public DateTime CreatedAt { get; init; }
}