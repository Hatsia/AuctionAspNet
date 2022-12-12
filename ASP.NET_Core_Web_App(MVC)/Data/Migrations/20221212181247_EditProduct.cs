using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Web_App_MVC_.Data.Migrations
{
    public partial class EditProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartPrice",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartPrice",
                table: "Products",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
