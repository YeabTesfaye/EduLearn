using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a student's progress in a lesson
/// </summary>
public class Progress
{
    [Column("ProgressId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Completion status is a required field.")]
    public bool IsCompleted { get; set; }

    public DateTime? CompletedAt { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Last position must be a positive number")]
    public int LastPosition { get; set; } // For video progress tracking

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    [Required(ErrorMessage = "User ID is a required field.")]
    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    [Required(ErrorMessage = "Lesson ID is a required field.")]
    public Guid LessonId { get; set; }

    [ForeignKey(nameof(LessonId))]
    public virtual Lesson? Lesson { get; set; }
}