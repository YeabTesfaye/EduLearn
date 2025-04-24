using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class ProgressService : IProgressService
{
  
    private IRepositoryManager _repositoryManager;
    public ProgressService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}
