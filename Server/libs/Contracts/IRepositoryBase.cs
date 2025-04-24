using System.Linq.Expressions;

namespace Contracts;

/// <summary>
/// Generic repository interface for CRUD operations
/// </summary>
public interface IRepositoryBase<T>
{
    /// <summary>
    /// Retrieves all entities of type T
    /// </summary>
    /// <param name="trackChanges">If true, entities will be tracked by EF Core</param>
    IQueryable<T> FindAll(bool trackChanges);

    /// <summary>
    /// Finds entities based on a condition
    /// </summary>
    /// <param name="expression">The condition to filter entities</param>
    /// <param name="trackChanges">If true, entities will be tracked by EF Core</param>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    /// <summary>
    /// Creates a new entity
    /// </summary>
    void Create(T entity);

    /// <summary>
    /// Updates an existing entity
    /// </summary>
    void Update(T entity);

    /// <summary>
    /// Deletes an entity
    /// </summary>
    void Delete(T entity);
}