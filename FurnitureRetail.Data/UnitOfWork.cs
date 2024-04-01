using Microsoft.EntityFrameworkCore;
using System.Text;
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Data.Context;

namespace FurnitureRetail.Data;

public class UnitOfWork: IUnitOfWork
{
    private readonly FurnitureRetailDbContext _context;

    public UnitOfWork(FurnitureRetailDbContext context)
    {
        _context = context;
    }

    public async Task Save()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException e)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"DbUpdateException error details - {e.InnerException?.InnerException?.Message}");

            try
            {
                foreach (var result in e.Entries)
                {
                    sb.AppendFormat($"Type: {result.Entity.GetType().Name} in state {result.State} was part of the problem. ");
                }
            }
            catch (Exception ex)
            {
                sb.Append("Error parsing DbUpdateException: " + ex);
            }

            throw new DatabaseSaveException(sb.ToString(), e);
        }
    }
}