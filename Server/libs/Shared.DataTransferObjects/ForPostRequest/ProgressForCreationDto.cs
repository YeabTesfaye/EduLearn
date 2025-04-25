using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.ForPostRequest;

public class ProgressForCreationDto
{
    [Required]
    public bool IsCompleted { get; set; }

    public DateTime? CompletedAt { get; set; }

    [Range(0, int.MaxValue)]
    public int LastPosition { get; set; }
}