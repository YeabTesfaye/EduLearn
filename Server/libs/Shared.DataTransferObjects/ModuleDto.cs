namespace Shared.DataTransferObjects;

public class ModuleDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int OrderIndex { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CourseId { get; set; }
}
