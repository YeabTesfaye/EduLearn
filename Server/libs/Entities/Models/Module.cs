using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a module within a course
/// </summary>
public class Module
{
    [Column("ModuleId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Module title is a required field.")]
    [MaxLength(100, ErrorMessage = "Maximum length for Title is 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Module description is a required field.")]
    [MaxLength(500, ErrorMessage = "Maximum length for Description is 500 characters.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Order index is a required field.")]
    [Range(0, int.MaxValue, ErrorMessage = "Order index must be a positive number")]
    public int OrderIndex { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    [Required(ErrorMessage = "Course ID is a required field.")]
    public Guid CourseId { get; set; }

    [ForeignKey(nameof(CourseId))]
    public virtual Course? Course { get; set; }
    public virtual ICollection<Lesson>? Lessons { get; set; }
}