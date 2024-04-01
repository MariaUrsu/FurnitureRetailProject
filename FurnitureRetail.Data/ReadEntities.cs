using System.Linq.Expressions;
using FurnitureRetail.Core;
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FurnitureRetail.Data;

public class ReadEntities : IReadEntities
{
    private readonly NoFurnitureRetailDbContext _context;

    public ReadEntities(NoFurnitureRetailDbContext context)
    {
        _context = context;
    }

    public ValueTask<TEntity?> Get<TEntity>(Guid id) where TEntity : Entity
        => _context.FindAsync<TEntity>(id);

    public async Task<IReadOnlyCollection<TEntity>> Get<TEntity>(IReadOnlyCollection<Guid> ids) where TEntity : Entity
        => await _context.Set<TEntity>().Where(e => ids.Contains(e.Id)).ToListAsync();

    public async Task<IReadOnlyCollection<TEntity>> Get<TEntity>() where TEntity : Entity
        => await _context.Set<TEntity>().ToListAsync();

    public async Task<TEntity?> Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : Entity
        => await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
}