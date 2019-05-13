using Microsoft.EntityFrameworkCore.Migrations;

namespace fooddeliveryback.Migrations
{
    public partial class fixInOrderIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_InOrders_InOrderId",
                table: "MenuItems");

            migrationBuilder.DropIndex(
                name: "IX_MenuItems_InOrderId",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "InOrderId",
                table: "MenuItems");

            migrationBuilder.AddColumn<int>(
                name: "MenuItemId",
                table: "InOrders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InOrders_MenuItemId",
                table: "InOrders",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_InOrders_MenuItems_MenuItemId",
                table: "InOrders",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOrders_MenuItems_MenuItemId",
                table: "InOrders");

            migrationBuilder.DropIndex(
                name: "IX_InOrders_MenuItemId",
                table: "InOrders");

            migrationBuilder.DropColumn(
                name: "MenuItemId",
                table: "InOrders");

            migrationBuilder.AddColumn<int>(
                name: "InOrderId",
                table: "MenuItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_InOrderId",
                table: "MenuItems",
                column: "InOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_InOrders_InOrderId",
                table: "MenuItems",
                column: "InOrderId",
                principalTable: "InOrders",
                principalColumn: "InOrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
