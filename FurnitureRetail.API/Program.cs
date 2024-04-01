using System.Reflection;
using FurnitureRetail.Core;
using FurnitureRetail.Data;
using FurnitureRetail.Infrastructure;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var environment = builder.Environment;

// Add services to the container.
builder.Services.AddDb(builder.Configuration);
builder.Services.AddInfrastructure();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateCustomerHandler).GetTypeInfo().Assembly));
if (environment.IsDevelopment())
{
    builder.Services.AddCors();
}
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
         .AllowCredentials()
         .AllowAnyHeader()
         .AllowAnyMethod()
     );
}

app.UseHttpsRedirection();

app.UseAuthorization();

using (var serviceScope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
{
    var context = serviceScope!.ServiceProvider.GetRequiredService<FurnitureRetailDbContext>();

    context.Database.Migrate();
}

app.MapControllers();

app.Run();
