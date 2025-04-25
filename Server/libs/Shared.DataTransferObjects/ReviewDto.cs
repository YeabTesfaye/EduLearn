namespace Shared.DataTransferObjects;

/// <summary>
/// Data Transfer Object for returning course review info
/// </summary>
public class ReviewDto
{
    public Guid Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
}
