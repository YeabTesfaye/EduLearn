using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasData
        (
            new Course
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Title = "Introduction to Web Development",
                Description = "Learn the basics of web development including HTML, CSS, and JavaScript",
                Level = "Beginner",
                Price = 49.99m,
                ThumbnailUrl = "/images/courses/web-dev-intro.jpg",
                Category = "Web Development",
                Duration = 1800, // 30 hours
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                InstructorId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            },
            new Course
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Title = "Advanced Python Programming",
                Description = "Master Python with advanced concepts and real-world projects",
                Level = "Advanced",
                Price = 79.99m,
                ThumbnailUrl = "/images/courses/python-advanced.jpg",
                Category = "Programming",
                Duration = 2400, // 40 hours
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                InstructorId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            }
        );
    }
}