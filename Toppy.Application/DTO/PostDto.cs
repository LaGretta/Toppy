using Toppy.Domain.Enums;

namespace Toppy.Application.DTO;

public class CreatePostDto
{
    public string Content { get; set; } = string.Empty;
    public int? ReplyToPostId { get; set; }
    public int? QuotedPostId { get; set; }
    public List<CreateMediaDto> Media { get; set; } = new();
}

public class CreateMediaDto
{
    public MediaType Type { get; set; }
    public string Url { get; set; } = string.Empty;
    public int? Width { get; set; }
    public int? Height { get; set; }
}

public class MediaDto
{
    public int Id { get; set; }
    public MediaType Type { get; set; }
    public string Url { get; set; } = string.Empty;
    public int? Width { get; set; }
    public int? Height { get; set; }
}

public class PostResponseDto
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public UserSummaryDto Author { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public bool IsEdited { get; set; }
    public bool IsDeleted { get; set; }

    public int LikeCount { get; set; }
    public int ReplyCount { get; set; }
    public int RepostCount { get; set; }
    public int QuoteCount { get; set; }
    public int ViewCount { get; set; }

    public bool LikedByMe { get; set; }
    public bool RepostedByMe { get; set; }
    public bool BookmarkedByMe { get; set; }

    public List<MediaDto> Media { get; set; } = new();

    public int? ReplyToPostId { get; set; }
    public string? ReplyToAuthorUserName { get; set; }

    public PostResponseDto? QuotedPost { get; set; }

    public UserSummaryDto? RepostedBy { get; set; }
}