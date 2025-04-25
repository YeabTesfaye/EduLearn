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


    public IEnumerable<Course> GetAllCourses(bool trackChanges)
        => FindAll(trackChanges).OrderBy(c => c.Title).ToList();

    public Course? GetCourseById(Guid courseId, bool trackChanges)
        => FindByCondition(c => c.Id == courseId, trackChanges).SingleOrDefault();

    public IEnumerable<Review> GetCourseReviews(Guid courseId, bool trackChanges)
        => FindByCondition(c => c.Id == courseId, trackChanges)
            .SelectMany(c => c.Reviews!)
            .ToList();

    public IEnumerable<Course> GetCoursesByCategory(string category, bool trackChanges)
        => FindByCondition(c => c.Category == category, trackChanges).ToList();

    public IEnumerable<Course> GetCoursesByInstructor(Guid instructorId, bool trackChanges)
        => FindByCondition(c => c.InstructorId == instructorId, trackChanges).ToList();

    public IEnumerable<Course> GetCoursesByLevel(string level, bool trackChanges)
        => FindByCondition(c => c.Level == level, trackChanges).ToList();

    public IEnumerable<User> GetEnrolledStudents(Guid courseId, bool trackChanges)
        => FindByCondition(c => c.Id == courseId, trackChanges)
            .SelectMany(c => c.EnrolledStudents!)
            .ToList();

    public IEnumerable<Module> GetModulesByCourse(Guid courseId, bool trackChanges)
        => FindByCondition(c => c.Id == courseId, trackChanges)
            .SelectMany(c => c.Modules!)
            .ToList();

    public IEnumerable<Course> GetPublishedCourses(bool trackChanges)
        => FindByCondition(c => c.IsPublished, trackChanges).ToList();

    public IEnumerable<Course> GetUnpublishedCourses(bool trackChanges)
        => FindByCondition(c => !c.IsPublished, trackChanges).ToList();

    public IEnumerable<Course> GetRecentCourses(int count, bool trackChanges)
        => FindAll(trackChanges)
            .OrderByDescending(c => c.CreatedAt)
            .Take(count)
            .ToList();

    public IEnumerable<Course> GetTopRatedCourses(int count, bool trackChanges)
        => FindAll(trackChanges)
            .OrderByDescending(c => c.Reviews!.Average(r => r.Rating)) // assuming Review has a Rating property
            .Take(count)
            .ToList();

    public IEnumerable<Course> SearchCourses(string keyword, bool trackChanges)
        => FindByCondition(c =>
               c.Title.Contains(keyword) ||
               c.Description.Contains(keyword), trackChanges)
           .ToList();

    
}