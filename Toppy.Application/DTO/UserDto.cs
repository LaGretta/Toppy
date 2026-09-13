namespace Toppy.Application.DTO;

public class UserProfileDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    public string? BannerUrl { get; set; }
    public string? Location { get; set; }
    public string? Website { get; set; }
    public bool IsVerified { get; set; }
    public DateTime CreatedAt { get; set; }

    public int FollowersCount { get; set; }
    public int FollowingCount { get; set; }
    public int PostsCount { get; set; }

    public bool IsFollowedByMe { get; set; }  
    public bool IsFollowingMe { get; set; }   
    public bool IsMe { get; set; }
}
public class UserSummaryDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string? AvatarUrl { get; set; }
    public string? Bio { get; set; }
    public bool IsVerified { get; set; }
    public bool IsFollowedByMe { get; set; }
}
public class UpdateProfileDto
{
    public string DisplayName { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    public string? BannerUrl { get; set; }
    public string? Location { get; set; }
    public string? Website { get; set; }
}