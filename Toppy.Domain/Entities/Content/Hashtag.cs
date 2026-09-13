namespace Toppy.Domain.Entities.Content;

public class Hashtag
{
    public int Id { get; set; }

    public string Tag { get; set; } = string.Empty;  
    public int UsageCount { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<PostHashtag> Posts { get; set; } = new();
}