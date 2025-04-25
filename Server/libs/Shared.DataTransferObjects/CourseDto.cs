namespace Shared.DataTransferObjects;

/// <summary>
/// Data Transfer Object for returning course information
/// </summary>
public class CourseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ThumbnailUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsPublished { get; set; }
    public string Category { get; set; } = string.Empty;
    public int Duration { get; set; } 
}
