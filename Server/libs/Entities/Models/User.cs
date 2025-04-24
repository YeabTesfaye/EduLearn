using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Represents a user in the system
/// </summary>
public class User
{
    [Column("UserId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "First name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for First Name is 50 characters.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for Last Name is 50 characters.")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is a required field.")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [MaxLength(100, ErrorMessage = "Maximum length for Email is 100 characters.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Username is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for Username is 50 characters.")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Password hash is a required field.")]
    public string PasswordHash { get; set; } = string.Empty;

    [Required(ErrorMessage = "Role is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for Role is 20 characters.")]
    public string Role { get; set; } = string.Empty; // Student, Instructor, Admin

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation properties
    public virtual ICollection<Course>? EnrolledCourses { get; set; }
    public virtual ICollection<Course>? TeachingCourses { get; set; }
}