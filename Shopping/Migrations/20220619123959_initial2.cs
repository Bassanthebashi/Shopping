using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f2658a2-352c-4c0d-9af8-1056d89d2e0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("705bfd31-0072-4048-bc3f-eb3600906855"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd3128b-c5dc-4b91-9e71-4f018af6f6e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84543839-470f-413c-bd26-c6bb6f535f5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6d3d67c-49e1-4f7b-95d1-f5b0b70a5396"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df929cf2-2b9f-4e3f-9dee-fb2ceb32b504"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("4233d4a7-5f79-4719-841e-43f6db71eb05"), "HP 8Ram SSD", "../../../../assets/images/lap.png", "Laptop", 100m, 5 },
                    { new Guid("5671bc84-4af6-4b09-88c6-5dc395793cdd"), "100 pages", "../../../../assets/images/note.png", "NoteBook", 10m, 5 },
                    { new Guid("8651d3a7-41d1-4348-aea6-b523e57e24c1"), "Black Dell ", "../../../../assets/images/tav.png", "Tablet", 200m, 5 },
                    { new Guid("88cd4550-fd0b-44be-a210-ac4fc295bc09"), "grey for primary school", "../../../../assets/images/cr.png", "cravate", 50m, 5 },
                    { new Guid("bc003f02-f387-4ddb-9b61-1a7b441356bd"), "Blue thin font", "../../../../assets/images/images.png", "Pen", 20m, 5 },
                    { new Guid("d34de06e-3558-4de7-99f9-01873767a2df"), "Large pink for Books", "../../../../assets/images/bag.png", "Bag", 300m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4233d4a7-5f79-4719-841e-43f6db71eb05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5671bc84-4af6-4b09-88c6-5dc395793cdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8651d3a7-41d1-4348-aea6-b523e57e24c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88cd4550-fd0b-44be-a210-ac4fc295bc09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc003f02-f387-4ddb-9b61-1a7b441356bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d34de06e-3558-4de7-99f9-01873767a2df"));

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("4f2658a2-352c-4c0d-9af8-1056d89d2e0e"), "100 pages", "NoteBook", 10m, 5 },
                    { new Guid("705bfd31-0072-4048-bc3f-eb3600906855"), "Large pink for Books", "Bag", 300m, 5 },
                    { new Guid("7fd3128b-c5dc-4b91-9e71-4f018af6f6e2"), "grey for primary school", "cravate", 50m, 5 },
                    { new Guid("84543839-470f-413c-bd26-c6bb6f535f5b"), "Blue thin font", "Pen", 20m, 5 },
                    { new Guid("b6d3d67c-49e1-4f7b-95d1-f5b0b70a5396"), "Red Over Size", "Laptop", 100m, 5 },
                    { new Guid("df929cf2-2b9f-4e3f-9dee-fb2ceb32b504"), "Black Boy Friend", "Tablet", 200m, 5 }
                });
        }
    }
}
