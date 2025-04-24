using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class ModuleService : IModuleService
{
    private IRepositoryManager _repositoryManager;

    public ModuleService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }


}



/* 
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

 */