using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
        (
            new User
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Username = "john_instructor",
                PasswordHash = "hashed_password_123",
                Role = "Instructor",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Username = "jane_student",
                PasswordHash = "hashed_password_456",
                Role = "Student",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}