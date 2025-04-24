using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class CourseService : ICourseService  
{
    private readonly IRepositoryManager _repositoryManager;

    public CourseService(IRepositoryManager repositoryManager)
    {
            _repositoryManager = repositoryManager;
    }

} 