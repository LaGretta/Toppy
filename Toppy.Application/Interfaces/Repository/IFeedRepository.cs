using Toppy.Domain.Entities.Feed;

namespace Toppy.Application.Interfaces.Repository;

public interface IFeedRepository
{
    Task<List<FeedEntry>> GetFeedAsync(int userId, DateTime? beforeDate, int? beforeId, int limit, CancellationToken ct);
    Task AddEntriesAsync(List<FeedEntry> entries, CancellationToken ct);
    Task RemovePostFromFeedsAsync(int postId, CancellationToken ct);
    Task TrimFeedAsync(int userId, int keepLatest, CancellationToken ct);
}