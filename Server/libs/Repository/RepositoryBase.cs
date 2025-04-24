using System.Linq.Expressions;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository;

/// <summary>
/// Base implementation of the repository pattern for CRUD operations
/// </summary>
public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    // Protected repository context that derived classes can access
    protected RepositoryContext RepositoryContext;

    public RepositoryBase(RepositoryContext repositoryContext)
    {
        RepositoryContext = repositoryContext;
    }

    /// <summary>
    /// Retrieves all entities with optional change tracking
    /// </summary>
    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges
            ? RepositoryContext.Set<T>().AsNoTracking() // Returns untracked entities for read-only operations
            : RepositoryContext.Set<T>();               // Returns tracked entities for update operations

    /// <summary>
    /// Finds entities based on a condition with optional change tracking
    /// </summary>
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
        !trackChanges
            ? RepositoryContext.Set<T>().Where(expression).AsNoTracking() // Returns filtered, untracked entities
            : RepositoryContext.Set<T>().Where(expression);               // Returns filtered, tracked entities

    /// <summary>
    /// Creates a new entity in the context
    /// </summary>
    public void Create(T entity) =>
        RepositoryContext.Set<T>().Add(entity);

    /// <summary>
    /// Marks an entity as modified in the context
    /// </summary>
    public void Update(T entity) =>
        RepositoryContext.Set<T>().Update(entity);

    /// <summary>
    /// Marks an entity for deletion in the context
    /// </summary>
    public void Delete(T entity) =>
        RepositoryContext.Set<T>().Remove(entity);
}