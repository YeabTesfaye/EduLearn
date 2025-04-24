using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a lesson within a module
/// </summary>
public class Lesson
{
    [Column("LessonId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Lesson title is a required field.")]
    [MaxLength(100, ErrorMessage = "Maximum length for Title is 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Content is a required field.")]
    public string Content { get; set; } = string.Empty;

    [Required(ErrorMessage = "Content type is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for Content Type is 20 characters.")]
    public string ContentType { get; set; } = string.Empty; // Video, Text, Quiz, etc.

    [MaxLength(255, ErrorMessage = "Maximum length for Resource URL is 255 characters.")]
    public string ResourceUrl { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "Duration must be a positive number")]
    public int Duration { get; set; } // in minutes

    [Required(ErrorMessage = "Order index is a required field.")]
    [Range(0, int.MaxValue, ErrorMessage = "Order index must be a positive number")]
    public int OrderIndex { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    [Required(ErrorMessage = "Module ID is a required field.")]
    public Guid ModuleId { get; set; }

    [ForeignKey(nameof(ModuleId))]
    public virtual Module? Module { get; set; }
    public virtual ICollection<Progress>? StudentProgress { get; set; }
}