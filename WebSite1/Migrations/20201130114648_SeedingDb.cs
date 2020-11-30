using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite1.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Chocolate Candy" },
                    { 2, null, "Fruit Candy" },
                    { 3, null, "Gummy Candy" },
                    { 4, null, "Halloween Candy" },
                    { 5, null, "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnsale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", true, false, "Assorted Chocolate Candy", 4.9500000000000002 },
                    { 2, 1, "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", true, true, "Another Assorted Chocolate Candy", 3.9500000000000002 },
                    { 3, 1, "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", true, false, "Another Chocolate Candy", 5.75 },
                    { 4, 2, "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", true, false, "Assorted Fruit Candy", 3.9500000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
