using Entities.Models;


namespace Contracts;
    public interface IUserRepository
    {
        // ✅ Basic Queries
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User? GetUserById(Guid userId, bool trackChanges);
        User? GetUserByEmail(string email, bool trackChanges);
        User? GetUserByUsername(string username, bool trackChanges);

        // ✅ Role-Based Queries
        IEnumerable<User> GetAllStudents(bool trackChanges);     // role = "Student"
        IEnumerable<User> GetAllInstructors(bool trackChanges);  // role = "Instructor"
        IEnumerable<User> GetAllAdmins(bool trackChanges);       // role = "Admin"

        // ✅ Status Queries
        IEnumerable<User> GetActiveUsers(bool trackChanges);
        IEnumerable<User> GetInactiveUsers(bool trackChanges);

        // ✅ Instructor-specific methods
        IEnumerable<Course> GetCoursesByInstructorId(Guid instructorId, bool trackChanges);

        // ✅ Student-specific methods
        IEnumerable<Course> GetEnrolledCoursesByStudentId(Guid studentId, bool trackChanges);

        // ✅ Admin-specific utilities
        Task ToggleUserActivation(Guid userId); // soft delete / re-enable

        // ✅ Custom Queries
        IEnumerable<User> SearchUsersByName(string name, bool trackChanges);
    }

