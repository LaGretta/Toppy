using Toppy.Domain.Entities.Social;
using Toppy.Domain.Entities.Users;

namespace Toppy.Application.Interfaces.Repository;

public interface IFollowRepository
{
    Task<Follow?> GetAsync(int followerId, int followingId,CancellationToken ct);
    Task AddAsync(Follow follow, CancellationToken ct);
    void Remove(Follow follow);
    
    Task<bool>  IsFollowingAsync(int followerId,int followingId ,CancellationToken ct);
    Task<HashSet<int>> FilterFollowedAsync(int followerId, List<int> userIds, CancellationToken ct);

    Task<List<int>> GetFollowerIdsAsync(int userId, CancellationToken ct);
    Task<(List<User> items, int totalCount)> GetFollowersAsync(int userId, int page, int pageSize, CancellationToken ct);
    Task<(List<User> items, int totalCount)> GetFollowingAsync(int userId, int page, int pageSize, CancellationToken ct);
}