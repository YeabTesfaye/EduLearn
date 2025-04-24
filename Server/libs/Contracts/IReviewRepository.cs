using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for review-specific repository operations
/// </summary>
public interface IReviewRepository
{
    /// <summary>
    /// Retrieves all reviews for a specific course
    /// </summary>
    Task<IEnumerable<Review>> GetReviewsByCourseIdAsync(Guid courseId, bool trackChanges);

    /// <summary>
    /// Retrieves a specific review by a user for a specific course
    /// </summary>
    Task<Review?> GetReviewByUserAndCourseAsync(Guid userId, Guid courseId, bool trackChanges);

    /// <summary>
    /// Adds a new review for a course
    /// </summary>
    void CreateReview(Review review);

    /// <summary>
    /// Updates an existing review
    /// </summary>
    void UpdateReview(Review review);

    /// <summary>
    /// Deletes a review
    /// </summary>
    void DeleteReview(Review review);

    /// <summary>
    /// Gets the average rating for a specific course
    /// </summary>
    Task<double> GetAverageRatingAsync(Guid courseId);

    /// <summary>
    /// Retrieves all reviews by a specific user
    /// </summary>
    Task<IEnumerable<Review>> GetReviewsByUserIdAsync(Guid userId);
}
