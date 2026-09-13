using Toppy.Domain.Entities.Feed;

namespace Toppy.Application.Interfaces.Repository;

public interface INotificationRepository
{
    Task AddAsync(Notification notification, CancellationToken ct);
    Task<List<Notification>> GetForUserAsync(int userId, DateTime? beforeDate, int? beforeId, int limit, CancellationToken ct);
    Task<int> GetUnreadCountAsync(int userId, CancellationToken ct);
    Task MarkAllAsReadAsync(int userId, CancellationToken ct);
}

