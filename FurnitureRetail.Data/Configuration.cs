using FurnitureRetail.Core;
using FurnitureRetail.Core.Queries;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureRetail.Data;

public static class Configuration
{
    public static void AddDb(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Main");
        services.AddDbContext<FurnitureRetailDbContext>(options => options.UseSqlServer(connectionString));
        services.AddDbContext<NoFurnitureRetailDbContext>(options => options.UseSqlServer(connectionString));
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IWriteEntities, WriteEntities>();
        services.AddTransient<IReadEntities, ReadEntities>();
    }
}