using Toppy.Domain.Entities.Users;

namespace Toppy.Domain.Entities.Social;

public class Follow
{
    public int Id { get; set; }
    
    public int FollowerId { get; set; }
    public User Follower { get; set; } = null!;
    
    public int FollowingId { get; set; }
    public User Following { get; set; } = null!;
    
    public DateTime CreatedAt { get; set; }
}