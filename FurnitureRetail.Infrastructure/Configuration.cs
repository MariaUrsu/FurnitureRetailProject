

using FurnitureRetail.Core;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureRetail.Infrastructure;

public static class Configuration
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IEmailClient, EmailClient>();
    }
}