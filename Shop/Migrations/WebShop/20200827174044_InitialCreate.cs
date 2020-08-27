using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations.WebShop
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 6, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "sport category description", "sport.png", "Sport" },
                    { 2, "garden category description", "garden.png", "Garden" },
                    { 3, "automotive category description", "automotive.png", "Automotive" },
                    { 4, "home category description", "home.png", "Home" },
                    { 5, "animals category description", "animals.png", "Animals" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedAt", "Description", "Image", "IsActive", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2020, 8, 27, 19, 40, 44, 316, DateTimeKind.Local).AddTicks(6265), "Gloves description", "gloves.png", true, "Gloves Everlast XL", 120m },
                    { 3, 1, new DateTime(2020, 8, 27, 19, 40, 44, 320, DateTimeKind.Local).AddTicks(2927), "T-shirt description", "t-shirt.png", true, "T-shirt Everlast XL", 60m },
                    { 4, 1, new DateTime(2020, 8, 27, 19, 40, 44, 320, DateTimeKind.Local).AddTicks(3005), "trousers description", "trousers.png", true, "Adidas trousers", 290m },
                    { 5, 1, new DateTime(2020, 8, 27, 19, 40, 44, 320, DateTimeKind.Local).AddTicks(3014), "band description", "miband.png", true, "Mi Band", 300m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductId",
                table: "Items",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
