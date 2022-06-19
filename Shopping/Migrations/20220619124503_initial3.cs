using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("4486e482-63d0-41b4-9ee4-83790c51c414"), "Black Dell ", "../../../../assets/images/tav.png", "Tablet", 200m, 5 },
                    { new Guid("56753e26-d070-4314-a1fa-268c75e35c35"), "Blue thin font", "../../../../assets/images/images.png", "Pen", 20m, 5 },
                    { new Guid("92be6f81-bb07-4c49-b304-ad052403b7a7"), "100 pages", "../../../../assets/images/note.png", "NoteBook", 10m, 5 },
                    { new Guid("ae9b017d-4fe2-46b7-a406-3480bfc0c17e"), "Large pink for Books", "../../../../assets/images/bag.png", "Bag", 300m, 5 },
                    { new Guid("d6ebaa9d-c222-4338-9ef3-93a119bac11a"), "grey for primary school", "../../../../assets/images/cr.jpg", "cravate", 50m, 5 },
                    { new Guid("d8bd6135-3675-4bc8-ab31-2a1e99fd39f9"), "HP 8Ram SSD", "../../../../assets/images/lap.jpg", "Laptop", 100m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4486e482-63d0-41b4-9ee4-83790c51c414"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56753e26-d070-4314-a1fa-268c75e35c35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92be6f81-bb07-4c49-b304-ad052403b7a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae9b017d-4fe2-46b7-a406-3480bfc0c17e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6ebaa9d-c222-4338-9ef3-93a119bac11a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d8bd6135-3675-4bc8-ab31-2a1e99fd39f9"));

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
    }
}
