using AutoMapper;
using Contracts;
using Service.Contracts;

namespace Services;

internal sealed class ProgressService : IProgressService
{
  
    private IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public ProgressService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }
}
