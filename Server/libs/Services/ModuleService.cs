using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class ModuleService : IModuleService
{
    private IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public ModuleService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;   
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