

using Contracts;
using Entities.Models;

namespace Repository;

class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public Task<IEnumerable<User>> GetActiveUsersAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllAdminsAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllInstructorsAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllStudentsAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByInstructorIdAsync(Guid instructorId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetEnrolledCoursesByStudentIdAsync(Guid studentId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetInactiveUsersAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserByEmailAsync(string email, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserByIdAsync(Guid userId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserByUsernameAsync(string username, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> SearchUsersByNameAsync(string name, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task ToggleUserActivationAsync(Guid userId)
    {
        throw new NotImplementedException();
    }
}