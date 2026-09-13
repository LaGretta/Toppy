using Toppy.Domain.Enums;

namespace Toppy.Domain.Entities.Posts;

public class PostMedia
{
    public int Id { get; set; }
    
    public int PostId { get; set; }
    public Post Post { get; set; } = null!;
    
    public MediaType Type { get; set; }
    public string Url { get; set; } = string.Empty;

    public int? Width { get; set; }
    public int? Height { get; set; }
}