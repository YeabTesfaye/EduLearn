using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasData
        (
            new Review
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4c"),
                Rating = 5,
                Comment = "Excellent course! Very well structured and informative.",
                UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                CourseId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                CreatedAt = DateTime.UtcNow.AddDays(-5)
            },
            new Review
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52c"),
                Rating = 4,
                Comment = "Great advanced content, but could use more examples.",
                UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                CourseId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                CreatedAt = DateTime.UtcNow.AddDays(-2)
            }
        );
    }
}