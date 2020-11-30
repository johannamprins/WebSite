using Microsoft.EntityFrameworkCore;

namespace WebSite1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chocolate Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Gummy Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Halloween Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Hard Candy" });

            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 1,
                Name = "Assorted Chocolate Candy",
                Price = 4.95,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                CategoryId = 1,
                ImageUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                ImageThumbnailUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                IsInStock = true,
                IsOnsale = false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 2,
                Name = "Another Assorted Chocolate Candy",
                Price = 3.95,
                Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                CategoryId = 1,
                ImageUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                ImageThumbnailUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                IsInStock = true,
                IsOnsale = true
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Another Chocolate Candy",
                Price = 5.75,
                Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                CategoryId = 1,
                ImageUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                ImageThumbnailUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                IsInStock = true,
                IsOnsale= false
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 4,
                Name = "Assorted Fruit Candy",
                Price = 3.95,
                Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                CategoryId = 2,
                ImageUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                ImageThumbnailUrl = "https://www.keemia.ee/sites/default/files/styles/page_large/public/2018-04/DDIFFERENCE-Natural-Beauty_group_web_0.jpg?itok=ycw_yg07",
                IsInStock = true,
                IsOnsale= false
            });
            
        }
    }
}
