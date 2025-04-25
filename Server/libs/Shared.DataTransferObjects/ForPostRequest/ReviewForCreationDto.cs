using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.ForPostRequest;

public class ReviewForCreationDto
{
    [Required]
    [Range(1, 5)]
    public int Rating { get; set; }

    [MaxLength(500)]
    public string Comment { get; set; } = string.Empty;

    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid CourseId { get; set; }
}