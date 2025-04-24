
using Contracts;
using Entities.Models;

namespace Repository;

class ProgressRepository : IProgressRepository
{
   private RepositoryContext _repositoryContext;
    public ProgressRepository(RepositoryContext repositoryContext) 
    {
        _repositoryContext = repositoryContext;
    }
    public void CreateProgress(Progress progress)
    {
        throw new NotImplementedException();
    }

    public void DeleteProgress(Progress progress)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Progress>> GetCompletedLessonsAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Progress>> GetProgressByCourseAsync(Guid userId, Guid courseId)
    {
        throw new NotImplementedException();
    }

    public Task<Progress?> GetProgressByUserAndLessonAsync(Guid userId, Guid lessonId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Progress>> GetProgressByUserIdAsync(Guid userId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public void UpdateProgress(Progress progress)
    {
        throw new NotImplementedException();
    }
}