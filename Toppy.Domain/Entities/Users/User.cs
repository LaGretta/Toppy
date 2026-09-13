namespace Toppy.Domain.Entities.Users;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    
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

    public List<RefreshToken> RefreshTokens { get; set; } = new();
}
