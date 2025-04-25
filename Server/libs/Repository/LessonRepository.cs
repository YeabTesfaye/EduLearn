
using Contracts;
using Entities.Models;

namespace Repository;
/// <summary>
/// Repository implementation for Lesson-specific Operations
/// </summary>

class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
{
    /// <summary>
    /// Intitalizes a new instance of the LessonRepository
    /// </summary>
    /// <param name="repositoryContext">The database context</param>
    public LessonRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<Lesson> GetAllLessons(bool trackChanges)
    {
       var lessons = FindAll(trackChanges).OrderBy(x => x.Title).ToList();
       return lessons;
    }

    public Lesson? GetLessonById(Guid lessonId, bool trackChanges)
    {
        var course = FindByCondition(l => l.Id == lessonId, trackChanges).SingleOrDefault();
        return course;
    }

    public IEnumerable<Progress> GetLessonProgress(Guid lessonId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetLessonsByContentType(string contentType, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetLessonsByModuleId(Guid moduleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetLessonsLongerThan(int durationInMinutes, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetLessonsWithResources(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Lesson? GetNextLesson(Guid moduleId, int currentOrderIndex, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Lesson> GetOrderedLessonsInModule(Guid moduleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}