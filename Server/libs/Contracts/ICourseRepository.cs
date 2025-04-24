using Entities.Models;

namespace Contracts;
/// <summary>
/// Interface for course-specific repository operations
/// </summary>
public interface ICourseRepository
{
    /// <summary>
    /// Gets all courses in the system.
    /// </summary>
    Task<IEnumerable<Course>> GetAllCoursesAsync(bool trackChanges);

    /// <summary>
    /// Gets a single course by its ID.
    /// </summary>
    Task<Course?> GetCourseByIdAsync(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all courses published to students.
    /// </summary>
    Task<IEnumerable<Course>> GetPublishedCoursesAsync(bool trackChanges);

    /// <summary>
    /// Gets all unpublished (draft) courses.
    /// </summary>
    Task<IEnumerable<Course>> GetUnpublishedCoursesAsync(bool trackChanges);

    /// <summary>
    /// Gets all courses by instructor ID.
    /// </summary>
    Task<IEnumerable<Course>> GetCoursesByInstructorIdAsync(Guid instructorId, bool trackChanges);

    /// <summary>
    /// Searches courses by keyword in title or description.
    /// </summary>
    Task<IEnumerable<Course>> SearchCoursesAsync(string keyword, bool trackChanges);

    /// <summary>
    /// Filters courses by category.
    /// </summary>
    Task<IEnumerable<Course>> GetCoursesByCategoryAsync(string category, bool trackChanges);

    /// <summary>
    /// Filters courses by difficulty level.
    /// </summary>
    Task<IEnumerable<Course>> GetCoursesByLevelAsync(string level, bool trackChanges); // Beginner, Intermediate, Advanced

    /// <summary>
    /// Gets all enrolled students for a given course.
    /// </summary>
    Task<IEnumerable<User>> GetEnrolledStudentsAsync(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all modules under a course.
    /// </summary>
    Task<IEnumerable<Module>> GetModulesByCourseIdAsync(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all reviews for a given course.
    /// </summary>
    Task<IEnumerable<Review>> GetCourseReviewsAsync(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets top-rated courses (could be based on average review).
    /// </summary>
    Task<IEnumerable<Course>> GetTopRatedCoursesAsync(int count, bool trackChanges);

    /// <summary>
    /// Gets the latest added or updated courses.
    /// </summary>
    Task<IEnumerable<Course>> GetRecentCoursesAsync(int count, bool trackChanges);

  
}

