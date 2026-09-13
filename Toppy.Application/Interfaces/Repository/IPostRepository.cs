using Toppy.Domain.Entities.Posts;

namespace Toppy.Application.Interfaces.Repository;

public interface IPostRepository
{
    Task AddAsync(Post post, CancellationToken ct);
    Task<Post?> GetByIdAsync(int postId, CancellationToken ct);
    Task<List<Post>> GetByIdsAsync(List<int> postIds, CancellationToken ct);

    Task<List<Post>> GetUserPostsAsync(int userId, DateTime? beforeDate, int? beforeId, int limit, CancellationToken ct);

    Task<List<Post>> GetRepliesAsync(int postId, DateTime? beforeDate, int? beforeId, int limit, CancellationToken ct);
    Task<List<Post>> GetParentChainAsync(int postId, int maxDepth, CancellationToken ct);
    Task<Like?> GetLikeAsync(int userId, int postId, CancellationToken ct);
    Task AddLikeAsync(Like like, CancellationToken ct);
    void RemoveLike(Like like);
    Task<HashSet<int>> FilterLikedAsync(int userId, List<int> postIds, CancellationToken ct);

    // закладки
    Task<Bookmark?> GetBookmarkAsync(int userId, int postId, CancellationToken ct);
    Task AddBookmarkAsync(Bookmark bookmark, CancellationToken ct);
    void RemoveBookmark(Bookmark bookmark);
    Task<HashSet<int>> FilterBookmarkedAsync(int userId, List<int> postIds, CancellationToken ct);

    // репости
    Task<Post?> GetRepostAsync(int userId, int originalPostId, CancellationToken ct);
    Task<HashSet<int>> FilterRepostedAsync(int userId, List<int> postIds, CancellationToken ct);
}