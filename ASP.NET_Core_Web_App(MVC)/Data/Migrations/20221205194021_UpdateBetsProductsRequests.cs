using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Web_App_MVC_.Data.Migrations
{
    public partial class UpdateBetsProductsRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bet_AspNetUsers_IdentityUserId",
                table: "Bet");

            migrationBuilder.DropForeignKey(
                name: "FK_Bet_Products_ProductId",
                table: "Bet");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Customers_CustomerId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Products_ProductId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ProductId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Bet_IdentityUserId",
                table: "Bet");

            migrationBuilder.DropIndex(
                name: "IX_Bet_ProductId",
                table: "Bet");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Bet");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Bet");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUsersId",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUsersId",
                table: "Bet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "Bet",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_IdentityUsersId",
                table: "Requests",
                column: "IdentityUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ProductsId",
                table: "Requests",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Bet_IdentityUsersId",
                table: "Bet",
                column: "IdentityUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Bet_ProductsId",
                table: "Bet",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bet_AspNetUsers_IdentityUsersId",
                table: "Bet",
                column: "IdentityUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bet_Products_ProductsId",
                table: "Bet",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_IdentityUsersId",
                table: "Requests",
                column: "IdentityUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Products_ProductsId",
                table: "Requests",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bet_AspNetUsers_IdentityUsersId",
                table: "Bet");

            migrationBuilder.DropForeignKey(
                name: "FK_Bet_Products_ProductsId",
                table: "Bet");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_IdentityUsersId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Products_ProductsId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_IdentityUsersId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ProductsId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Bet_IdentityUsersId",
                table: "Bet");

            migrationBuilder.DropIndex(
                name: "IX_Bet_ProductsId",
                table: "Bet");

            migrationBuilder.DropColumn(
                name: "IdentityUsersId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "IdentityUsersId",
                table: "Bet");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "Bet");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Bet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Bet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ProductId",
                table: "Requests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Bet_IdentityUserId",
                table: "Bet",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bet_ProductId",
                table: "Bet",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bet_AspNetUsers_IdentityUserId",
                table: "Bet",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bet_Products_ProductId",
                table: "Bet",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Customers_CustomerId",
                table: "Requests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Products_ProductId",
                table: "Requests",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
