using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSite1.Migrations
{
    public partial class testmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Face" },
                    { 2, null, "Eyes" },
                    { 3, null, "Brows" },
                    { 4, null, "Lips" },
                    { 5, null, "Brushes" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Though this is technically a primer, I use it as a light-coverage foundation, and it gives the most candle-lit, non-cakey glow you can possibly imagine.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074696-best-makeup-0013-charlotte-tilbury-wonderglow-40ml-0-1499864840-main-1529074664.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074696-best-makeup-0013-charlotte-tilbury-wonderglow-40ml-0-1499864840-main-1529074664.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Charlotte Tilbury Wonderglow Primer", 55.0 },
                    { 18, 2, "On the days I don't feel like wearing makeup, this miracle mascara always makes my lashes pop. While the lipstick colors and eye palettes change, it's a steady standby in my beauty arsenal.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074830-best-makeup-0002-toofacedbetterthansex-1529074822.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074830-best-makeup-0002-toofacedbetterthansex-1529074822.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Too Faced Better Than Sex Mascara", 26.0 },
                    { 21, 2, "Can't! Live! Without! Vaseline! Makeup remover? Check. A lil balm for chapped lips? Check. A dry cuticle? CHECK. Vaseline is my desert island beauty supply. Vas or die.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074752-best-makeup-0000-vaseline-1529074737.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074752-best-makeup-0000-vaseline-1529074737.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Vaseline Petroleum Jelly Original", 4.1900000000000004 },
                    { 26, 2, "A makeup artist friend recommended this lengthening mascara to me few years ago, and I’ve been using it ever since! I like having long dramatic lashes and this delivers. It stays on at the gym, but washes off easily at home, which is definitely a plus.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974123-31XkwMUYdhL.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974123-31XkwMUYdhL.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "L'Oréal Paris Makeup Telescopic Original Lengthening Mascara, Carbon Black", 8.4399999999999995 },
                    { 28, 2, "For a long time I was shelling out $34 for a YSL eyeliner that I swore was the best, but that was before I discovered Eyeko's $22 version. It's $12 cheaper, and has twice the staying power.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529066968-_102552863.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529066968-_102552863.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Skinny Mini Liquid Black Eyeliner", 12.0 },
                    { 30, 2, "Every single time I wear this mascara around our former ELLE writer Mattie Kahn asks, 'Oh my GOD are your lashes FAKE or just super long?' Reader, they are not, I'm just wearing this amazingly underrated product.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074803-best-makeup-0011-eyekolashalert-1529074781.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074803-best-makeup-0011-eyekolashalert-1529074781.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Eyeko Online Only Lash Alert Mascara", 26.0 },
                    { 34, 2, "This is the only makeup item I'm genuinely excited to repeat buy. With a truly tenacious formula, an applicator that's firm enough for a smooth line yet flexible enough for those all-important cat-eye flicks, this Stila savior has come home with me over and over again.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075183-best-makeup-0003-stilawaterproof-1529075172.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075183-best-makeup-0003-stilawaterproof-1529075172.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Stila Stay All Day Waterproof Liquid Eye Liner", 22.0 },
                    { 15, 2, "As far as drugstore mascaras go it doesn't get any better than Lash Paradise. It lengthens, separates, never clumps, and holds a curl all while coming in under $10. Buy in bulk.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078183-best-makeup-0002-lorealparishvolumelash-1529078173.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078183-best-makeup-0002-lorealparishvolumelash-1529078173.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "L'Oreal Paris Voluminous Lash Paradise Waterproof Mascara", 9.9700000000000006 },
                    { 3, 3, "This tiny but powerful tool fills in your brows with the most natural - looking finish.Its super skinny pencil mimics actual individual hairs, and the smudge - proof formula sticks on even without using a gel on top.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078075-best-makeup-0005-browwiz-1529078066.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078075-best-makeup-0005-browwiz-1529078066.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Anastasia Beverly Hills Brow Wiz", 23.0 },
                    { 6, 4, "Look, it’s just that good. This “lip gel” has a nice glossy finish without feeling sticky and has the perfect amount of pink tint to enhance the natural color of my lip without giving me that ashy pink look. You know the ashy pink look I’m talking about.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970921-screen-shot-2019-06-19-at-3-01-42-pm-1560970914.png?crop=0.7240915208613729xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970921-screen-shot-2019-06-19-at-3-01-42-pm-1560970914.png?crop=0.7240915208613729xw:1xh;center,top&resize=768:*", true, false, "Ultra Shine Lip Gel", 12.0 },
                    { 7, 4, "Carmex lip balm was introduced to me as a child (thanks mom!) and it's been my go-to ever since. No matter dry my lips are, this treatment hydrates and softens skin immediately.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976628-13048468.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976628-13048468.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Carmex Classic Medicated Lip Balm Tube", 2.77 },
                    { 9, 4, "The formula goes on smoothly (not sticky) and smells wonderfully. The All that Glitters shade amps up my natural lip tone without making them over the top!", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961038-Lipgloss_Coming_Up_Rose_1024x1024.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961038-Lipgloss_Coming_Up_Rose_1024x1024.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Perfect Shine Hydrating Lip Gloss", 12.0 },
                    { 23, 4, "I believe a bright, bold red lip is appropriate no matter the occasion: Work, home, dinner, parties, gym (yes, the gym!). This Maybelline lipstick in endless raisin is my go-to color. It slides on easy, doesn’t smudge, and lasts all.day.long.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974527-maybelline-1560974523.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974527-maybelline-1560974523.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Superstay 14 Hour Lipstick, Endless Raisin", 12.0 },
                    { 24, 4, "Every beauty bag needs a tinted lip balm for days you don't want to worry about a lipstick, but don't want naked lips. Dior's Lip Glow (a Bella Hadid favorite) is the ultimate, ultimate formula. Its ultra nourishing and adaptable: You can go light with the tint or layer for stronger color payoff. Plus, you don't need a mirror to apply.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078203-best-makeup-0004-dior-1529078192.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078203-best-makeup-0004-dior-1529078192.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Dior Addict Lip Glow Color Reviver Balm", 34.0 },
                    { 32, 4, "This product lives somewhere in the blissful, mythical space between a lipstick and lipgloss. It is the EXACT color of my lips and so it really just enhances what I already have in a pretty, natural way. Without a doubt the best lipstick I've ever used.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075296-best-makeup-0014-chanelrouse-1529075289.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075296-best-makeup-0014-chanelrouse-1529075289.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Chanel Rouge Hydrating Lip Colour", 40.0 },
                    { 31, 3, "Who would've thought QVC would be the brow bearer of my dreams? My makeup artist friend gifted me this precious little pot and not a single pencil from my past can compare. I always do my brows first, and use an angled brush to apply where my brow fullness falls short. Although it's a waxy formula, it settles like a powder—and doesn't require a setting powder or mist to stay in place all day.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075154-best-makeup-0009-fionastilesbrow-1529074967.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075154-best-makeup-0009-fionastilesbrow-1529074967.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Fiona Stiles Brow Sculpting Wax", 22.0 },
                    { 14, 2, "Charlotte Tilbury's shades are work-appropriate but can be amped up for any after-work hangouts. Plus, the bronzer and blush shades double as extra eyeshadow colors.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976777-charlotte-tilbury-face-palettes-instant-look-in-a-palette-beauty-glow.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976777-charlotte-tilbury-face-palettes-instant-look-in-a-palette-beauty-glow.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Instant Look in a Palette by Charlotte Tilbury", 75.0 },
                    { 13, 2, "Of all the drugstore and high-end eyeliners I’ve glided across my eyes, none comes close to the love I have for L’Oreal’s Infallible Super Slim. The rich pigment, ultra-fine tip, the easy application, and matte black finish—I have no choice but to stan!", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970423-14306432.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970423-14306432.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "L'Oreal Paris Cosmetics Infallible Super Slim Liquid Eyeliner", 7.3899999999999997 },
                    { 11, 2, "It's the perfect balance of light sheer coverage that can quickly transform into a full face beat. Beyond the versatility of the product, it's packed with goji berry (an antioxidant that does wonders for the skin!) and SPF 30. This product is the Michael Jordan of beauty; it's the GOAT.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075460-best-makeup-0010-fabskintint-1529075453.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075460-best-makeup-0010-fabskintint-1529075453.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "First Aid Beauty Hello FAB Triple Protection Skin Tint with Goji Berry SPF 30", 34.0 },
                    { 12, 1, "Flesh Firm Flesh stick foundations mix and match and go on with such ease", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961223-flesh-1560961213.jpg?crop=0.9989827060020345xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961223-flesh-1560961213.jpg?crop=0.9989827060020345xw:1xh;center,top&resize=768:*", true, false, "Soft, flattering foundation with a dewy finish by flesh beauty", 18.0 },
                    { 16, 1, "If you want to frost yourself in the most tried and true way, the tiny light-reflective particles of this classic highlighter stick will support that mission. It will never let you down, either; I got complimented on its very glowy but subtle effects just this week.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075262-best-makeup-0005-narsorgasm-1529075250.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075262-best-makeup-0005-narsorgasm-1529075250.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "NARS The Multiple", 39.0 },
                    { 17, 1, "Powder highlighters tend to sit on the surface of my skin but Lancome’s liquid gold seeps into my skin to give me a lit-from-within glow.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970587-3614271973788_CustomGlowDrops_BronzeGlow.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970587-3614271973788_CustomGlowDrops_BronzeGlow.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Teint Idole Ultra Custom Highlighting Drops", 35.0 },
                    { 19, 1, "I love this smoothing primer. It totally minimizes the appearance of all my pores, and doesn’t feel heavy on my face. Plus, a little goes a longggg way. One tiny tube lasted me for almost an entire year.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974687-porefessional-1560974682.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974687-porefessional-1560974682.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "The POREfessional Face Primer", 31.0 },
                    { 20, 1, "If dewy, your-skin-but-better is what you seek, look no further than this heavenly cushion compact from La Prairie. It has buildable, light-to-medium coverage that evens out skin tone, acts like a treatment thanks to its built-in essence, and magically feels like nothing on your face. I've never seen a foundation with such an undetectable finish (most foundations look/feel like masks), and though pricy, this formula can't be beat.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078130-best-makeup-0000-skincaviarlaprairie-1529078121.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078130-best-makeup-0000-skincaviarlaprairie-1529078121.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "La Prairie Essence-In Foundation", 210.0 },
                    { 25, 1, "I cannot sing MAKE's praises enough. My latest MAKE obsession is its Bronzing Brick. I switch between the Joshua Tree and Marfa shades, depending on how glorious my tan is on any given day. It offers a light contour that works for everyday, and, best of all its vegan, fragrance-free formula never irritates my sensitive skin.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074916-best-makeup-0007-makebronzingbrick-1529074904.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074916-best-makeup-0007-makebronzingbrick-1529074904.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "MAKE Bronzing Bricks", 12.0 },
                    { 27, 1, "I never was a foundation girl. I always deemed a base—especially full-coverage—too much of a mask atop my skin and my nine step care routine. I never knew how incomplete I looked, though, with a full face of makeup (brows, eyes, cheeks, highlight) on bare skin. But when I discovered Becca's full coverage formula, I fell in love. Although it's full coverage, when wearing it, I just look like I have amazing skin. My secret: apply a pea-sized amount on a damp foundation brush and massage all over my face. A little bit goes a long way, evens out my tone and texture, and makes for the perfect base for the rest of my kit.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529067090-s2076172-main-zoom.jpg?crop=0.667xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529067090-s2076172-main-zoom.jpg?crop=0.667xw:1xh;center,top&resize=768:*", true, false, "BECCA Ultimate Coverage 24-Hour Foundation", 44.0 },
                    { 29, 1, "Honest Beauty's Cream Blush is a new addition to my beauty arsenal. I've gotten so many compliments that I threw out my old blush. It's creamy, soft, and shimmery. Meghan Markle is also rumored to have worn this blush during her wedding to Prince Harry. Need I say more?", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075520-best-makeup-0008-honestbeautyblush-1529075512.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075520-best-makeup-0008-honestbeautyblush-1529075512.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Honest Beauty Cream Blush", 22.0 },
                    { 35, 1, "My skin tends to be oily and redness prone, so this easy powder is my go-to. It provides light coverage but makes my complexion look that much smoother.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075572-best-make-up-1529068595-s1848134-main-zoom-1529075560.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075572-best-make-up-1529068595-s1848134-main-zoom-1529075560.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Bare Minerals BarePro Performance Wear Powder Foundation", 31.0 },
                    { 36, 1, "This is, hands down, the best setting powder. Aside from smelling like summer, the powder has a unique design that ensures you don't get loose powder all over your vanity and clothes, but rather only along your your T-Zone to mattify.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078103-best-makeup-0001-marcjacobscoconutsetting-1529078090.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078103-best-makeup-0001-marcjacobscoconutsetting-1529078090.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Marc Jacobs Perfecting Coconut Setting Powder", 44.0 },
                    { 37, 1, "This is the first high-end beauty product I ever bought, so it holds a special place in my heart. The color is eye-catching, but I still love to wear it for a casual day if I'm feeling fancy.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075617-best-makeup-1529069024-s1495274-main-zoom-1529075587.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075617-best-makeup-1529069024-s1495274-main-zoom-1529075587.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "NARS Lipstick", 35.0 },
                    { 2, 2, "Milk Makeup", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971011-s2117976-main-zoom.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971011-s2117976-main-zoom.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "Blur + Set Matte Loose Setting Powder by Milk Makeup", 29.0 },
                    { 4, 2, "This palette is the holy grail: 12 different shades that work well together to build eye looks that range from simple to sultry depending on how they’re used together. It’s currently limited edition, but I’ll be gutted if it ever leaves!", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07", true, false, "Skin Deep Eye Palette by NARS", 59.0 },
                    { 8, 2, "Benefit’s They’re Real has always performed like a champ. It gives my barely visible lashes the extra oomph they need and, most importantly, stays put!", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971580-they-rereal-1560971569.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971580-they-rereal-1560971569.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "They're Real! Lengthening Mascara by Benefit Cosmetics", 24.0 },
                    { 10, 2, "Precision, pigment, and long-lasting results. That's what you get with Kat Von D's cult-favorite Tattoo Liner. You'll never have to do retouches or worry about smudges.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078156-best-makeup-0003-katvondliner-1529078146.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078156-best-makeup-0003-katvondliner-1529078146.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "Kat Von D Tattoo Liner", 21.0 },
                    { 33, 4, "Ruby Woo is the ultimate red matte lip and anyone who says otherwise just doesn't want you to sell this out. The evil geniuses at M.A.C. crafted this color years ago and whenever I want the ultimate sultry shade, I reach for my girl Ruby Woo. It's not drying and lasts all day long. She's perfect.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074650-best-makeup-0004-rubyroomac-1529074641.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074650-best-makeup-0004-rubyroomac-1529074641.jpg?crop=1xw:1xh;center,top&resize=768:*", true, true, "M.A.C. Red Lipstick in Ruby Woo", 15.73 },
                    { 22, 5, "Morphe’s M439 Brush is a classic. I use this brush to apply my liquid foundation and it blends the product out like a dream so no signs of streaks or patches, just a flawless mug.", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970675-morphe-1560970670.jpg?crop=1xw:1xh;center,top&resize=768:*", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970675-morphe-1560970670.jpg?crop=1xw:1xh;center,top&resize=768:*", true, false, "M439 Deluxe Buffer Brush", 14.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ItemId",
                table: "OrderDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ItemId",
                table: "ShoppingCartItems",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
