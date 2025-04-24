using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a review for a course
/// </summary>
public class Review
{
    [Column("ReviewId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Rating is a required field.")]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
    public int Rating { get; set; } // 1-5 stars

    [MaxLength(500, ErrorMessage = "Maximum length for Comment is 500 characters.")]
    public string Comment { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    [Required(ErrorMessage = "User ID is a required field.")]
    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    [Required(ErrorMessage = "Course ID is a required field.")]
    public Guid CourseId { get; set; }

    [ForeignKey(nameof(CourseId))]
    public virtual Course? Course { get; set; }
}