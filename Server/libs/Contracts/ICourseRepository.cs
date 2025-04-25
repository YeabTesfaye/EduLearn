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
    IEnumerable<Course> GetAllCourses(bool trackChanges);

    /// <summary>
    /// Gets a single course by its ID.
    /// </summary>
    Course? GetCourseById(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all courses published to students.
    /// </summary>
    IEnumerable<Course> GetPublishedCourses(bool trackChanges);

    /// <summary>
    /// Gets all unpublished (draft) courses.
    /// </summary>
    IEnumerable<Course> GetUnpublishedCourses(bool trackChanges);

    /// <summary>
    /// Gets all courses by instructor ID.
    /// </summary>
    IEnumerable<Course> GetCoursesByInstructor(Guid instructorId, bool trackChanges);

    /// <summary>
    /// Searches courses by keyword in title or description.
    /// </summary>
IEnumerable<Course> SearchCourses(string keyword, bool trackChanges);

    /// <summary>
    /// Filters courses by category.
    /// </summary>
    IEnumerable<Course> GetCoursesByCategory(string category, bool trackChanges);

    /// <summary>
    /// Filters courses by difficulty level.
    /// </summary>
    IEnumerable<Course> GetCoursesByLevel(string level, bool trackChanges); // Beginner, Intermediate, Advanced

    /// <summary>
    /// Gets all enrolled students for a given course.
    /// </summary>
    IEnumerable<User> GetEnrolledStudents(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all modules under a course.
    /// </summary>
    IEnumerable<Module> GetModulesByCourse(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets all reviews for a given course.
    /// </summary>
    IEnumerable<Review> GetCourseReviews(Guid courseId, bool trackChanges);

    /// <summary>
    /// Gets top-rated courses (could be based on average review).
    /// </summary>
    IEnumerable<Course> GetTopRatedCourses(int count, bool trackChanges);

    /// <summary>
    /// Gets the latest added or updated courses.
    /// </summary>
    IEnumerable<Course> GetRecentCourses(int count, bool trackChanges);


}

