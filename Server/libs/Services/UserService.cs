using Contracts;
using Service.Contracts;


namespace Services;

internal sealed class UserService : IUserService
{
    private IRepositoryManager _repositoryManager;

    public UserService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

}
