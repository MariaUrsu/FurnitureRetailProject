using System.Linq.Expressions;

namespace FurnitureRetail.Core;

public interface IReadEntities
{
    Task<IReadOnlyCollection<TEntity>> Get<TEntity>() where TEntity : Entity;
    ValueTask<TEntity?> Get<TEntity>(Guid id) where TEntity : Entity;
    Task<IReadOnlyCollection<TEntity>> Get<TEntity>(IReadOnlyCollection<Guid> ids) where TEntity : Entity;
    Task<TEntity?> Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity;
}