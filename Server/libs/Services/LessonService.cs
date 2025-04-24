using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class LessonService : ILessonService
{
    private IRepositoryManager _repositoryManager;

    public LessonService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}
