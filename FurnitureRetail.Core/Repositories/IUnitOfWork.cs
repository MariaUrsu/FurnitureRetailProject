namespace FurnitureRetail.Core.Queries;

public interface IUnitOfWork
{
    Task Save();
}