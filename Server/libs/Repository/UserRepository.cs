

using Contracts;
using Entities.Models;

namespace Repository;

class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public IEnumerable<User> GetActiveUsers(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllAdmins(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllInstructors(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllStudents(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers(bool trackChanges)
    {
        var users = FindAll(trackChanges).OrderBy(u => u.FirstName).ToList();
        return users;
    }

    public IEnumerable<Course> GetCoursesByInstructorId(Guid instructorId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Course> GetEnrolledCoursesByStudentId(Guid studentId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetInactiveUsers(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public User? GetUserByEmail(string email, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public User? GetUserById(Guid userId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public User? GetUserByUsername(string username, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> SearchUsersByName(string name, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task ToggleUserActivation(Guid userId)
    {
        throw new NotImplementedException();
    }
}