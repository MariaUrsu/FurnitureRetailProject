using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurnitureRetail.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddValuesForRegistrationDateAndNumberOfProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1583f3d3-3599-4b4e-b5f0-600e9ef02646"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 1, new DateOnly(2020, 5, 14) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("22990a82-b99e-441f-9c4c-d9e4aa18250f"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 10, new DateOnly(2022, 1, 24) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2738a17a-a696-478c-a817-446a0d2701d5"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 53, new DateOnly(1995, 1, 5) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("40c23afc-8c4e-4fa1-99c5-4b5e1495e83c"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 3, new DateOnly(2021, 7, 2) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("48fe8061-7f7d-46cb-96e3-3cd42c33bf47"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 3, new DateOnly(2000, 10, 27) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("49b04f59-8ac7-4ab8-8fae-80f7ce165000"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 32, new DateOnly(2022, 2, 24) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5212a8a1-4b4e-4356-8c02-b7a87655a689"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 43, new DateOnly(2022, 1, 16) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8ab0f995-2489-4ae4-bf50-2896be2175b3"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 3, new DateOnly(2014, 7, 21) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("99c78841-c4a9-485a-943d-1f2291d86a82"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 31, new DateOnly(2020, 10, 20) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a91bd871-ba4d-4c0b-afcf-0f765a26f978"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 100, new DateOnly(2020, 10, 18) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1583f3d3-3599-4b4e-b5f0-600e9ef02646"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("22990a82-b99e-441f-9c4c-d9e4aa18250f"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2738a17a-a696-478c-a817-446a0d2701d5"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("40c23afc-8c4e-4fa1-99c5-4b5e1495e83c"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("48fe8061-7f7d-46cb-96e3-3cd42c33bf47"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("49b04f59-8ac7-4ab8-8fae-80f7ce165000"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5212a8a1-4b4e-4356-8c02-b7a87655a689"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8ab0f995-2489-4ae4-bf50-2896be2175b3"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("99c78841-c4a9-485a-943d-1f2291d86a82"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a91bd871-ba4d-4c0b-afcf-0f765a26f978"),
                columns: new[] { "NumberOfSelledProducts", "RegistrationDate" },
                values: new object[] { 0, new DateOnly(1, 1, 1) });
        }
    }
}
