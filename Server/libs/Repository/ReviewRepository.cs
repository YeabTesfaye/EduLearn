
using Contracts;
using Entities.Models;

namespace Repository;

class ReviewRepository : IReviewRepository
{
    private RepositoryContext _repositoryContext;
    public ReviewRepository(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }
    public void CreateReview(Review review)
    {
        throw new NotImplementedException();
    }

    public void DeleteReview(Review review)
    {
        throw new NotImplementedException();
    }

    public Task<double> GetAverageRatingAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }

    public Task<Review?> GetReviewByUserAndCourseAsync(Guid userId, Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Review>> GetReviewsByCourseIdAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Review>> GetReviewsByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public void UpdateReview(Review review)
    {
        throw new NotImplementedException();
    }
}