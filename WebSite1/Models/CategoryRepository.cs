using System.Collections.Generic;

namespace WebSite1.Models
{
    public class CategoryRepository : ICategoryRepository // this is not an interface but it will implement the interface
    {
        private readonly AppDbContext _appDbContext;

            public CategoryRepository(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }
            public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }

        // this property returns all the categories and we can return it as a list
        //new Category{CategoryId = 1, CategoryName = "Items number 1", CategoryDescription = "all the items that are 1"},
        //new Category{CategoryId = 2, CategoryName = "Items number 2", CategoryDescription = "all the items that are 2"},
        //new Category{CategoryId = 3, CategoryName = "Items number 3", CategoryDescription = "all the items that are 3"},

}
