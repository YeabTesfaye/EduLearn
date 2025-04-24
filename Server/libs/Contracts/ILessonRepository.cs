using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for lesson-specific repository operations
/// </summary>
public interface ILessonRepository
{
    /// <summary>
    /// Gets all lessons for a specific module.
    /// </summary>
    Task<IEnumerable<Lesson>> GetLessonsByModuleIdAsync(Guid moduleId, bool trackChanges);

    /// <summary>
    /// Gets a lesson by its unique ID.
    /// </summary>
    Task<Lesson?> GetLessonByIdAsync(Guid lessonId, bool trackChanges);

    /// <summary>
    /// Gets lessons in a module ordered by index.
    /// </summary>
    Task<IEnumerable<Lesson>> GetOrderedLessonsInModuleAsync(Guid moduleId, bool trackChanges);

    /// <summary>
    /// Gets all lessons of a specific content type.
    /// </summary>
    Task<IEnumerable<Lesson>> GetLessonsByContentTypeAsync(string contentType, bool trackChanges);

    /// <summary>
    /// Gets lessons with duration greater than a given threshold.
    /// </summary>
    Task<IEnumerable<Lesson>> GetLessonsLongerThanAsync(int durationInMinutes, bool trackChanges);

    /// <summary>
    /// Gets the next lesson in order within a module.
    /// </summary>
    Task<Lesson?> GetNextLessonAsync(Guid moduleId, int currentOrderIndex, bool trackChanges);

    /// <summary>
    /// Gets all lessons with resource URLs (e.g., for video/text).
    /// </summary>
    Task<IEnumerable<Lesson>> GetLessonsWithResourcesAsync(bool trackChanges);

    /// <summary>
    /// Gets progress for a specific lesson.
    /// </summary>
    Task<IEnumerable<Progress>> GetLessonProgressAsync(Guid lessonId, bool trackChanges);

   
}

