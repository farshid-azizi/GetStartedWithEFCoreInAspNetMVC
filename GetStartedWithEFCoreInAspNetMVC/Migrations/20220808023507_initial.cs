using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetStartedWithEFCoreInAspNetMVC.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Plaq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderState = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "DateOfBirth", "Family", "Name" },
                values: new object[,]
                {
                    { 25, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "azizi", "farshid" },
                    { 50, new DateTime(2009, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "amiri", "reza" },
                    { 75, new DateTime(1983, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "naseri", "amir" },
                    { 100, new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emadi", "shirin" },
                    { 125, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tehrani", "maryam" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderID", "CustomerID", "OrderDate", "OrderState" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 50, new DateTime(2022, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "", "productA", 1000m },
                    { 20, "", "productB", 36000m },
                    { 30, "", "productC", 65200m },
                    { 40, "", "productD", 1500m },
                    { 50, "", "productE", 14000m },
                    { 60, "", "productF", 63520m },
                    { 100, "", "productG", 500m }
                });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemID", "Count", "OrderId", "Price", "ProductID" },
                values: new object[] { 1, 1, 1, 1000m, 10 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemID", "Count", "OrderId", "Price", "ProductID" },
                values: new object[] { 2, 2, 1, 63520m, 60 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "OrderItemID", "Count", "OrderId", "Price", "ProductID" },
                values: new object[] { 3, 3, 2, 490m, 100 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
