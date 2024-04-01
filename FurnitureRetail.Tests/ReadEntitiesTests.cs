using FluentAssertions;
using FurnitureRetail.Core;
using FurnitureRetail.Data;
using FurnitureRetail.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FurnitureRetail.Tests
{
    public class ReadEntitiesTests
    {
        public ReadEntitiesTests()
        {
            var services = new ServiceCollection();

            // Using In-Memory database for testing
            services.AddDbContext<NoFurnitureRetailDbContext>(options =>
                options.UseInMemoryDatabase("TestDb"));

            _serviceProvider = services.BuildServiceProvider();
        }

        private ServiceProvider _serviceProvider;

  
        [Fact]
        public async Task Get_WithQueryById_ReturnsEntity()
        {
            // Arrange
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            // Arrange
            using (var scope = _serviceProvider.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var context = scopedServices.GetRequiredService<NoFurnitureRetailDbContext>();
                context.Set<Customers>().Add(new Customers { Id = id1, FirstName = " popa", LastName = "maria", Email ="popa@gmail.com", Password= "sdfsdfd", NumberOfSelledProducts = 2, RegistrationDate = new DateOnly() });
                context.Set<Customers>().Add(new Customers { Id = id2, FirstName = " xsulescu", LastName = "ana", Email = "ana@gmail.com", Password = "ddgdfg", NumberOfSelledProducts = 2, RegistrationDate = new DateOnly() });
                await context.SaveChangesAsync();

                var sut = new ReadEntities(context);

                // Act
                var result = await sut.Get<Customers>(id1);

                // Assert
                result.Id.Should().Be(id1);
            }
          
        }

        [Fact]
        public async Task Get_WithQueryByIds_ReturnsEntities()
        {
            // Arrange
            var id1 = Guid.NewGuid();
            var id2 = Guid.NewGuid();
            var id3 = Guid.NewGuid();
          
            using (var scope = _serviceProvider.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var context = scopedServices.GetRequiredService<NoFurnitureRetailDbContext>();
                context.Set<Customers>().Add(new Customers { Id = id1, FirstName = " popa", LastName = "maria", Email = "popa@gmail.com", Password = "sdfsdfd", NumberOfSelledProducts = 2, RegistrationDate = new DateOnly() });
                context.Set<Customers>().Add(new Customers { Id = id2, FirstName = " xsulescu", LastName = "ana", Email = "ana@gmail.com", Password = "ddgdfg", NumberOfSelledProducts = 100, RegistrationDate = new DateOnly() });
                context.Set<Customers>().Add(new Customers { Id = id3, FirstName = " petreanu", LastName = "maria", Email = "maria@gmail.com", Password = "eeeweww", NumberOfSelledProducts = 66, RegistrationDate = new DateOnly() });

                await context.SaveChangesAsync();

                var sut = new ReadEntities(context);

                // Act
                var result = await sut.Get<Customers>(new[] { id1, id2 });

                // Assert
                result.Should().Contain(c => c.Id == id1)
                    .And.Contain(c => c.Id == id2)
                    .And.NotContain(c => c.Id == id3);
            }
        }
    }

}
