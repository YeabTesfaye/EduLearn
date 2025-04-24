using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for progress-specific repository operations
/// </summary>
public interface IProgressRepository
{
    /// <summary>
    /// Gets all progress records for a specific user
    /// </summary>
    Task<IEnumerable<Progress>> GetProgressByUserIdAsync(Guid userId, bool trackChanges);

    /// <summary>
    /// Gets progress for a specific lesson by a specific user
    /// </summary>
    Task<Progress?> GetProgressByUserAndLessonAsync(Guid userId, Guid lessonId, bool trackChanges);

    /// <summary>
    /// Adds a new progress record
    /// </summary>
    void CreateProgress(Progress progress);

    /// <summary>
    /// Updates an existing progress record
    /// </summary>
    void UpdateProgress(Progress progress);

    /// <summary>
    /// Deletes a progress record
    /// </summary>
    void DeleteProgress(Progress progress);

    /// <summary>
    /// Gets all completed lessons for a specific user
    /// </summary>
    Task<IEnumerable<Progress>> GetCompletedLessonsAsync(Guid userId);

    /// <summary>
    /// Gets progress records for all lessons in a specific course for a user
    /// </summary>
    Task<IEnumerable<Progress>> GetProgressByCourseAsync(Guid userId, Guid courseId);
}
