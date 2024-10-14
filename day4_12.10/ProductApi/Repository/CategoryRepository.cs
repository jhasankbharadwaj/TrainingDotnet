using ProductApi.Data;
using ProductApi.Model;

namespace ProductApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _dbContext;
        public CategoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteCategory(int CategoryId)
        {
            var category = _dbContext.Categories.Find(CategoryId);
            _dbContext.Categories.Remove(category); 
             Save();
        }

        public Category GetCategoryByID(int CategoryId)
        {
            return _dbContext.Categories.Find(CategoryId);
       }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();            
        }

        public void InsertCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            
        }

        public void UpdateCategory(Category category)
        {
            var Existing = _dbContext.Categories.Find(category.Id);
            if (Existing != null)
            {
                Existing = category;
            }
        }
        public void Save()
        {

            _dbContext.SaveChanges();
        }
    }
}
