using Contracts;
using Entities.Models;

namespace Repository;

/// <summary>
/// Repository implementation for course-specific operations
/// </summary>
public class CourseRepository : RepositoryBase<Course>, ICourseRepository
{
    /// <summary>
    /// Initializes a new instance of the CourseRepository
    /// </summary>
    /// <param name="repositoryContext">The database context</param>
    public CourseRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public void CreateCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public void DeleteCourse(Course course)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetAllCoursesAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<Course?> GetCourseByIdAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Review>> GetCourseReviewsAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByCategoryAsync(string category, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByInstructorIdAsync(Guid instructorId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByLevelAsync(string level, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetEnrolledStudentsAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Module>> GetModulesByCourseIdAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetPublishedCoursesAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetRecentCoursesAsync(int count, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetTopRatedCoursesAsync(int count, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetUnpublishedCoursesAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> SearchCoursesAsync(string keyword, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}