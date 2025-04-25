namespace Shared.DataTransferObjects;

/// <summary>
/// Data Transfer Object for returning lesson information
/// </summary>
public class LessonDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty; // Video, Text, Quiz, etc.
    public string ResourceUrl { get; set; } = string.Empty;
    public int Duration { get; set; } // in minutes
    public int OrderIndex { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid ModuleId { get; set; }
}
