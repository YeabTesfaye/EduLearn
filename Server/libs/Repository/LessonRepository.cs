
using Contracts;
using Entities.Models;

namespace Repository;

class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
{
    public LessonRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public Task<Lesson?> GetLessonByIdAsync(Guid lessonId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Progress>> GetLessonProgressAsync(Guid lessonId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsByContentTypeAsync(string contentType, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsByModuleIdAsync(Guid moduleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsLongerThanAsync(int durationInMinutes, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsWithResourcesAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<Lesson?> GetNextLessonAsync(Guid moduleId, int currentOrderIndex, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetOrderedLessonsInModuleAsync(Guid moduleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}