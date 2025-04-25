using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.ForPostRequest;

/// <summary>
/// DTO used when creating a new course
/// </summary>
public class CourseForCreationDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string Level { get; set; } = string.Empty;

    [Required]
    [Range(0, 9999.99)]
    public decimal Price { get; set; }

    [MaxLength(255)]
    public string ThumbnailUrl { get; set; } = string.Empty;

    public bool IsPublished { get; set; }

    [Required]
    [MaxLength(50)]
    public string Category { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    public int Duration { get; set; }

    [Required]
    public Guid InstructorId { get; set; }
}
