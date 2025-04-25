using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for lesson-specific repository operations
/// </summary>
public interface ILessonRepository
{
    /// <summary>
    /// Gets all lessons 
    /// </summary>
    IEnumerable<Lesson> GetAllLessons(bool trackChanges);
    /// <summary>
    /// Gets all lessons for a specific module.
    /// </summary>
    IEnumerable<Lesson> GetLessonsByModuleId(Guid moduleId, bool trackChanges);

    /// <summary>
    /// Gets a lesson by its unique ID.
    /// </summary>
    Lesson? GetLessonById(Guid lessonId, bool trackChanges);

    /// <summary>
    /// Gets lessons in a module ordered by index.
    /// </summary>
    IEnumerable<Lesson> GetOrderedLessonsInModule(Guid moduleId, bool trackChanges);

    /// <summary>
    /// Gets all lessons of a specific content type.
    /// </summary>
    IEnumerable<Lesson> GetLessonsByContentType(string contentType, bool trackChanges);

    /// <summary>
    /// Gets lessons with duration greater than a given threshold.
    /// </summary>
    IEnumerable<Lesson> GetLessonsLongerThan(int durationInMinutes, bool trackChanges);

    /// <summary>
    /// Gets the next lesson in order within a module.
    /// </summary>
    Lesson? GetNextLesson(Guid moduleId, int currentOrderIndex, bool trackChanges);

    /// <summary>
    /// Gets all lessons with resource URLs (e.g., for video/text).
    /// </summary>
    IEnumerable<Lesson> GetLessonsWithResources(bool trackChanges);

    /// <summary>
    /// Gets progress for a specific lesson.
    /// </summary>
    IEnumerable<Progress> GetLessonProgress(Guid lessonId, bool trackChanges);

   
}

