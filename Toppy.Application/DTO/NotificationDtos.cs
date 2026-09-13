using Toppy.Domain.Enums;

namespace Toppy.Application.DTO;

public class NotificationDto
{
    public int Id { get; set; }
    public NotificationType Type { get; set; }
    public UserSummaryDto Actor { get; set; } = null!;
    public PostResponseDto? Post { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}