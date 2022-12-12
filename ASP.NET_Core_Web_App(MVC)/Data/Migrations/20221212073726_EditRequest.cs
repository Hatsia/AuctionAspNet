using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Web_App_MVC_.Data.Migrations
{
    public partial class EditRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Requests",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "Requests");
        }
    }
}
