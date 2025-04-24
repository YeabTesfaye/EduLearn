using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasData
        (
            new Lesson
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4b"),
                Title = "Introduction to HTML Tags",
                Content = "Learn about basic HTML tags and their usage",
                ContentType = "Video",
                ResourceUrl = "/videos/html-intro.mp4",
                Duration = 45,
                OrderIndex = 1,
                ModuleId = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                CreatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52b"),
                Title = "CSS Selectors",
                Content = "Understanding different types of CSS selectors",
                ContentType = "Text",
                ResourceUrl = "/content/css-selectors.html",
                Duration = 30,
                OrderIndex = 1,
                ModuleId = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                CreatedAt = DateTime.UtcNow
            },
            new Lesson
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Title = "Python Dictionaries Deep Dive",
                Content = "Advanced concepts of Python dictionaries",
                ContentType = "Video",
                ResourceUrl = "/videos/python-dict.mp4",
                Duration = 60,
                OrderIndex = 1,
                ModuleId = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}