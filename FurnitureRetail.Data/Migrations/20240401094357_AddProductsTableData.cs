using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureRetail.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0a94fb53-a659-4bc8-807b-19e94f4e5358"), "Canapea Rosie", 2010.0 },
                    { new Guid("66030eef-7f80-4ec7-b5f1-f1e1d504ce32"), "Canapea Rosie", 2010.0 },
                    { new Guid("7fc67451-3d9d-4c1a-b703-ce4bf29bfb2c"), "Mobile living moderna", 2220.0 },
                    { new Guid("9038322a-776f-4583-acf7-7ecde2338d08"), "Scaun piele", 600.0 },
                    { new Guid("9333660b-e2e0-4431-a52a-dfc09d9e64cc"), "Scaun birou", 400.0 },
                    { new Guid("c989b33c-0d57-41f5-b97a-8b8a23c2ba4c"), "Canapea Rosie", 2010.0 },
                    { new Guid("ce2cc3b5-f18f-41a6-b480-7659dbe1fefc"), "Canapea Rosie", 1200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
