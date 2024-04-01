using FurnitureRetail.Core;
using Microsoft.EntityFrameworkCore;

namespace FurnitureRetail.Data.Context;
public class FurnitureRetailDbContext : DbContext
{
    public FurnitureRetailDbContext(DbContextOptions<FurnitureRetailDbContext> options) : base(options)
    {
    }

    public DbSet<Customers> Customers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customers>().HasData(
            new Customers { Id = new Guid("99c78841-c4a9-485a-943d-1f2291d86a82"), FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example1.com", Password = "f7745f4df4394027716de160fb2acd6aac36699576a8be586b75ac09acf6a0df", RegistrationDate = new DateOnly(2020, 10, 20), NumberOfSelledProducts = 31 }, //P@ssw0rd1
            new Customers { Id = new Guid("49b04f59-8ac7-4ab8-8fae-80f7ce165000"), FirstName = "John", LastName = "Smith", Email = "john.smith@example2.org", Password = "245b22dce938051efc28cf4364928fa26e171db139755311a93703ba65fd6d07", RegistrationDate = new DateOnly(2022, 2, 24), NumberOfSelledProducts = 32 }, //SecurePassword123
            new Customers { Id = new Guid("a91bd871-ba4d-4c0b-afcf-0f765a26f978"), FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example3.net", Password = "e493c394a28652900d73f0fc7e6713840b1af0ab1f3fd9c5878d82e5f753c6c1", RegistrationDate = new DateOnly(2020, 10, 18), NumberOfSelledProducts = 100 }, //MyP@ssw0rd!
            new Customers { Id = new Guid("5212a8a1-4b4e-4356-8c02-b7a87655a689"), FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example4.com", Password = "2ed06766795d58a4f22d511a672f20a6b096d3fe5b56af3a744678a9a356fd82", RegistrationDate = new DateOnly(2022, 1, 16), NumberOfSelledProducts = 43 },//Secret123
            new Customers { Id = new Guid("40c23afc-8c4e-4fa1-99c5-4b5e1495e83c"), FirstName = "Olivia", LastName = "Rodrigo", Email = "olivia.rodrigo@example5.ro", Password = "59c225b0465d04c2cffc0886328c954caac0243b87cca027f5196ab13acef430", RegistrationDate = new DateOnly(2021, 7, 2), NumberOfSelledProducts = 3 },//2Good4U
            new Customers { Id = new Guid("1583f3d3-3599-4b4e-b5f0-600e9ef02646"), FirstName = "David", LastName = "Martinez", Email = "david.martinez@example6.net", Password = "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f", RegistrationDate = new DateOnly(2020, 5, 14), NumberOfSelledProducts = 1 },//12345678
            new Customers { Id = new Guid("2738a17a-a696-478c-a817-446a0d2701d5"), FirstName = "Jessica", LastName = "Anderson", Email = "jessica.anderson@example7.com", Password = "27cc6994fc1c01ce6659c6bddca9b69c4c6a9418065e612c69d110b3f7b11f8a", RegistrationDate = new DateOnly(1995, 01, 5), NumberOfSelledProducts = 53 },//hello123
            new Customers { Id = new Guid("48fe8061-7f7d-46cb-96e3-3cd42c33bf47"), FirstName = "Christopher", LastName = "Lee", Email = "christopher.lee@example8.org", Password = "86de60b988397b1d344c42fc7f6e3aa607036b9deb32d693a8e527e18e39e8f5", RegistrationDate = new DateOnly(2000, 10, 27), NumberOfSelledProducts = 3 },//p@ssword!
            new Customers { Id = new Guid("8ab0f995-2489-4ae4-bf50-2896be2175b3"), FirstName = "Sarah", LastName = "Wilson", Email = "sarah_wilson@example9.org", Password = "97c94ebe5d767a353b77f3c0ce2d429741f2e8c99473c3c150e2faa3d14c9da6", RegistrationDate = new DateOnly(2014, 7, 21), NumberOfSelledProducts = 3 },//Pa$$w0rd
            new Customers { Id = new Guid("22990a82-b99e-441f-9c4c-d9e4aa18250f"), FirstName = "Ethan", LastName = "Adams", Email = "ethan.adams@example10.com", Password = "1699a71dcf40f92bf361c1860bfc616da003db42a44cec1e0450b16f7fbc43ee", RegistrationDate = new DateOnly(2022, 1, 24), NumberOfSelledProducts = 10 }//Ceapa123
            );
        modelBuilder.Entity<Products>().HasData(
            new Products { Id = new Guid("66030eef-7f80-4ec7-b5f1-f1e1d504ce32"), Name = "Canapea Rosie", Price = 2010 },
            new Products { Id = new Guid("9038322a-776f-4583-acf7-7ecde2338d08"), Name = "Scaun piele", Price = 600 },
            new Products { Id = new Guid("9333660b-e2e0-4431-a52a-dfc09d9e64cc"), Name = "Scaun birou", Price = 400 },
            new Products { Id = new Guid("7fc67451-3d9d-4c1a-b703-ce4bf29bfb2c"), Name = "Mobile living moderna", Price = 2220 },
            new Products { Id = new Guid("ce2cc3b5-f18f-41a6-b480-7659dbe1fefc"), Name = "Canapea Rosie", Price = 1200 },
            new Products { Id = new Guid("c989b33c-0d57-41f5-b97a-8b8a23c2ba4c"), Name = "Canapea Rosie", Price = 2010 },
            new Products { Id = new Guid("0a94fb53-a659-4bc8-807b-19e94f4e5358"), Name = "Canapea Rosie", Price = 2010 }
            );
    }
}

public sealed class NoFurnitureRetailDbContext : FurnitureRetailDbContext
{
    public NoFurnitureRetailDbContext(DbContextOptions<NoFurnitureRetailDbContext> options)
        : base(new DbContextOptions<FurnitureRetailDbContext>(options.Extensions.ToDictionary(c => c.GetType())))
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
}
