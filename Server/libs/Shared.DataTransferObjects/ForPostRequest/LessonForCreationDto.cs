using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.ForPostRequest;

public class LessonForCreationDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string ContentType { get; set; } = string.Empty;

    [MaxLength(255)]
    public string ResourceUrl { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    public int Duration { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int OrderIndex { get; set; }

    [Required]
    public Guid ModuleId { get; set; }
}

