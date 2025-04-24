using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ProgressConfiguration : IEntityTypeConfiguration<Progress>
{
    public void Configure(EntityTypeBuilder<Progress> builder)
    {
        builder.HasData
        (
            new Progress
            {
                Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                IsCompleted = true,
                CompletedAt = DateTime.UtcNow.AddDays(-1),
                LastPosition = 45,
                UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                LessonId = new Guid("80abbca8-664d-4b20-b5de-024705497d4b"),
                CreatedAt = DateTime.UtcNow.AddDays(-2)
            },
            new Progress
            {
                Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                IsCompleted = false,
                CompletedAt = null,
                LastPosition = 15,
                UserId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                LessonId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52b"),
                CreatedAt = DateTime.UtcNow.AddDays(-1)
            }
        );
    }
}