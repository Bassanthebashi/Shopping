using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("26d300a1-fd46-4549-b2e5-2cdd6d5f9c92"), "HP 8Ram SSD", "../../../../assets/images/lap.jpg", "Laptop", 100m, 5 },
                    { new Guid("759e1606-0cbc-4096-843e-cef7b6e33460"), "grey for primary school", "../../../../assets/images/cr.jpg", "cravate", 50m, 5 },
                    { new Guid("b0b58849-71a7-4fce-9520-a4b1a8214730"), "Blue thin font", "../../../../assets/images/images.png", "Pen", 20m, 5 },
                    { new Guid("bc757cd4-6f41-4c5e-936a-1473f510fa00"), "Black Dell ", "../../../../assets/images/tav.png", "Tablet", 200m, 5 },
                    { new Guid("f2dcdb59-260e-4f6c-8621-3688784f7f6f"), "Large pink for Books", "../../../../assets/images/bag.png", "Bag", 300m, 5 },
                    { new Guid("f555f4bb-8c13-448f-9868-83a45af92adc"), "100 pages", "../../../../assets/images/note.png", "NoteBook", 10m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26d300a1-fd46-4549-b2e5-2cdd6d5f9c92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("759e1606-0cbc-4096-843e-cef7b6e33460"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0b58849-71a7-4fce-9520-a4b1a8214730"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc757cd4-6f41-4c5e-936a-1473f510fa00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2dcdb59-260e-4f6c-8621-3688784f7f6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f555f4bb-8c13-448f-9868-83a45af92adc"));

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
    }
}
