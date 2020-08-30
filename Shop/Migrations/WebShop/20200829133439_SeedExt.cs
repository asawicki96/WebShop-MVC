using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations.WebShop
{
    public partial class SeedExt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Address", "City", "Comment", "CreatedAt", "Email", "FirstName", "LastName", "PostalCode", "Price", "State" },
                values: new object[,]
                {
                    { 1, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(7746), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 16, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9901), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 15, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9897), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 14, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9893), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 13, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9889), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 11, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9877), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 10, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9873), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 9, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9868), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 12, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9885), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 7, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9856), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 6, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9852), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 5, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9844), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 4, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9840), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 3, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9832), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 2, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9786), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 },
                    { 8, "Jaśminowa 5", "Warszawa", "comment", new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9864), "janusz@gmail.com", "Janusz", "Kowalski", "20-220", "0,00", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 29, 15, 34, 38, 733, DateTimeKind.Local).AddTicks(6842), "120,99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8365), "60,99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8447), "290,99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8455), "300,00" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedAt", "Description", "Image", "IsActive", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8460), "Baseball cap description", "b_cap.png", true, "Baseball cap", "299,99" },
                    { 7, 1, new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8468), "Camping tent description", "camping_tent.png", true, "Camping tent", "179,99" },
                    { 8, 1, new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8472), "bicycle helmet description", "bike_helmet.png", true, "Bicycle helmet", "99,99" },
                    { 9, 1, new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8476), "football description", "football.png", true, "Football F500 Kipsta", "269,99" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 27, 21, 38, 47, 864, DateTimeKind.Local).AddTicks(3531), "120" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 27, 21, 38, 47, 868, DateTimeKind.Local).AddTicks(5345), "60" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 27, 21, 38, 47, 868, DateTimeKind.Local).AddTicks(5419), "290" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Price" },
                values: new object[] { new DateTime(2020, 8, 27, 21, 38, 47, 868, DateTimeKind.Local).AddTicks(5427), "300" });
        }
    }
}
