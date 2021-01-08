using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebSite1.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Face" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Eyes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Brows" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Lips" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Brushes" });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                Name = "Charlotte Tilbury Wonderglow Primer",
                Price = 55.00,
                Description = "Though this is technically a primer, I use it as a light-coverage foundation, and it gives the most candle-lit, non-cakey glow you can possibly imagine.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074696-best-makeup-0013-charlotte-tilbury-wonderglow-40ml-0-1499864840-main-1529074664.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074696-best-makeup-0013-charlotte-tilbury-wonderglow-40ml-0-1499864840-main-1529074664.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 2,
                Name = "Blur + Set Matte Loose Setting Powder by Milk Makeup",
                Price = 29.00,
                Description = "Milk Makeup",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971011-s2117976-main-zoom.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971011-s2117976-main-zoom.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Anastasia Beverly Hills Brow Wiz",
                Price = 23.00,
                Description = "This tiny but powerful tool fills in your brows with the most natural - looking finish.Its super skinny pencil mimics actual individual hairs, and the smudge - proof formula sticks on even without using a gel on top.",
                CategoryId = 3,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078075-best-makeup-0005-browwiz-1529078066.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078075-best-makeup-0005-browwiz-1529078066.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale= false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 4,
                Name = "Skin Deep Eye Palette by NARS",
                Price = 59.00,
                Description = "This palette is the holy grail: 12 different shades that work well together to build eye looks that range from simple to sultry depending on how they’re used together. It’s currently limited edition, but I’ll be gutted if it ever leaves!",
                CategoryId = 2,
                ImageUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                ImageThumbnailUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                IsInStock = true,
                IsOnSale= false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 6,
                Name = "Ultra Shine Lip Gel",
                Price = 12.00,
                Description = "Look, it’s just that good. This “lip gel” has a nice glossy finish without feeling sticky and has the perfect amount of pink tint to enhance the natural color of my lip without giving me that ashy pink look. You know the ashy pink look I’m talking about.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970921-screen-shot-2019-06-19-at-3-01-42-pm-1560970914.png?crop=0.7240915208613729xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970921-screen-shot-2019-06-19-at-3-01-42-pm-1560970914.png?crop=0.7240915208613729xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 7,
                Name = "Carmex Classic Medicated Lip Balm Tube",
                Price = 2.77,
                Description = "Carmex lip balm was introduced to me as a child (thanks mom!) and it's been my go-to ever since. No matter dry my lips are, this treatment hydrates and softens skin immediately.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976628-13048468.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976628-13048468.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 8,
                Name = "They're Real! Lengthening Mascara by Benefit Cosmetics",
                Price = 24.00,
                Description = "Benefit’s They’re Real has always performed like a champ. It gives my barely visible lashes the extra oomph they need and, most importantly, stays put!",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971580-they-rereal-1560971569.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560971580-they-rereal-1560971569.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 9,
                Name = "Perfect Shine Hydrating Lip Gloss",
                Price = 12.00,
                Description = "The formula goes on smoothly (not sticky) and smells wonderfully. The All that Glitters shade amps up my natural lip tone without making them over the top!",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961038-Lipgloss_Coming_Up_Rose_1024x1024.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961038-Lipgloss_Coming_Up_Rose_1024x1024.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 10,
                Name = "Kat Von D Tattoo Liner",
                Price = 21.00,
                Description = "Precision, pigment, and long-lasting results. That's what you get with Kat Von D's cult-favorite Tattoo Liner. You'll never have to do retouches or worry about smudges.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078156-best-makeup-0003-katvondliner-1529078146.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078156-best-makeup-0003-katvondliner-1529078146.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 11,
                Name = "First Aid Beauty Hello FAB Triple Protection Skin Tint with Goji Berry SPF 30",
                Price = 34.00,
                Description = "It's the perfect balance of light sheer coverage that can quickly transform into a full face beat. Beyond the versatility of the product, it's packed with goji berry (an antioxidant that does wonders for the skin!) and SPF 30. This product is the Michael Jordan of beauty; it's the GOAT.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075460-best-makeup-0010-fabskintint-1529075453.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075460-best-makeup-0010-fabskintint-1529075453.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 12,
                Name = "Soft, flattering foundation with a dewy finish by flesh beauty",
                Price = 18.00,
                Description = "Flesh Firm Flesh stick foundations mix and match and go on with such ease",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961223-flesh-1560961213.jpg?crop=0.9989827060020345xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560961223-flesh-1560961213.jpg?crop=0.9989827060020345xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 13,
                Name = "L'Oreal Paris Cosmetics Infallible Super Slim Liquid Eyeliner",
                Price = 7.39,
                Description = "Of all the drugstore and high-end eyeliners I’ve glided across my eyes, none comes close to the love I have for L’Oreal’s Infallible Super Slim. The rich pigment, ultra-fine tip, the easy application, and matte black finish—I have no choice but to stan!",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970423-14306432.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970423-14306432.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 14,
                Name = "Instant Look in a Palette by Charlotte Tilbury",
                Price = 75.00,
                Description = "Charlotte Tilbury's shades are work-appropriate but can be amped up for any after-work hangouts. Plus, the bronzer and blush shades double as extra eyeshadow colors.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976777-charlotte-tilbury-face-palettes-instant-look-in-a-palette-beauty-glow.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560976777-charlotte-tilbury-face-palettes-instant-look-in-a-palette-beauty-glow.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 15,
                Name = "L'Oreal Paris Voluminous Lash Paradise Waterproof Mascara",
                Price = 9.97,
                Description = "As far as drugstore mascaras go it doesn't get any better than Lash Paradise. It lengthens, separates, never clumps, and holds a curl all while coming in under $10. Buy in bulk.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078183-best-makeup-0002-lorealparishvolumelash-1529078173.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078183-best-makeup-0002-lorealparishvolumelash-1529078173.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 16,
                Name = "NARS The Multiple",
                Price = 39.00,
                Description = "If you want to frost yourself in the most tried and true way, the tiny light-reflective particles of this classic highlighter stick will support that mission. It will never let you down, either; I got complimented on its very glowy but subtle effects just this week.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075262-best-makeup-0005-narsorgasm-1529075250.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075262-best-makeup-0005-narsorgasm-1529075250.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 17,
                Name = "Teint Idole Ultra Custom Highlighting Drops",
                Price = 35.00,
                Description = "Powder highlighters tend to sit on the surface of my skin but Lancome’s liquid gold seeps into my skin to give me a lit-from-within glow.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970587-3614271973788_CustomGlowDrops_BronzeGlow.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970587-3614271973788_CustomGlowDrops_BronzeGlow.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 18,
                Name = "Too Faced Better Than Sex Mascara",
                Price = 26.00,
                Description = "On the days I don't feel like wearing makeup, this miracle mascara always makes my lashes pop. While the lipstick colors and eye palettes change, it's a steady standby in my beauty arsenal.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074830-best-makeup-0002-toofacedbetterthansex-1529074822.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074830-best-makeup-0002-toofacedbetterthansex-1529074822.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 19,
                Name = "The POREfessional Face Primer",
                Price = 31.00,
                Description = "I love this smoothing primer. It totally minimizes the appearance of all my pores, and doesn’t feel heavy on my face. Plus, a little goes a longggg way. One tiny tube lasted me for almost an entire year.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974687-porefessional-1560974682.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974687-porefessional-1560974682.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 20,
                Name = "La Prairie Essence-In Foundation",
                Price = 210.00,
                Description = "If dewy, your-skin-but-better is what you seek, look no further than this heavenly cushion compact from La Prairie. It has buildable, light-to-medium coverage that evens out skin tone, acts like a treatment thanks to its built-in essence, and magically feels like nothing on your face. I've never seen a foundation with such an undetectable finish (most foundations look/feel like masks), and though pricy, this formula can't be beat.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078130-best-makeup-0000-skincaviarlaprairie-1529078121.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078130-best-makeup-0000-skincaviarlaprairie-1529078121.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 21,
                Name = "Vaseline Petroleum Jelly Original",
                Price = 4.19,
                Description = "Can't! Live! Without! Vaseline! Makeup remover? Check. A lil balm for chapped lips? Check. A dry cuticle? CHECK. Vaseline is my desert island beauty supply. Vas or die.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074752-best-makeup-0000-vaseline-1529074737.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074752-best-makeup-0000-vaseline-1529074737.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 22,
                Name = "M439 Deluxe Buffer Brush",
                Price = 14.00,
                Description = "Morphe’s M439 Brush is a classic. I use this brush to apply my liquid foundation and it blends the product out like a dream so no signs of streaks or patches, just a flawless mug.",
                CategoryId = 5,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970675-morphe-1560970670.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560970675-morphe-1560970670.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 23,
                Name = "Superstay 14 Hour Lipstick, Endless Raisin",
                Price = 12.00,
                Description = "I believe a bright, bold red lip is appropriate no matter the occasion: Work, home, dinner, parties, gym (yes, the gym!). This Maybelline lipstick in endless raisin is my go-to color. It slides on easy, doesn’t smudge, and lasts all.day.long.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974527-maybelline-1560974523.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974527-maybelline-1560974523.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 24,
                Name = "Dior Addict Lip Glow Color Reviver Balm",
                Price = 34.00,
                Description = "Every beauty bag needs a tinted lip balm for days you don't want to worry about a lipstick, but don't want naked lips. Dior's Lip Glow (a Bella Hadid favorite) is the ultimate, ultimate formula. Its ultra nourishing and adaptable: You can go light with the tint or layer for stronger color payoff. Plus, you don't need a mirror to apply.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078203-best-makeup-0004-dior-1529078192.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078203-best-makeup-0004-dior-1529078192.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 25,
                Name = "MAKE Bronzing Bricks",
                Price = 12.00,
                Description = "I cannot sing MAKE's praises enough. My latest MAKE obsession is its Bronzing Brick. I switch between the Joshua Tree and Marfa shades, depending on how glorious my tan is on any given day. It offers a light contour that works for everyday, and, best of all its vegan, fragrance-free formula never irritates my sensitive skin.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074916-best-makeup-0007-makebronzingbrick-1529074904.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074916-best-makeup-0007-makebronzingbrick-1529074904.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 26,
                Name = "L'Oréal Paris Makeup Telescopic Original Lengthening Mascara, Carbon Black",
                Price = 8.44,
                Description = "A makeup artist friend recommended this lengthening mascara to me few years ago, and I’ve been using it ever since! I like having long dramatic lashes and this delivers. It stays on at the gym, but washes off easily at home, which is definitely a plus.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974123-31XkwMUYdhL.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560974123-31XkwMUYdhL.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 27,
                Name = "BECCA Ultimate Coverage 24-Hour Foundation",
                Price = 44.00,
                Description = "I never was a foundation girl. I always deemed a base—especially full-coverage—too much of a mask atop my skin and my nine step care routine. I never knew how incomplete I looked, though, with a full face of makeup (brows, eyes, cheeks, highlight) on bare skin. But when I discovered Becca's full coverage formula, I fell in love. Although it's full coverage, when wearing it, I just look like I have amazing skin. My secret: apply a pea-sized amount on a damp foundation brush and massage all over my face. A little bit goes a long way, evens out my tone and texture, and makes for the perfect base for the rest of my kit.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529067090-s2076172-main-zoom.jpg?crop=0.667xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529067090-s2076172-main-zoom.jpg?crop=0.667xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 28,
                Name = "Skinny Mini Liquid Black Eyeliner",
                Price = 12.00,
                Description = "For a long time I was shelling out $34 for a YSL eyeliner that I swore was the best, but that was before I discovered Eyeko's $22 version. It's $12 cheaper, and has twice the staying power.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529066968-_102552863.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529066968-_102552863.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 29,
                Name = "Honest Beauty Cream Blush",
                Price = 22.00,
                Description = "Honest Beauty's Cream Blush is a new addition to my beauty arsenal. I've gotten so many compliments that I threw out my old blush. It's creamy, soft, and shimmery. Meghan Markle is also rumored to have worn this blush during her wedding to Prince Harry. Need I say more?",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075520-best-makeup-0008-honestbeautyblush-1529075512.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075520-best-makeup-0008-honestbeautyblush-1529075512.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 30,
                Name = "Eyeko Online Only Lash Alert Mascara",
                Price = 26.00,
                Description = "Every single time I wear this mascara around our former ELLE writer Mattie Kahn asks, 'Oh my GOD are your lashes FAKE or just super long?' Reader, they are not, I'm just wearing this amazingly underrated product.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074803-best-makeup-0011-eyekolashalert-1529074781.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074803-best-makeup-0011-eyekolashalert-1529074781.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 31,
                Name = "Fiona Stiles Brow Sculpting Wax",
                Price = 22.00,
                Description = "Who would've thought QVC would be the brow bearer of my dreams? My makeup artist friend gifted me this precious little pot and not a single pencil from my past can compare. I always do my brows first, and use an angled brush to apply where my brow fullness falls short. Although it's a waxy formula, it settles like a powder—and doesn't require a setting powder or mist to stay in place all day.",
                CategoryId = 3,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075154-best-makeup-0009-fionastilesbrow-1529074967.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075154-best-makeup-0009-fionastilesbrow-1529074967.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 32,
                Name = "Chanel Rouge Hydrating Lip Colour",
                Price = 40.00,
                Description = "This product lives somewhere in the blissful, mythical space between a lipstick and lipgloss. It is the EXACT color of my lips and so it really just enhances what I already have in a pretty, natural way. Without a doubt the best lipstick I've ever used.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075296-best-makeup-0014-chanelrouse-1529075289.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075296-best-makeup-0014-chanelrouse-1529075289.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 33,
                Name = "M.A.C. Red Lipstick in Ruby Woo",
                Price = 15.73,
                Description = "Ruby Woo is the ultimate red matte lip and anyone who says otherwise just doesn't want you to sell this out. The evil geniuses at M.A.C. crafted this color years ago and whenever I want the ultimate sultry shade, I reach for my girl Ruby Woo. It's not drying and lasts all day long. She's perfect.",
                CategoryId = 4,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074650-best-makeup-0004-rubyroomac-1529074641.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529074650-best-makeup-0004-rubyroomac-1529074641.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 34,
                Name = "Stila Stay All Day Waterproof Liquid Eye Liner",
                Price = 22.00,
                Description = "This is the only makeup item I'm genuinely excited to repeat buy. With a truly tenacious formula, an applicator that's firm enough for a smooth line yet flexible enough for those all-important cat-eye flicks, this Stila savior has come home with me over and over again.",
                CategoryId = 2,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075183-best-makeup-0003-stilawaterproof-1529075172.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075183-best-makeup-0003-stilawaterproof-1529075172.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 35,
                Name = "Bare Minerals BarePro Performance Wear Powder Foundation",
                Price = 31.00,
                Description = "My skin tends to be oily and redness prone, so this easy powder is my go-to. It provides light coverage but makes my complexion look that much smoother.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075572-best-make-up-1529068595-s1848134-main-zoom-1529075560.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075572-best-make-up-1529068595-s1848134-main-zoom-1529075560.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 36,
                Name = "Marc Jacobs Perfecting Coconut Setting Powder",
                Price = 44.00,
                Description = "This is, hands down, the best setting powder. Aside from smelling like summer, the powder has a unique design that ensures you don't get loose powder all over your vanity and clothes, but rather only along your your T-Zone to mattify.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078103-best-makeup-0001-marcjacobscoconutsetting-1529078090.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529078103-best-makeup-0001-marcjacobscoconutsetting-1529078090.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 37,
                Name = "NARS Lipstick",
                Price = 35.00,
                Description = "This is the first high-end beauty product I ever bought, so it holds a special place in my heart. The color is eye-catching, but I still love to wear it for a casual day if I'm feeling fancy.",
                CategoryId = 1,
                ImageUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075617-best-makeup-1529069024-s1495274-main-zoom-1529075587.jpg?crop=1xw:1xh;center,top&resize=768:*",
                ImageThumbnailUrl = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1529075617-best-makeup-1529069024-s1495274-main-zoom-1529075587.jpg?crop=1xw:1xh;center,top&resize=768:*",
                IsInStock = true,
                IsOnSale = true
            });


        }
    }
}
