using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetStartedWithEFCoreInAspNetMVC.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "OrderItemID",
                keyValue: 3,
                column: "Count",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "OrderItemID",
                keyValue: 3,
                column: "Count",
                value: 3);
        }
    }
}
