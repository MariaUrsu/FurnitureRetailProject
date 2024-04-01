using System.Linq.Expressions;
using FurnitureRetail.Core;
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FurnitureRetail.Data;

public class WriteEntities : IWriteEntities
{
    private readonly FurnitureRetailDbContext _context;

    public WriteEntities(FurnitureRetailDbContext context)
    {
        _context = context;
    }

    public void Add<TEntity>(TEntity item) where TEntity : Entity => _context.Add(item);

    public void AddRange<TEntity>(IReadOnlyCollection<TEntity> items) where TEntity : Entity => _context.AddRange(items);

    public void Delete(IReadOnlyCollection<object> items) => _context.RemoveRange(items);

    public void Delete(object item) => _context.Remove(item);

    public async Task Delete<TEntity>(Expression<Func<TEntity, bool>> whereExpression) where TEntity : Entity
    {
        var items = await Get(whereExpression);
        _context.RemoveRange(items);
    }

    public async Task Delete<TEntity>(Guid id) where TEntity : Entity
    {
        var entity = await Get<Entity>(id);
        Delete(entity);
    }

    public async Task Delete<TEntity>(IReadOnlyCollection<Guid> ids) where TEntity : Entity
    {
        var entities = await Get<Entity>(ids);
        Delete(entities);
    }

    #region IReadEntities
    public ValueTask<TEntity?> Get<TEntity>(Guid id) where TEntity : Entity
        => _context.FindAsync<TEntity>(id);

    public async Task<IReadOnlyCollection<TEntity>> Get<TEntity>(IReadOnlyCollection<Guid> ids) where TEntity : Entity
        => await _context.Set<TEntity>().Where(e => ids.Contains(e.Id)).ToListAsync();

    public async Task<IReadOnlyCollection<TEntity>> Get<TEntity>() where TEntity : Entity
        => await _context.Set<TEntity>().ToListAsync();

    public async Task<TEntity?> Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity
        => await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
    #endregion
}

