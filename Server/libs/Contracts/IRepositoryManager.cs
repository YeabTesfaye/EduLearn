
namespace Contracts;

public interface IRepositoryManager
{
    ICourseRepository Course { get; }
    ILessonRepository Lesson { get; }
    IModuleRepository Module { get; }
    IProgressRepository Progress { get; }
    IReviewRepository Review { get; }
    IUserRepository User { get; }

    void Save();
}