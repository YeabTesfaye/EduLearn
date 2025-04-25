using Entities.Models;

namespace Contracts;

/// <summary>
/// Interface for module-specific repository operations
/// </summary>
public interface IModuleRepository
{
    IEnumerable<Module> GetAllModules(bool trackChanges);
    Module? GetModuleById(Guid moduleId, bool trackChanges);
    IEnumerable<Module> GetModulesByCourseId(Guid courseId, bool trackChanges);

}