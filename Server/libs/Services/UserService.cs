using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;


namespace Services;

internal sealed class UserService : IUserService
{
    private IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public UserService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public IEnumerable<UserDto> GetAllUsers(bool trackChanges)
    {
        var users = _repositoryManager.User.GetAllUsers(trackChanges);

        var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
        return usersDto;
    }
}
