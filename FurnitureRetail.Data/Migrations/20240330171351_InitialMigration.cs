using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureRetail.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    NumberOfSelledProducts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "NumberOfSelledProducts", "Password", "RegistrationDate" },
                values: new object[,]
                {
                    { new Guid("1583f3d3-3599-4b4e-b5f0-600e9ef02646"), "david.martinez@example6.net", "David", "Martinez", 0, "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f", new DateOnly(1, 1, 1) },
                    { new Guid("22990a82-b99e-441f-9c4c-d9e4aa18250f"), "ethan.adams@example10.com", "Ethan", "Adams", 0, "1699a71dcf40f92bf361c1860bfc616da003db42a44cec1e0450b16f7fbc43ee", new DateOnly(1, 1, 1) },
                    { new Guid("2738a17a-a696-478c-a817-446a0d2701d5"), "jessica.anderson@example7.com", "Jessica", "Anderson", 0, "27cc6994fc1c01ce6659c6bddca9b69c4c6a9418065e612c69d110b3f7b11f8a", new DateOnly(1, 1, 1) },
                    { new Guid("40c23afc-8c4e-4fa1-99c5-4b5e1495e83c"), "olivia.rodrigo@example5.ro", "Olivia", "Rodrigo", 0, "59c225b0465d04c2cffc0886328c954caac0243b87cca027f5196ab13acef430", new DateOnly(1, 1, 1) },
                    { new Guid("48fe8061-7f7d-46cb-96e3-3cd42c33bf47"), "christopher.lee@example8.org", "Christopher", "Lee", 0, "86de60b988397b1d344c42fc7f6e3aa607036b9deb32d693a8e527e18e39e8f5", new DateOnly(1, 1, 1) },
                    { new Guid("49b04f59-8ac7-4ab8-8fae-80f7ce165000"), "john.smith@example2.org", "John", "Smith", 0, "245b22dce938051efc28cf4364928fa26e171db139755311a93703ba65fd6d07", new DateOnly(1, 1, 1) },
                    { new Guid("5212a8a1-4b4e-4356-8c02-b7a87655a689"), "michael.brown@example4.com", "Michael", "Brown", 0, "2ed06766795d58a4f22d511a672f20a6b096d3fe5b56af3a744678a9a356fd82", new DateOnly(1, 1, 1) },
                    { new Guid("8ab0f995-2489-4ae4-bf50-2896be2175b3"), "sarah_wilson@example9.org", "Sarah", "Wilson", 0, "97c94ebe5d767a353b77f3c0ce2d429741f2e8c99473c3c150e2faa3d14c9da6", new DateOnly(1, 1, 1) },
                    { new Guid("99c78841-c4a9-485a-943d-1f2291d86a82"), "alice.johnson@example1.com", "Alice", "Johnson", 0, "f7745f4df4394027716de160fb2acd6aac36699576a8be586b75ac09acf6a0df", new DateOnly(1, 1, 1) },
                    { new Guid("a91bd871-ba4d-4c0b-afcf-0f765a26f978"), "emily.davis@example3.net", "Emily", "Davis", 0, "e493c394a28652900d73f0fc7e6713840b1af0ab1f3fd9c5878d82e5f753c6c1", new DateOnly(1, 1, 1) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
