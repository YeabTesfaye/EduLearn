using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.ForPostRequest;

public class ModuleForCreationDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Range(0, int.MaxValue)]
    public int OrderIndex { get; set; }

    [Required]
    public Guid CourseId { get; set; }
}