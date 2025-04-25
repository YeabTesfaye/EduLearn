using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

/// <summary>
/// Repository implementation for module-specific operations
/// </summary>
public class ModuleRepository : RepositoryBase<Module>, IModuleRepository
{
    public ModuleRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public IEnumerable<Module> GetAllModules(bool trackChanges)
    {
        var modules = FindAll(trackChanges).OrderBy(m => m.Title).ToList();
        return modules;
    }

    public Module? GetModuleById(Guid moduleId, bool trackChanges)
    {
        var module = FindByCondition(m => m.Id == moduleId, trackChanges).SingleOrDefault();
        return module;
    }

    public IEnumerable<Module> GetModulesByCourseId(Guid courseId, bool trackChanges)
    {
        var modulesWithCourse = FindByCondition(m => m.CourseId == courseId, trackChanges).OrderBy(c => c.Title).ToList();

        return modulesWithCourse;
    }
}