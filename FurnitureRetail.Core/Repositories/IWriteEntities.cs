using System.Linq.Expressions;

namespace FurnitureRetail.Core.Queries;

public interface IWriteEntities : IReadEntities
{
    void Add<TEntity>(TEntity item) where TEntity : Entity;
    void AddRange<TEntity>(IReadOnlyCollection<TEntity> items) where TEntity : Entity;
    Task Delete<TEntity>(Expression<Func<TEntity, bool>> whereExpression) where TEntity : Entity;
    Task Delete<TEntity>(Guid id) where TEntity : Entity;
    Task Delete<TEntity>(IReadOnlyCollection<Guid> ids) where TEntity : Entity;
}
