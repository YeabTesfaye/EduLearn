using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repository.Configuration;

namespace Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Progress> Progresses { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply configurations
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        modelBuilder.ApplyConfiguration(new ModuleConfiguration());
        modelBuilder.ApplyConfiguration(new LessonConfiguration());
        modelBuilder.ApplyConfiguration(new ProgressConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());

        // Configure many-to-many relationship between User and Course for enrollments
        modelBuilder.Entity<User>()
            .HasMany(u => u.EnrolledCourses)
            .WithMany(c => c.EnrolledStudents)
            .UsingEntity(j => j.ToTable("CourseEnrollments"));

        // Configure one-to-many relationship between User (Instructor) and Course
        modelBuilder.Entity<Course>()
            .HasOne(c => c.Instructor)
            .WithMany(u => u.TeachingCourses)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
