namespace Shared.DataTransferObjects;

/// <summary>
/// Data Transfer Object for returning student progress info
/// </summary>
public class ProgressDto
{
    public Guid Id { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public int LastPosition { get; set; }
    public DateTime CreatedAt { get; set; }

    public Guid UserId { get; set; }
    public Guid LessonId { get; set; }
}
