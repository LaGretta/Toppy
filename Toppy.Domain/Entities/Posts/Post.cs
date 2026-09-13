using Toppy.Domain.Entities.Users;

namespace Toppy.Domain.Entities.Posts;

public class Post
{
    public int Id { get; set; }
    
    public int AuthorId { get; set; }
    public User Author { get; set; } = null!;
    
    public string Content { get; set; } = string.Empty;
    
    public int? ReplyToPostId { get; set; }
    public Post? ReplyToPost { get; set; }

    public int? RepostOfPostId { get; set; }
    public Post? RepostOfPost { get; set; }

    public int? QuotedPostId { get; set; }
    public Post? QuotedPost { get; set; }

    public bool IsEdited { get; set; }
    public DateTime? EditedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }

    public int LikeCount { get; set; }
    public int ReplyCount { get; set; }
    public int RepostCount { get; set; }
    public int QuoteCount { get; set; }
    public int ViewCount { get; set; }

    public List<PostMedia> Media { get; set; } = new();
}