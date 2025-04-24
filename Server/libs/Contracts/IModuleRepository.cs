using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for module-specific repository operations
/// </summary>
public interface IModuleRepository
{
    Task<IEnumerable<Module>> GetAllModulesAsync(bool trackChanges);
    Task<Module> GetModuleByIdAsync(Guid moduleId, bool trackChanges);
    Task<IEnumerable<Module>> GetModulesByCourseIdAsync(Guid courseId, bool trackChanges);

}