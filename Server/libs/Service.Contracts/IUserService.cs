
using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IUserService{
        public IEnumerable<UserDto> GetAllUsers(bool trackChanges);

}