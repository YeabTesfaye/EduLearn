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

    
    public Task<IEnumerable<Module>> GetAllModulesAsync(bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<Module> GetModuleByIdAsync(Guid moduleId, bool trackChanges)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Module>> GetModulesByCourseIdAsync(Guid courseId, bool trackChanges)
    {
        throw new NotImplementedException();
    }
}