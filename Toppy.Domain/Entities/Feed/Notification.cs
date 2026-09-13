using Toppy.Domain.Entities.Posts;
using Toppy.Domain.Entities.Users;
using Toppy.Domain.Enums;

namespace Toppy.Domain.Entities.Feed;

public class Notification
{
    public int Id { get; set; }

    public int UserId { get; set; }          
    public User User { get; set; } = null!;

    public int ActorId { get; set; }           
    public User Actor { get; set; } = null!;

    public NotificationType Type { get; set; }
    public int? PostId { get; set; }         
    public Post? Post { get; set; }

    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}