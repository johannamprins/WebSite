using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite1.Migrations
{
    public partial class TestM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_Items_ItemId",
                table: "shoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems");

            migrationBuilder.RenameTable(
                name: "shoppingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_ItemId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "shoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ItemId",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_Items_ItemId",
                table: "shoppingCartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
