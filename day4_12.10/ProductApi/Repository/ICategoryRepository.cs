using Microsoft.EntityFrameworkCore;
using ProductApi.Model;

namespace ProductApi.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        
        Category GetCategoryByID(int CategoryId);

        void InsertCategory(Category category);

        void DeleteCategory(int CategoryId);
        void Save();
        
        void UpdateCategory(Category category);

    }
}
