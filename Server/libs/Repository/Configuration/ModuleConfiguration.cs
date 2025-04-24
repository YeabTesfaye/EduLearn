using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ModuleConfiguration : IEntityTypeConfiguration<Module>
{
    public void Configure(EntityTypeBuilder<Module> builder)
    {
        builder.HasData
        (
            new Module
            {
                Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                Title = "HTML Fundamentals",
                Description = "Learn the basics of HTML markup language",
                OrderIndex = 1,
                CourseId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                CreatedAt = DateTime.UtcNow
            },
            new Module
            {
                Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                Title = "CSS Styling",
                Description = "Master CSS styling techniques",
                OrderIndex = 2,
                CourseId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                CreatedAt = DateTime.UtcNow
            },
            new Module
            {
                Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                Title = "Python Advanced Data Structures",
                Description = "Deep dive into Python's advanced data structures",
                OrderIndex = 1,
                CourseId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                CreatedAt = DateTime.UtcNow
            }
        );
    }
}