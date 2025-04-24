using Entities.Models;


namespace Contracts;
    public interface IUserRepository
    {
        // ✅ Basic Queries
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User?> GetUserByIdAsync(Guid userId, bool trackChanges);
        Task<User?> GetUserByEmailAsync(string email, bool trackChanges);
        Task<User?> GetUserByUsernameAsync(string username, bool trackChanges);

        // ✅ Role-Based Queries
        Task<IEnumerable<User>> GetAllStudentsAsync(bool trackChanges);     // role = "Student"
        Task<IEnumerable<User>> GetAllInstructorsAsync(bool trackChanges);  // role = "Instructor"
        Task<IEnumerable<User>> GetAllAdminsAsync(bool trackChanges);       // role = "Admin"

        // ✅ Status Queries
        Task<IEnumerable<User>> GetActiveUsersAsync(bool trackChanges);
        Task<IEnumerable<User>> GetInactiveUsersAsync(bool trackChanges);

        // ✅ Instructor-specific methods
        Task<IEnumerable<Course>> GetCoursesByInstructorIdAsync(Guid instructorId, bool trackChanges);

        // ✅ Student-specific methods
        Task<IEnumerable<Course>> GetEnrolledCoursesByStudentIdAsync(Guid studentId, bool trackChanges);

        // ✅ Admin-specific utilities
        Task ToggleUserActivationAsync(Guid userId); // soft delete / re-enable

        // ✅ Custom Queries
        Task<IEnumerable<User>> SearchUsersByNameAsync(string name, bool trackChanges);
    }

