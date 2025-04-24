using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a course in the e-learning system
/// </summary>
public class Course
{
    [Column("CourseId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Course title is a required field.")]
    [MaxLength(100, ErrorMessage = "Maximum length for Title is 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Course description is a required field.")]
    [MaxLength(500, ErrorMessage = "Maximum length for Description is 500 characters.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Course level is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for Level is 20 characters.")]
    public string Level { get; set; } = string.Empty; // Beginner, Intermediate, Advanced

    [Required(ErrorMessage = "Price is a required field.")]
    [Range(0, 9999.99, ErrorMessage = "Price must be between 0 and 9999.99")]
    [Column(TypeName = "decimal(7,2)")]
    public decimal Price { get; set; }

    [MaxLength(255, ErrorMessage = "Maximum length for ThumbnailUrl is 255 characters.")]
    public string ThumbnailUrl { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsPublished { get; set; }

    [Required(ErrorMessage = "Category is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for Category is 50 characters.")]
    public string Category { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "Duration must be a positive number")]
    public int Duration { get; set; } // in minutes

    // Navigation properties
    [Required(ErrorMessage = "Instructor ID is a required field.")]
    public Guid InstructorId { get; set; }

    [ForeignKey(nameof(InstructorId))]
    public virtual User? Instructor { get; set; }
    public virtual ICollection<User>? EnrolledStudents { get; set; }
    public virtual ICollection<Module>? Modules { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }
}