namespace Shared.DataTransferObjects;

/// <summary>
/// Data Transfer Object for returning user info
/// </summary>
public class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    public ICollection<Guid>? EnrolledCourses { get; set; }
    public ICollection<Guid>? TeachingCourses { get; set; }
}
